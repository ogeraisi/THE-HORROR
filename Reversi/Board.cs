using System;

namespace Reversi
{
    /// <summary>
    /// Summary description for Board.
    /// </summary>
    public class Board
    {
        // These constants represent the contents of a board square.
        public static readonly int Black = -1;
        public static readonly int Empty = 0;
        public static readonly int White = 1;

        // These counts reflect the current board situation.
        public int BlackCount
        {
            get { return this.blackCount; }
        }
        public int WhiteCount
        {
            get { return this.whiteCount; }
        }
        public int EmptyCount
        {
            get { return this.emptyCount; }
        }
        public int BlackFrontierCount
        {
            get { return this.blackFrontierCount; }
        }
        public int WhiteFrontierCount
        {
            get { return this.whiteFrontierCount; }
        }
        public int BlackSafeCount
        {
            get { return this.blackSafeCount; }
        }
        public int WhiteSafeCount
        {
            get { return this.whiteSafeCount; }
        }

        // Internal counts.
        private int blackCount;
        private int whiteCount;
        private int emptyCount;
        private int blackFrontierCount;
        private int whiteFrontierCount;
        private int blackSafeCount;
        private int whiteSafeCount;

        // This two-dimensional array represents the squares on the board.
        private int[,] squares;

        // This two-dimensional array tracks which discs are safe (i.e.,
        // discs that cannot be outflanked in any direction).
        private bool[,] safeDiscs;

        //
        // Creates a new, empty Board object.
        //
        public Board()
        {
            // Create the squares and safe disc map.
            this.squares = new int[10, 10];
            this.safeDiscs = new bool[10, 10];

            // Clear the board and map.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    this.squares[i, j] = Board.Empty;
                    this.safeDiscs[i, j] = false;
                }

            // Update the counts.
            this.UpdateCounts();
        }

        //
        // Creates a new Board object by copying an existing one.
        //
        public Board(Board board)
        {
            // Create the squares and map.
            this.squares = new int[10, 10];
            this.safeDiscs = new bool[10, 10];

            // Copy the given board.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    this.squares[i, j] = board.squares[i, j];
                    this.safeDiscs[i, j] = board.safeDiscs[i, j];
                }

            // Copy the counts.
            this.blackCount = board.blackCount;
            this.whiteCount = board.whiteCount;
            this.emptyCount = board.emptyCount;
            this.blackSafeCount = board.blackSafeCount;
            this.whiteSafeCount = board.whiteSafeCount;
        }

        //
        // Sets a board with the initial game set-up.
        //
        public void SetForNewGame()
        {
            // Clear the board.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    this.squares[i, j] = Board.Empty;
                    this.safeDiscs[i, j] = false;
                }

            // Set two black and two white discs in the center.
            this.squares[4, 4] = White;
            this.squares[4, 5] = Black;
            this.squares[5, 4] = Black;
            this.squares[5, 5] = White;

            // Update the counts.
            this.UpdateCounts();
        }

        //
        // Returns the contents of a given board square.
        //
        public int GetSquareContents(int row, int col)
        {
            return this.squares[row, col];
        }

        //
        // Places a disc for the player on the board and flips any outflanked
        // opponents.
        // Note: For performance reasons, it does NOT check that the move is
        // valid.
        //
        public void MakeMove(int color, int row, int col)
        {
        }

        //
        // Determines if the player can make any valid move on the board.
        //
        public bool HasAnyValidMove(int color)
        {
            // Check all board positions for a valid move.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                    if (this.IsValidMove(color, i, j))
                        return true;

            // None found.
            return false;
        }

        //
        // Determines if a specific move is valid for the player.
        //
        public bool IsValidMove(int color, int row, int col)
        {
            // The square must be empty.
            if (this.squares[row, col] != Board.Empty)
                return false;

            // Must be able to flip at least one opponent disc.
            for (int i = -1; i <= 1; ++i)
                for (int j = -1; j <= 1; ++j)
                    if ((i != 0 || j != 0) && this.IsOutflanking(color, row, col, i, j))
                        return true;

            // No opponents could be flipped.
            return false;
        }

        //
        // Returns the number of valid moves a player can make on the board.
        //
        public int GetValidMoveCount(int color)
        {
            int count = 0;

            // Check all board positions.
            // If the move is valid for the color, bump the count.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                    if (this.IsValidMove(color, i, j))
                        count++;
            return count;
        }

        //
        // Given a player move and a specific direction, determines if any
        // opponent discs will be outflanked.
        // Note: For performance reasons the direction values are NOT checked
        // for validity (dr and dc may be one of -1, 0 or 1 but both should
        // not be zero).
        //
        private bool IsOutflanking(int color, int row, int col, int dr, int dc)
        {
            return true;
        }

        //
        // Updates the board counts and safe disc map.
        // Note: MUST be called after any changes to the board contents.
        //
        private void UpdateCounts()
        {
            // Reset all counts.
            this.blackCount = 0;
            this.whiteCount = 0;
            this.emptyCount = 0;
            this.blackFrontierCount = 0;
            this.whiteFrontierCount = 0;
            this.whiteSafeCount = 0;
            this.blackSafeCount = 0;

            // Update the safe disc map.
            //
            // All currently unsafe discs are checked to see if they are still
            // outflankable. Those that are not are marked as safe.
            // If any new safe discs were found, the process is repeated
            // because this change may have made other discs safe as well. The
            // loop exits when no new safe discs are found.
            bool statusChanged = true;
            while (statusChanged)
            {
                statusChanged = false;
                for (int i = 0; i < 10; ++i)
                    for (int j = 0; j < 10; ++j)
                        if (this.squares[i, j] != Board.Empty && !this.safeDiscs[i, j] && !this.IsOutflankable(i, j))
                        {
                            this.safeDiscs[i, j] = true;
                            statusChanged = true;
                        }
            }

            // Tally the counts.
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    // If there is a disc at this position, determine if it is
                    // on the frontier (i.e., adjacent to an empty square).
                    bool isFrontier = false;
                    if (this.squares[i, j] != Board.Empty)
                    {
                        for (int dr = -1; dr <= 1; ++dr)
                            for (int dc = -1; dc <= 1; ++dc)
                                if ((dr != 0 || dc != 0) && i + dr >= 0 && i + dr < 10 && j + dc >= 0 && j + dc < 10 && this.squares[i + dr, j + dc] == Board.Empty)
                                    isFrontier = true;
                    }

                    // Update the counts.
                    if (this.squares[i, j] == Board.Black)
                    {
                        this.blackCount++;
                        if (isFrontier)
                            this.blackFrontierCount++;
                        if (this.safeDiscs[i, j])
                            this.blackSafeCount++;
                    }
                    else if (this.squares[i, j] == Board.White)
                    {
                        this.whiteCount++;
                        if (isFrontier)
                            this.whiteFrontierCount++;
                        if (this.safeDiscs[i, j])
                            this.whiteSafeCount++;
                    }
                    else
                        this.emptyCount++;
                }
        }

        //
        // Returns true if the disc at the given position can be outflanked in
        // any direction.
        // Note: For performance reasons we do NOT check that the square has a
        // disc.
        //
        private bool IsOutflankable(int row, int col)
        {
            return true;
        }
    }
}
