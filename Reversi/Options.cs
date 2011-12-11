using System;
using System.Drawing;

namespace Reversi
{
    /// <summary>
    /// Summary description for Options.
    /// </summary>
    public class Options
    {

        // Define the game options.
        public bool ShowValidMoves;
        public bool PreviewMoves;
        public bool AnimateMoves;
        public Color BoardColor;
        public Color ValidMoveColor;
        public Color ActiveSquareColor;
        public Color MoveIndicatorColor;
        public int FirstMove;
        public bool ComputerPlaysBlack;
        public bool ComputerPlaysWhite;

        //
        // Creates a new Options object using the defaults.
        //
        public Options()
        {
            // Initialize the game options to their default values.
            this.RestoreDefaults();
        }

        //
        // Creates a new Options object by copying an existing one.
        //
        public Options(Options options)
        {
            this.ShowValidMoves = options.ShowValidMoves;
            this.PreviewMoves = options.PreviewMoves;
            this.AnimateMoves = options.AnimateMoves;
            this.BoardColor = options.BoardColor;
            this.ValidMoveColor = options.ValidMoveColor;
            this.ActiveSquareColor = options.ActiveSquareColor;
            this.MoveIndicatorColor = options.MoveIndicatorColor;
            this.FirstMove = options.FirstMove;
            this.ComputerPlaysBlack = options.ComputerPlaysBlack;
            this.ComputerPlaysWhite = options.ComputerPlaysWhite;
        }

        //
        // Restores all game options to their default values.
        //
        public void RestoreDefaults()
        {
            this.ShowValidMoves = true;
            this.AnimateMoves = true;
            this.PreviewMoves = false;
            this.BoardColor = SquareControl.NormalBackColorDefault;
            this.ValidMoveColor = SquareControl.ValidMoveBackColorDefault;
            this.ActiveSquareColor = SquareControl.ActiveSquareBackColorDefault;
            this.MoveIndicatorColor = SquareControl.MoveIndicatorColorDefault;
            this.FirstMove = Board.Black;
            this.ComputerPlaysBlack = false;
            this.ComputerPlaysWhite = true;
        }
    }
}
