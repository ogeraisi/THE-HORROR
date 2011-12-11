using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Reversi
{
    /// <summary>
    /// Summary description for Reversi.
    /// </summary>
    public partial class ReversiForm : System.Windows.Forms.Form
    {
        // This enumeration should match the button order on the tool bar.
        public enum ToolBarButton
        {
            NewGame,
            ResignGame,
            Separator,
            UndoAllMoves,
            UndoMove,
            ResumePlay,
            RedoMove,
            RedoAllMoves
        }

        // Defines the game states.
        private enum GameState
        {
            GameOver,			// The game is over (also used for the initial state).
            InMoveAnimation,	// A move has been made and the animation is active.
            InPlayerMove,		// Waiting for the user to make a move.
            InComputerMove,		// Waiting for the computer to make a move.
            MoveCompleted		// A move has been completed (including the animation, if active).
        }

        // The game board.
        private Board board;
        private Label[] colLabels, rowLabels;
        private SquareControl[,] squareControls;

        // Game options.
        private Options options = new Options();

        // Game parameters.
        private GameState gameState;
        private int currentColor;
        private int moveNumber;

        // This timer is used to animate moves during game play.
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private static readonly int animationTimerInterval = 50;

        // AI parameters.
        private int lookAheadDepth = 6;
        //private int forfeitWeight = 35;
        //private int frontierWeight = 10;
        //private int mobilityWeight = 5;
        //private int stabilityWeight = 50;

        // Defines a thread for running the computer move look ahead.
        private Thread calculateComputerMoveThread;

        // Defines a structure for holding a look ahead move and rank.
        private class ComputerMove
        {
            public int row;
            public int col;
            public int rank;

            public ComputerMove(int row, int col)
            {
                this.row = row;
                this.col = col;
                this.rank = 0;
            }
        }

        // For converting column numbers to letters and vice versa.
        private static String alpha = "ABCDEFGHIJ";

        // Defines a structure for holding move history data.
        private class MoveRecord
        {
            public Board board;
            public int currentColor;
            public int lastMoveColor;
            public ListViewItem moveListItem;

            public MoveRecord(Board board, int currentColor, int lastMoveColor, ListViewItem moveListItem)
            {
                this.board = new Board(board);
                this.currentColor = currentColor;
                this.lastMoveColor = lastMoveColor;
                this.moveListItem = moveListItem;
            }
        }

        // Defines an array for storing the move history.
        private MoveRecord previousBoardState;

        // Used to track which player made the last move.
        private int lastMoveColor;

        // Used to suspend computer play while moves are undone/redone.
        private bool isComputerPlaySuspended;

        // For tracking the window location and size.
        private Rectangle windowSettings;

        // For loading and saving program settings.
        private ProgramSettings settings;
        private static readonly string programSettingsFileName = "Reversi.xml";

        public ReversiForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Initialize Board and labels
            this.InitializeBoard();
            this.InitializeColumnLabels();
            this.InitializeRowLabels();

            // Initialize the game state.
            this.gameState = ReversiForm.GameState.GameOver;

            // Initialize the animation timer.
            this.animationTimer.Interval = ReversiForm.animationTimerInterval;
            this.animationTimer.Tick += new EventHandler(this.AnimateMove);

            // Initialize the window settings.
            this.windowSettings = new Rectangle(
                this.DesktopLocation.X,
                this.DesktopLocation.Y,
                this.ClientSize.Width,
                this.ClientSize.Height);

            // Load any saved program settings.
            this.settings = new ProgramSettings(ReversiForm.programSettingsFileName);
            this.LoadProgramSettings();
        }

        #region Initialization Handlers
        // ===================================================================
        // This code handles initialization.
        // ===================================================================

        // Initialize Board
        private void InitializeBoard()
        {
            // Create the game board.
            this.board = new Board();

            // Create the controls for each square, add them to the squares
            // panel and set up event handling.
            this.squareControls = new SquareControl[10, 10];
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    // Create it.
                    this.squareControls[i, j] = new SquareControl(i, j);
                    // Position it.
                    this.squareControls[i, j].Left = j * this.squareControls[i, j].Width;
                    this.squareControls[i, j].Top = i * this.squareControls[i, j].Height;
                    // Add it.
                    this.squaresPanel.Controls.Add(this.squareControls[i, j]);
                    // Set up event handling for it.
                    this.squareControls[i, j].MouseMove += new MouseEventHandler(this.SquareControl_MouseMove);
                    this.squareControls[i, j].MouseLeave += new EventHandler(this.SquareControl_MouseLeave);
                    this.squareControls[i, j].Click += new EventHandler(this.SquareControl_Click);
                }
        }

        // Create the column labels.
        void InitializeColumnLabels()
        {
            this.colLabels = new Label[10];
            for (int i = 0; i < 10; ++i)
            {
                // Create a column label.
                this.colLabels[i] = new Label();

                // Set its display properties.
                this.colLabels[i].Text = ReversiForm.alpha.Substring(i, 1);
                this.colLabels[i].BackColor = this.cornerLabel.BackColor;
                this.colLabels[i].ForeColor = this.cornerLabel.ForeColor;
                this.colLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                // Set its size and position.
                this.colLabels[i].Width = this.squareControls[0, 0].Width;
                this.colLabels[i].Height = this.cornerLabel.Height;
                this.colLabels[i].Left = this.cornerLabel.Width + i * this.colLabels[0].Width;
                this.colLabels[i].Top = 0;

                // Add it.
                this.boardPanel.Controls.Add(this.colLabels[i]);
            }
        }

        // Create the row labels.
        void InitializeRowLabels()
        {
            this.rowLabels = new Label[10];
            for (int i = 0; i < 10; ++i)
            {
                // Create a row label.
                this.rowLabels[i] = new Label();

                // Set its display properties.
                this.rowLabels[i].Text = (i + 1).ToString();
                this.rowLabels[i].BackColor = this.cornerLabel.BackColor;
                this.rowLabels[i].ForeColor = this.cornerLabel.ForeColor;
                this.rowLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                // Set its size and position.
                this.rowLabels[i].Width = this.cornerLabel.Height;
                this.rowLabels[i].Height = this.squareControls[0, 0].Height;
                this.rowLabels[i].Left = 0;
                this.rowLabels[i].Top = this.cornerLabel.Height + i * this.rowLabels[0].Width;

                // Add it.
                this.boardPanel.Controls.Add(this.rowLabels[i]);
            }
        }
        #endregion

        // ===================================================================
        // This code handles game play.
        // ===================================================================

        //
        // Starts a new game or, optionally, restarts an ended game.
        //
        private void StartGame(bool isRestart = false)
        {
            // Initialize the move list.
            this.moveNumber = 1;
            this.moveListView.Items.Clear();
            this.moveListView.Refresh();

            // Initialize the last move color.
            // Can't rely on current color as the opponent
            // might had to forfeit.
            this.lastMoveColor = Board.Empty;

            // Set the first player.
            this.currentColor = this.options.FirstMove;

            // Initialize the move history.
            this.previousBoardState = null;

            // Initialize the board.
            this.board.SetForNewGame();
            this.UpdateBoardDisplay();

            // Clear the suspend computer play flag.
            this.isComputerPlaySuspended = false;

            // Start the first turn.
            this.StartTurn();
        }

        //
        // Ends the current game, optionally by player resignation.
        //
        private void EndGame(bool isResignation = false)
        {
        }

        //
        // Sets up for the current player to make a move or ends the game if
        // neither player can make a valid move.
        //
        private void StartTurn()
        {
            // If the current player cannot make a valid move, forfeit the turn.
            if (!this.board.HasAnyValidMove(this.currentColor))
            {
                this.currentColor *= -1;

                // If the original player cannot make a valid move either, the game is over.
                if (!this.board.HasAnyValidMove(this.currentColor))
                {
                    this.EndGame();
                    return;
                }
            }

            // If the current color is under computer control,
            // set up for a computer move.
            if (this.IsComputerPlayer(this.currentColor))
            {
                // Set the game state.
                this.gameState = ReversiForm.GameState.InComputerMove;

                // Start a separate thread to perform the computer's move.
                this.calculateComputerMoveThread = new Thread(new ThreadStart(this.CalculateComputerMove));
                this.calculateComputerMoveThread.IsBackground = true;
                this.calculateComputerMoveThread.Priority = System.Threading.ThreadPriority.Lowest;
                this.calculateComputerMoveThread.Name = "Calculate Computer Move";
                this.calculateComputerMoveThread.Start();
            }
            else // Otherwise, set up for a user move.
            {
                // Set the game state.
                this.gameState = ReversiForm.GameState.InPlayerMove;

                // Show valid moves, if that option is active.
                if (this.options.ShowValidMoves)
                {
                    this.HighlightValidMoves();
                    this.squaresPanel.Refresh();
                }
            }
        }

        //
        // Determines if a given color is being played by the computer.
        //
        private bool IsComputerPlayer(int color)
        {
            return ((this.options.ComputerPlaysBlack && color == Board.Black) ||
                    (this.options.ComputerPlaysWhite && color == Board.White));
        }

        //
        // Makes a move for the current player.
        //
        private void MakeMove(int row, int col)
        {
        }

        //
        // Called when a move has been completed (including any animation) to
        // start the next turn.
        //
        private void EndMove()
        {
        }

        #region Animation Handlers
        //
        // Updates the animation of a move.
        //
        private void AnimateMove(Object sender, EventArgs e)
        {
            // Lock the board to prevent race conditions.
            lock (this.board)
            {
                // If a move is being animated, advance the animation counters on
                // the square controls.
                if (this.gameState == ReversiForm.GameState.InMoveAnimation)
                {
                    bool isComplete = true;
                    for (int i = 0; i < 10; ++i)
                        for (int j = 0; j < 10; ++j)
                            if (this.squareControls[i, j].AnimationCounter > SquareControl.AnimationStop)
                            {
                                this.squareControls[i, j].AnimationCounter--;
                                isComplete = false;
                            }

                    // Refresh the display.
                    this.squaresPanel.Refresh();

                    // If the animation is complete, end the move.
                    if (isComplete)
                    {
                        this.StopMoveAnimation();
                        this.UpdateBoardDisplay();
                        this.EndMove();
                    }
                }
            }
        }

        //
        // Stops animation of a move and resets the squares.
        //
        private void StopMoveAnimation()
        {
            // Stop the animation timer.
            this.animationTimer.Stop();

            // Reset the animation counters and new disc flag on all squares.
            SquareControl squareControl;
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    squareControl = (SquareControl)this.squaresPanel.Controls[i * 10 + j];
                    squareControl.AnimationCounter = SquareControl.AnimationStop;
                    squareControl.IsNew = false;
                }
        }
        #endregion

        //
        // Makes a player-controlled move for the current color.
        //
        private void MakePlayerMove(int row, int col)
        {
            // Allow the computer to resume play.
            this.isComputerPlaySuspended = false;

            // Make the move.
            this.MakeMove(row, col);
        }

        // ===================================================================
        // Code to handle computer moves.
        // ===================================================================

        #region Threading
        //
        // Cancels the computer move thread, if it is active.
        //
        private void KillComputerMoveThread()
        {
            if (this.calculateComputerMoveThread == null || this.calculateComputerMoveThread.ThreadState == ThreadState.Stopped)
                return;

            try
            {
                this.calculateComputerMoveThread.Abort();
                this.calculateComputerMoveThread.Join();
            }
            catch (Exception)
            { }
            finally
            {
                this.calculateComputerMoveThread = null;
            }
        }

        //
        // Define delegates for callbacks from the worker thread.
        //
        public delegate void MakeComputerMoveDelegate(int row, int col);
        #endregion

        //
        // Makes a computer-controlled move for the current color.
        // Note: Called from the worker thread.
        //
        private void MakeComputerMove(int row, int col)
        {
            // Lock the board to prevent a race condition while performing the
            // move.
            lock (this.board)
                this.MakeMove(row, col);
        }

        //
        // Calculates a computer move.
        // Note: Executed in the worker thread.
        //
        private void CalculateComputerMove()
        {
        }

        // ===================================================================
        // Game AI code.
        // Note: These are executed in the worker thread.
        // ===================================================================

        //
        // This function starts the look ahead process to find the best move
        // for the current player color.
        //
        private ComputerMove GetBestMove(Board board)
        {
            // Kick off the look ahead.
            return this.GetBestMove(board, this.currentColor, 1, 0, 0);
        }

        //
        // This function uses look ahead to evaluate all valid moves for a
        // given player color and returns the best move it can find.
        //
        private ComputerMove GetBestMove(Board board, int color, int depth, int alpha, int beta)
        {
            // Initialize the best move.
            ComputerMove bestMove = new ComputerMove(-1, -1);

            // Return the best move found.
            return bestMove;
        }

        //
        // Sets the AI parameters based on the current difficulty setting.
        //
        private void SetAIParameters()
        {
            // Near the end of the game, when there are relatively few moves
            // left, set the look-ahead depth to do an exhaustive search.
            if (this.board.EmptyCount < this.lookAheadDepth)
                this.lookAheadDepth = this.board.EmptyCount;
        }

        #region Board Display Handlers
        // ===================================================================
        // Code to handle the board display.
        // ===================================================================

        //
        // Updates the display to reflect the current game board.
        //
        private void UpdateBoardDisplay()
        {
            // Set counts.
            this.blackCountLabel.Text = this.board.BlackCount.ToString();
            this.blackCountLabel.Refresh();
            this.whiteCountLabel.Text = this.board.WhiteCount.ToString();
            this.whiteCountLabel.Refresh();

            // Map the current game board to the square controls.
            SquareControl squareControl;
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    squareControl = (SquareControl)this.squaresPanel.Controls[i * 10 + j];
                    squareControl.Contents = this.board.GetSquareContents(i, j);
                    squareControl.PreviewContents = Board.Empty;
                }

            // Redraw the board.
            this.squaresPanel.Refresh();
        }

        //
        // Highlights the board squares that represent valid moves for the
        // current player.
        //
        private void HighlightValidMoves()
        {
            // Check each square.
            SquareControl squareControl;
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    squareControl = (SquareControl)this.squaresPanel.Controls[i * 10 + j];
                    if (this.board.IsValidMove(this.currentColor, i, j))
                        squareControl.IsValid = true;
                    else
                        squareControl.IsValid = false;
                }
        }

        //
        // Removes any highlighting from all the board squares.
        //
        private void UnHighlightSquares()
        {
            // Clear the flags on each square.
            SquareControl squareControl;
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    squareControl = (SquareControl)this.squaresPanel.Controls[i * 10 + j];
                    squareControl.IsActive = false;
                    squareControl.IsValid = false;
                    squareControl.IsNew = false;
                }
        }

        //
        // Sets the board square colors based on the current game options.
        //
        private void SetSquareControlColors()
        {
            SquareControl.ActiveSquareBackColor = this.options.ActiveSquareColor;
            SquareControl.NormalBackColor = this.options.BoardColor;
            SquareControl.MoveIndicatorColor = this.options.MoveIndicatorColor;
            SquareControl.ValidMoveBackColor = this.options.ValidMoveColor;
        }
        #endregion

        #region Settings Handlers
        //====================================================================
        // These functions to handle the loading and saving of the program
        // settings.
        //====================================================================

        //
        // Loads any saved program settings.
        //
        private void LoadProgramSettings()
        {
            // Load the saved window settings and resize the window.
            try
            {
                // Load the saved window settings.
                int left = System.Int32.Parse(this.settings.GetValue("Window", "Left"));
                int top = System.Int32.Parse(this.settings.GetValue("Window", "Top"));
                int width = System.Int32.Parse(this.settings.GetValue("Window", "Width"));
                int height = System.Int32.Parse(this.settings.GetValue("Window", "Height"));

                // Reposition and resize the window.
                this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                this.DesktopLocation = new Point(left, top);
                this.ClientSize = new Size(width, height);

                // Load saved options.
                this.options.ShowValidMoves = (bool)System.Boolean.Parse(this.settings.GetValue("Options", "ShowValidMoves"));
                this.options.PreviewMoves = (bool)System.Boolean.Parse(this.settings.GetValue("Options", "PreviewMoves"));
                this.options.AnimateMoves = (bool)System.Boolean.Parse(this.settings.GetValue("Options", "AnimateMoves"));
                this.options.BoardColor = Color.FromArgb(System.Int32.Parse(this.settings.GetValue("Options", "BoardColor")));
                this.options.ValidMoveColor = Color.FromArgb(System.Int32.Parse(this.settings.GetValue("Options", "ValidMoveColor")));
                this.options.ActiveSquareColor = Color.FromArgb(System.Int32.Parse(this.settings.GetValue("Options", "ActiveSquareColor")));
                this.options.MoveIndicatorColor = Color.FromArgb(System.Int32.Parse(this.settings.GetValue("Options", "MoveIndicatorColor")));
                this.options.FirstMove = (int)System.Int32.Parse(this.settings.GetValue("Options", "FirstMove"));
                this.options.ComputerPlaysBlack = (bool)System.Boolean.Parse(this.settings.GetValue("Options", "ComputerPlaysBlack"));
                this.options.ComputerPlaysWhite = (bool)System.Boolean.Parse(this.settings.GetValue("Options", "ComputerPlaysWhite"));

                // Set the square control colors based on options loaded.
                this.SetSquareControlColors();
            }
            catch (Exception)
            { }
        }

        //
        // Saves the current program settings.
        //
        private void SaveProgramSettings()
        {
            // Save window settings.
            this.settings.SetValue("Window", "Left", this.windowSettings.Left.ToString());
            this.settings.SetValue("Window", "Top", this.windowSettings.Top.ToString());
            this.settings.SetValue("Window", "Width", this.windowSettings.Width.ToString());
            this.settings.SetValue("Window", "Height", this.windowSettings.Height.ToString());

            // Save game options.
            this.settings.SetValue("Options", "ShowValidMoves", this.options.ShowValidMoves.ToString());
            this.settings.SetValue("Options", "PreviewMoves", this.options.PreviewMoves.ToString());
            this.settings.SetValue("Options", "AnimateMoves", this.options.AnimateMoves.ToString());
            this.settings.SetValue("Options", "BoardColor", SquareControl.NormalBackColor.ToArgb().ToString());
            this.settings.SetValue("Options", "ValidMoveColor", SquareControl.ValidMoveBackColor.ToArgb().ToString());
            this.settings.SetValue("Options", "ActiveSquareColor", SquareControl.ActiveSquareBackColor.ToArgb().ToString());
            this.settings.SetValue("Options", "MoveIndicatorColor", SquareControl.MoveIndicatorColor.ToArgb().ToString());
            this.settings.SetValue("Options", "FirstMove", this.options.FirstMove.ToString());
            this.settings.SetValue("Options", "ComputerPlaysBlack", this.options.ComputerPlaysBlack.ToString());
            this.settings.SetValue("Options", "ComputerPlaysWhite", this.options.ComputerPlaysWhite.ToString());

            // Save the program settings.
            this.settings.Save();
        }
        #endregion

        #region Event Handlers for ReversiForm
        //====================================================================
        // Event handlers for the form.
        //====================================================================

        //
        // Handles a window close.
        //
        private void ReversiForm_Closed(object sender, System.EventArgs e)
        {
            // Stop the computer move thread, if active.
            this.KillComputerMoveThread();

            // Save the current program settings.
            this.SaveProgramSettings();
        }

        //
        // Handles a window move.
        //
        private void ReversiForm_Move(object sender, System.EventArgs e)
        {
            // If the window has not been minimized or maximized, save its location.
            if (this.WindowState == FormWindowState.Normal)
            {
                this.windowSettings.X = this.DesktopLocation.X;
                this.windowSettings.Y = this.DesktopLocation.Y;
            }
        }

        //
        // Handles a window resize.
        //
        private void ReversiForm_Resize(object sender, System.EventArgs e)
        {
            // Determine the size each square should be within the board.
            int l = (int)(Math.Min(this.squaresPanel.Width, this.squaresPanel.Height) / 10);
            l = Math.Max(l, 10);

            // Resize and reposition each square control.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    this.squareControls[i, j].Width = l;
                    this.squareControls[i, j].Height = l;
                    this.squareControls[i, j].Left = j * l;
                    this.squareControls[i, j].Top = i * l;
                }

            // Fix the column and row headers.
            for (int i = 0; i < 10; ++i)
            {
                this.colLabels[i].Width = l;
                this.colLabels[i].Left = this.cornerLabel.Width + i * l;
                this.rowLabels[i].Height = l;
                this.rowLabels[i].Top = this.cornerLabel.Height + i * l;
            }

            // Fix the info panel height to align it's bottom with the bottom row of squares.
            this.infoPanel.Height = 10 * l + this.colLabels[0].Height;

            // If the window has not been minimized or maximized, save it size.
            if (this.WindowState == FormWindowState.Normal)
            {
                this.windowSettings.Width = this.ClientSize.Width;
                this.windowSettings.Height = this.ClientSize.Height;
            }
        }
        #endregion

        #region Event Handlers for Menu Items
        //====================================================================
        // Event handlers for the menu items.
        //====================================================================

        //
        // Handles a "New Game" click.
        //
        private void newGameMenuItem_Click(object sender, System.EventArgs e)
        {
            // Start a new game.
            this.StartGame();
        }

        //
        // Handles a "Resign Game" click.
        //
        private void resignGameMenuItem_Click(object sender, System.EventArgs e)
        {
            // Stop the computer move thread, if active.
            this.KillComputerMoveThread();

            // Stop any active animation and reset the board display.
            this.StopMoveAnimation();
            this.UnHighlightSquares();
            this.UpdateBoardDisplay();

            // End the game with the resignation flag set.
            this.EndGame(true);
        }

        //
        // Handles an "Options..." click.
        //
        private void optionsMenuItem_Click(object sender, System.EventArgs e)
        {
            // Create the options dialog and set the option controls according
            // to the current game options.
            OptionsDialog dlg = new OptionsDialog(this.options);

            // Show the options dialog and if the "OK" button was pressed,
            // update the game options.
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                // Update the game options that are safe to change using the
                // values from the dialog.
                this.options.ShowValidMoves = dlg.Options.ShowValidMoves;
                this.options.PreviewMoves = dlg.Options.PreviewMoves;
                this.options.AnimateMoves = dlg.Options.AnimateMoves;
                this.options.BoardColor = dlg.Options.BoardColor;
                this.options.ValidMoveColor = dlg.Options.ValidMoveColor;
                this.options.ActiveSquareColor = dlg.Options.ActiveSquareColor;
                this.options.MoveIndicatorColor = dlg.Options.MoveIndicatorColor;

                // Set the square control colors based on the current color options.
                this.SetSquareControlColors();

                // If a game is currently in progress, special handling is
                // needed for changes to the player options.
                if (this.gameState != ReversiForm.GameState.GameOver)
                {
                    // Lock the board to prevent race conditions.
                    lock (this.board)
                    {
                        // If a move is currently being animated, complete it
                        // now.
                        if (this.gameState == ReversiForm.GameState.InMoveAnimation)
                        {
                            // Stop animation and end the move.
                            this.StopMoveAnimation();
                            this.UpdateBoardDisplay();
                            this.EndMove();
                        }

                        // Clear any board square highlighting.
                        this.UnHighlightSquares();

                        // If the changes to the player options affect the
                        // current player, restart the current turn.
                        if ((dlg.Options.FirstMove != this.options.FirstMove && this.lastMoveColor == Board.Empty) ||
                            dlg.Options.ComputerPlaysBlack != this.options.ComputerPlaysBlack ||
                            dlg.Options.ComputerPlaysWhite != this.options.ComputerPlaysWhite)
                        {
                            // Kill any currently active computer move.
                            this.KillComputerMoveThread();

                            // Set the player options.
                            this.options.FirstMove = dlg.Options.FirstMove;
                            this.options.ComputerPlaysBlack = dlg.Options.ComputerPlaysBlack;
                            this.options.ComputerPlaysWhite = dlg.Options.ComputerPlaysWhite;

                            // If no moves have been made yet, set the current color
                            // based on the first move option.
                            if (this.lastMoveColor == Board.Empty)
                                this.currentColor = this.options.FirstMove;

                            // Update the board display.
                            this.squaresPanel.Refresh();

                            // Restart the current turn.
                            this.StartTurn();
                        }

                        // Otherwise, set the player options and update the
                        // board display.
                        else
                        {
                            // Set the player options.
                            this.options.FirstMove = dlg.Options.FirstMove;
                            this.options.ComputerPlaysBlack = dlg.Options.ComputerPlaysBlack;
                            this.options.ComputerPlaysWhite = dlg.Options.ComputerPlaysWhite;

                            // Highlight valid moves, if appropriate.
                            if (this.options.ShowValidMoves && !this.IsComputerPlayer(this.currentColor))
                                this.HighlightValidMoves();

                            // Update the board display.	
                            this.squaresPanel.Refresh();
                        }
                    }
                }

                // A game is not in progress so just set the player options.
                else
                {
                    this.options.FirstMove = dlg.Options.FirstMove;
                    this.options.ComputerPlaysBlack = dlg.Options.ComputerPlaysBlack;
                    this.options.ComputerPlaysWhite = dlg.Options.ComputerPlaysWhite;

                    // Update the board display, in case the colors have been
                    // changed.
                    this.squaresPanel.Refresh();
                }
            }

            dlg.Dispose();
        }

        //
        // Handles an "Exit" click.
        //
        private void exitMenuItem_Click(object sender, System.EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        //
        // Handles a "Resume Play" click.
        //
        private void resumePlayMenuItem_Click(object sender, System.EventArgs e)
        {
            // Disable the "Redo Move," "Redo All Moves" and "Resume Play"
            // menu items and tool bar buttons.
            this.redoMoveMenuItem.Enabled =
                this.playToolBar.Buttons[(int)ReversiForm.ToolBarButton.RedoMove].Enabled =
                this.playToolBar.Buttons[(int)ReversiForm.ToolBarButton.RedoAllMoves].Enabled = false;
            this.resumePlayMenuItem.Enabled =
                this.playToolBar.Buttons[(int)ReversiForm.ToolBarButton.ResumePlay].Enabled = false;

            // Set the game state.
            this.gameState = ReversiForm.GameState.MoveCompleted;

            // Clear the suspend computer play flag and restart the turn.
            this.isComputerPlaySuspended = false;
            this.StartTurn();
        }
        #endregion

        #region Event Handlers for Square Controls
        // ===================================================================
        // Event handlers for the square controls.
        // ===================================================================

        //
        // Handles a mouse move on a board square.
        //
        private void SquareControl_MouseMove(object sender, MouseEventArgs e)
        {
            // Check the game state to ensure that it is the user's turn.
            if (this.gameState != ReversiForm.GameState.InPlayerMove)
                return;

            SquareControl squareControl = (SquareControl)sender;

            // If the square is a valid move for the current player,
            // indicate it.
            if (this.board.IsValidMove(this.currentColor, squareControl.Row, squareControl.Col))
            {
                if (!squareControl.IsActive)
                {
                    // If the show valid moves option is active, mark the
                    // square.
                    if (this.options.ShowValidMoves)
                    {
                        squareControl.IsActive = true;

                        // If the preview moves option is not active, update
                        // the square display now.
                        if (!this.options.PreviewMoves)
                            squareControl.Refresh();
                    }

                    // If the preview moves option is active, mark the
                    // appropriate squares.
                    if (this.options.PreviewMoves)
                    {
                        // Create a temporary board to make the move on.
                        Board board = new Board(this.board);
                        board.MakeMove(this.currentColor, squareControl.Row, squareControl.Col);

                        // Set up the move preview.
                        for (int i = 0; i < 10; ++i)
                            for (int j = 0; j < 10; ++j)
                                if (board.GetSquareContents(i, j) != this.board.GetSquareContents(i, j))
                                {
                                    // Set and update the square display.
                                    this.squareControls[i, j].PreviewContents = board.GetSquareContents(i, j);
                                    this.squareControls[i, j].Refresh();
                                }
                    }
                }

                // Change the cursor.
                squareControl.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        //
        // Handles a mouse leave on a board square.
        //
        private void SquareControl_MouseLeave(object sender, System.EventArgs e)
        {
            SquareControl squareControl = (SquareControl)sender;

            // If the square is currently active, deactivate it.
            if (squareControl.IsActive)
            {
                squareControl.IsActive = false;
                squareControl.Refresh();
            }

            // If the move is being previewed, clear all affected squares.
            if (squareControl.PreviewContents != Board.Empty)
            {
                // Clear the move preview.
                for (int i = 0; i < 10; ++i)
                    for (int j = 0; j < 10; ++j)
                        if (this.squareControls[i, j].PreviewContents != Board.Empty)
                        {
                            this.squareControls[i, j].PreviewContents = Board.Empty;
                            this.squareControls[i, j].Refresh();
                        }
            }

            // Restore the cursor.
            squareControl.Cursor = System.Windows.Forms.Cursors.Default;
        }

        //
        // Handles a click on a board square.
        //
        private void SquareControl_Click(object sender, System.EventArgs e)
        {
            // Check the game state to ensure it's the user's turn.
            if (this.gameState != ReversiForm.GameState.InPlayerMove)
                return;

            SquareControl squareControl = (SquareControl)sender;

            // If the move is valid, make it.
            if (this.board.IsValidMove(this.currentColor, squareControl.Row, squareControl.Col))
            {
                // Restore the cursor.
                squareControl.Cursor = System.Windows.Forms.Cursors.Default;

                // Make the move.
                this.MakePlayerMove(squareControl.Row, squareControl.Col);
            }
        }
        #endregion
    }
}
