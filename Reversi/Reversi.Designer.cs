namespace Reversi
{
    partial class ReversiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReversiForm));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.currentColorPanel = new System.Windows.Forms.Panel();
            this.whiteCountLabel = new System.Windows.Forms.Label();
            this.whiteTextLabel = new System.Windows.Forms.Label();
            this.currentColorTextLabel = new System.Windows.Forms.Label();
            this.blackCountLabel = new System.Windows.Forms.Label();
            this.blackTextLabel = new System.Windows.Forms.Label();
            this.moveListView = new System.Windows.Forms.ListView();
            this.moveNullColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moveNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movePlayerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movePositionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.squaresPanel = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.gameMenuItem = new System.Windows.Forms.MenuItem();
            this.newGameMenuItem = new System.Windows.Forms.MenuItem();
            this.resignGameMenuItem = new System.Windows.Forms.MenuItem();
            this.gameSeparator1MenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.gameSeparator2MenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.moveMenuItem = new System.Windows.Forms.MenuItem();
            this.undoMoveMenuItem = new System.Windows.Forms.MenuItem();
            this.redoMoveMenuItem = new System.Windows.Forms.MenuItem();
            this.moveSeparatorMenuItem = new System.Windows.Forms.MenuItem();
            this.resumePlayMenuItem = new System.Windows.Forms.MenuItem();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.cornerLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.playToolBar = new System.Windows.Forms.ToolBar();
            this.newGameToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.resignGameToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.separatorToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.undoMoveToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.resumePlayToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.redoMoveToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.playImageList = new System.Windows.Forms.ImageList(this.components);
            this.infoPanel.SuspendLayout();
            this.boardPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.Controls.Add(this.currentColorPanel);
            this.infoPanel.Controls.Add(this.whiteCountLabel);
            this.infoPanel.Controls.Add(this.whiteTextLabel);
            this.infoPanel.Controls.Add(this.currentColorTextLabel);
            this.infoPanel.Controls.Add(this.blackCountLabel);
            this.infoPanel.Controls.Add(this.blackTextLabel);
            this.infoPanel.Controls.Add(this.moveListView);
            this.infoPanel.Location = new System.Drawing.Point(261, 37);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(202, 265);
            this.infoPanel.TabIndex = 3;
            // 
            // currentColorPanel
            // 
            this.currentColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorPanel.Location = new System.Drawing.Point(106, 65);
            this.currentColorPanel.Name = "currentColorPanel";
            this.currentColorPanel.Size = new System.Drawing.Size(19, 18);
            this.currentColorPanel.TabIndex = 5;
            this.currentColorPanel.Visible = false;
            // 
            // whiteCountLabel
            // 
            this.whiteCountLabel.Location = new System.Drawing.Point(96, 37);
            this.whiteCountLabel.Name = "whiteCountLabel";
            this.whiteCountLabel.Size = new System.Drawing.Size(29, 15);
            this.whiteCountLabel.TabIndex = 3;
            this.whiteCountLabel.Text = "0";
            this.whiteCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // whiteTextLabel
            // 
            this.whiteTextLabel.AutoSize = true;
            this.whiteTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteTextLabel.Location = new System.Drawing.Point(48, 37);
            this.whiteTextLabel.Name = "whiteTextLabel";
            this.whiteTextLabel.Size = new System.Drawing.Size(52, 17);
            this.whiteTextLabel.TabIndex = 2;
            this.whiteTextLabel.Text = "White: ";
            // 
            // currentColorTextLabel
            // 
            this.currentColorTextLabel.AutoSize = true;
            this.currentColorTextLabel.Location = new System.Drawing.Point(38, 65);
            this.currentColorTextLabel.Name = "currentColorTextLabel";
            this.currentColorTextLabel.Size = new System.Drawing.Size(63, 17);
            this.currentColorTextLabel.TabIndex = 4;
            this.currentColorTextLabel.Text = "Current: ";
            this.currentColorTextLabel.Visible = false;
            // 
            // blackCountLabel
            // 
            this.blackCountLabel.Location = new System.Drawing.Point(96, 9);
            this.blackCountLabel.Name = "blackCountLabel";
            this.blackCountLabel.Size = new System.Drawing.Size(29, 15);
            this.blackCountLabel.TabIndex = 1;
            this.blackCountLabel.Text = "0";
            this.blackCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blackTextLabel
            // 
            this.blackTextLabel.AutoSize = true;
            this.blackTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackTextLabel.Location = new System.Drawing.Point(48, 9);
            this.blackTextLabel.Name = "blackTextLabel";
            this.blackTextLabel.Size = new System.Drawing.Size(50, 17);
            this.blackTextLabel.TabIndex = 0;
            this.blackTextLabel.Text = "Black: ";
            // 
            // moveListView
            // 
            this.moveListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.moveListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.moveNullColumn,
            this.moveNumberColumn,
            this.movePlayerColumn,
            this.movePositionColumn});
            this.moveListView.FullRowSelect = true;
            this.moveListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.moveListView.Location = new System.Drawing.Point(2, 102);
            this.moveListView.Name = "moveListView";
            this.moveListView.Size = new System.Drawing.Size(197, 163);
            this.moveListView.TabIndex = 6;
            this.moveListView.TabStop = false;
            this.moveListView.UseCompatibleStateImageBehavior = false;
            this.moveListView.View = System.Windows.Forms.View.Details;
            // 
            // moveNullColumn
            // 
            this.moveNullColumn.Text = "";
            this.moveNullColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moveNullColumn.Width = 0;
            // 
            // moveNumberColumn
            // 
            this.moveNumberColumn.Text = "#";
            this.moveNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moveNumberColumn.Width = 32;
            // 
            // movePlayerColumn
            // 
            this.movePlayerColumn.Text = "Player";
            this.movePlayerColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.movePlayerColumn.Width = 52;
            // 
            // movePositionColumn
            // 
            this.movePositionColumn.Text = "Position";
            this.movePositionColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.movePositionColumn.Width = 62;
            // 
            // squaresPanel
            // 
            this.squaresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.squaresPanel.Location = new System.Drawing.Point(19, 18);
            this.squaresPanel.Name = "squaresPanel";
            this.squaresPanel.Size = new System.Drawing.Size(213, 243);
            this.squaresPanel.TabIndex = 1;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.gameMenuItem,
            this.moveMenuItem});
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.Index = 0;
            this.gameMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newGameMenuItem,
            this.resignGameMenuItem,
            this.gameSeparator1MenuItem,
            this.optionsMenuItem,
            this.gameSeparator2MenuItem,
            this.exitMenuItem});
            this.gameMenuItem.ShowShortcut = false;
            this.gameMenuItem.Text = "&Game";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Index = 0;
            this.newGameMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.newGameMenuItem.Text = "&New Game";
            this.newGameMenuItem.Click += new System.EventHandler(this.newGameMenuItem_Click);
            // 
            // resignGameMenuItem
            // 
            this.resignGameMenuItem.Enabled = false;
            this.resignGameMenuItem.Index = 1;
            this.resignGameMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.resignGameMenuItem.Text = "&Resign Game";
            this.resignGameMenuItem.Click += new System.EventHandler(this.resignGameMenuItem_Click);
            // 
            // gameSeparator1MenuItem
            // 
            this.gameSeparator1MenuItem.Index = 2;
            this.gameSeparator1MenuItem.Text = "-";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 3;
            this.optionsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.optionsMenuItem.Text = "&Options...";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // gameSeparator2MenuItem
            // 
            this.gameSeparator2MenuItem.Index = 4;
            this.gameSeparator2MenuItem.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 5;
            this.exitMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // moveMenuItem
            // 
            this.moveMenuItem.Index = 1;
            this.moveMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.undoMoveMenuItem,
            this.redoMoveMenuItem,
            this.moveSeparatorMenuItem,
            this.resumePlayMenuItem});
            this.moveMenuItem.ShowShortcut = false;
            this.moveMenuItem.Text = "&Move";
            // 
            // undoMoveMenuItem
            // 
            this.undoMoveMenuItem.Enabled = false;
            this.undoMoveMenuItem.Index = 0;
            this.undoMoveMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.undoMoveMenuItem.Text = "&Undo Move";
            // 
            // redoMoveMenuItem
            // 
            this.redoMoveMenuItem.Enabled = false;
            this.redoMoveMenuItem.Index = 1;
            this.redoMoveMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.redoMoveMenuItem.Text = "&Redo Move";
            // 
            // moveSeparatorMenuItem
            // 
            this.moveSeparatorMenuItem.Index = 2;
            this.moveSeparatorMenuItem.Text = "-";
            // 
            // resumePlayMenuItem
            // 
            this.resumePlayMenuItem.Enabled = false;
            this.resumePlayMenuItem.Index = 3;
            this.resumePlayMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.resumePlayMenuItem.Text = "Resume &Play";
            this.resumePlayMenuItem.Click += new System.EventHandler(this.resumePlayMenuItem_Click);
            // 
            // boardPanel
            // 
            this.boardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.boardPanel.Controls.Add(this.cornerLabel);
            this.boardPanel.Controls.Add(this.squaresPanel);
            this.boardPanel.Location = new System.Drawing.Point(10, 37);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(232, 261);
            this.boardPanel.TabIndex = 2;
            // 
            // cornerLabel
            // 
            this.cornerLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cornerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cornerLabel.Location = new System.Drawing.Point(0, 0);
            this.cornerLabel.Name = "cornerLabel";
            this.cornerLabel.Size = new System.Drawing.Size(19, 18);
            this.cornerLabel.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(19, 2);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Location = new System.Drawing.Point(10, 307);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(453, 28);
            this.statusPanel.TabIndex = 4;
            // 
            // playToolBar
            // 
            this.playToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.newGameToolBarButton,
            this.resignGameToolBarButton,
            this.separatorToolBarButton,
            this.undoMoveToolBarButton,
            this.resumePlayToolBarButton,
            this.redoMoveToolBarButton});
            this.playToolBar.Divider = false;
            this.playToolBar.DropDownArrows = true;
            this.playToolBar.ImageList = this.playImageList;
            this.playToolBar.Location = new System.Drawing.Point(0, 0);
            this.playToolBar.Name = "playToolBar";
            this.playToolBar.ShowToolTips = true;
            this.playToolBar.Size = new System.Drawing.Size(472, 26);
            this.playToolBar.TabIndex = 1;
            // 
            // newGameToolBarButton
            // 
            this.newGameToolBarButton.ImageIndex = 0;
            this.newGameToolBarButton.Name = "newGameToolBarButton";
            this.newGameToolBarButton.ToolTipText = "New Game";
            // 
            // resignGameToolBarButton
            // 
            this.resignGameToolBarButton.Enabled = false;
            this.resignGameToolBarButton.ImageIndex = 1;
            this.resignGameToolBarButton.Name = "resignGameToolBarButton";
            this.resignGameToolBarButton.ToolTipText = "Resign Game";
            // 
            // separatorToolBarButton
            // 
            this.separatorToolBarButton.Name = "separatorToolBarButton";
            this.separatorToolBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // undoMoveToolBarButton
            // 
            this.undoMoveToolBarButton.Enabled = false;
            this.undoMoveToolBarButton.ImageIndex = 2;
            this.undoMoveToolBarButton.Name = "undoMoveToolBarButton";
            this.undoMoveToolBarButton.ToolTipText = "Undo Move";
            // 
            // resumePlayToolBarButton
            // 
            this.resumePlayToolBarButton.Enabled = false;
            this.resumePlayToolBarButton.ImageIndex = 3;
            this.resumePlayToolBarButton.Name = "resumePlayToolBarButton";
            this.resumePlayToolBarButton.ToolTipText = "Resume Play";
            // 
            // redoMoveToolBarButton
            // 
            this.redoMoveToolBarButton.Enabled = false;
            this.redoMoveToolBarButton.ImageIndex = 4;
            this.redoMoveToolBarButton.Name = "redoMoveToolBarButton";
            this.redoMoveToolBarButton.ToolTipText = "Redo Move";
            // 
            // playImageList
            // 
            this.playImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playImageList.ImageStream")));
            this.playImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.playImageList.Images.SetKeyName(0, "");
            this.playImageList.Images.SetKeyName(1, "");
            this.playImageList.Images.SetKeyName(2, "");
            this.playImageList.Images.SetKeyName(3, "");
            this.playImageList.Images.SetKeyName(4, "");
            // 
            // ReversiForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.Controls.Add(this.playToolBar);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.Name = "ReversiForm";
            this.Text = "Reversi";
            this.Closed += new System.EventHandler(this.ReversiForm_Closed);
            this.Move += new System.EventHandler(this.ReversiForm_Move);
            this.Resize += new System.EventHandler(this.ReversiForm_Resize);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.boardPanel.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Main menu.
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem gameMenuItem;
        private System.Windows.Forms.MenuItem newGameMenuItem;
        private System.Windows.Forms.MenuItem resignGameMenuItem;
        private System.Windows.Forms.MenuItem gameSeparator1MenuItem;
        private System.Windows.Forms.MenuItem optionsMenuItem;
        private System.Windows.Forms.MenuItem gameSeparator2MenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem moveMenuItem;
        private System.Windows.Forms.MenuItem undoMoveMenuItem;
        private System.Windows.Forms.MenuItem redoMoveMenuItem;
        private System.Windows.Forms.MenuItem moveSeparatorMenuItem;
        private System.Windows.Forms.MenuItem resumePlayMenuItem;

        // Tool bar.
        private System.Windows.Forms.ToolBar playToolBar;
        private System.Windows.Forms.ImageList playImageList;
        private System.Windows.Forms.ToolBarButton newGameToolBarButton;
        private System.Windows.Forms.ToolBarButton resignGameToolBarButton;
        private System.Windows.Forms.ToolBarButton separatorToolBarButton;
        private System.Windows.Forms.ToolBarButton undoAllMovesToolBarButton;
        private System.Windows.Forms.ToolBarButton undoMoveToolBarButton;
        private System.Windows.Forms.ToolBarButton resumePlayToolBarButton;
        private System.Windows.Forms.ToolBarButton redoMoveToolBarButton;
        private System.Windows.Forms.ToolBarButton redoAllMovesToolBarButton;

        // Board display.
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label cornerLabel;
        private System.Windows.Forms.Panel squaresPanel;

        // Information display.
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label whiteTextLabel;
        private System.Windows.Forms.Label whiteCountLabel;
        private System.Windows.Forms.Label blackTextLabel;
        private System.Windows.Forms.Label blackCountLabel;
        private System.Windows.Forms.Label currentColorTextLabel;
        private System.Windows.Forms.Panel currentColorPanel;
        private System.Windows.Forms.ListView moveListView;
        private System.Windows.Forms.ColumnHeader moveNullColumn;
        private System.Windows.Forms.ColumnHeader moveNumberColumn;
        private System.Windows.Forms.ColumnHeader movePlayerColumn;
        private System.Windows.Forms.ColumnHeader movePositionColumn;

        // Status display.
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label statusLabel;
    }
}