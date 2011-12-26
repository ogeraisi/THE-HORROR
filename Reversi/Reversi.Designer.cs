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
            this.boardPanel = new System.Windows.Forms.Panel();
            this.cornerLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.playToolBar = new System.Windows.Forms.ToolBar();
            this.newGameToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.resignGameToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.playImageList = new System.Windows.Forms.ImageList(this.components);
            this.checkBox_alphaBeta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_lookupAheadDepth = new System.Windows.Forms.TextBox();
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
            this.gameMenuItem});
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
            this.resignGameToolBarButton});
            this.playToolBar.Divider = false;
            this.playToolBar.DropDownArrows = true;
            this.playToolBar.ImageList = this.playImageList;
            this.playToolBar.Location = new System.Drawing.Point(0, 0);
            this.playToolBar.Name = "playToolBar";
            this.playToolBar.ShowToolTips = true;
            this.playToolBar.Size = new System.Drawing.Size(472, 26);
            this.playToolBar.TabIndex = 1;
            this.playToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.playToolBar_ButtonClick);
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
            // playImageList
            // 
            this.playImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playImageList.ImageStream")));
            this.playImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.playImageList.Images.SetKeyName(0, "");
            this.playImageList.Images.SetKeyName(1, "");
            this.playImageList.Images.SetKeyName(2, "");
            this.playImageList.Images.SetKeyName(3, "");
            this.playImageList.Images.SetKeyName(4, "");
            this.playImageList.Images.SetKeyName(5, "");
            this.playImageList.Images.SetKeyName(6, "");
            // 
            // checkBox_alphaBeta
            // 
            this.checkBox_alphaBeta.AutoSize = true;
            this.checkBox_alphaBeta.Checked = true;
            this.checkBox_alphaBeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_alphaBeta.Location = new System.Drawing.Point(75, 0);
            this.checkBox_alphaBeta.Name = "checkBox_alphaBeta";
            this.checkBox_alphaBeta.Size = new System.Drawing.Size(153, 21);
            this.checkBox_alphaBeta.TabIndex = 5;
            this.checkBox_alphaBeta.Text = "Alpha-Beta Pruning";
            this.checkBox_alphaBeta.UseVisualStyleBackColor = true;
            this.checkBox_alphaBeta.CheckedChanged += new System.EventHandler(this.checkBox_alphaBeta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minimax Depth:";
            // 
            // textBox_lookupAheadDepth
            // 
            this.textBox_lookupAheadDepth.Location = new System.Drawing.Point(383, 3);
            this.textBox_lookupAheadDepth.Name = "textBox_lookupAheadDepth";
            this.textBox_lookupAheadDepth.Size = new System.Drawing.Size(77, 22);
            this.textBox_lookupAheadDepth.TabIndex = 7;
            this.textBox_lookupAheadDepth.Text = "6";
            this.textBox_lookupAheadDepth.TextChanged += new System.EventHandler(this.textBox_lookupAheadDepth_TextChanged);
            this.textBox_lookupAheadDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lookupAheadDepth_KeyPress);
            // 
            // ReversiForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.Controls.Add(this.textBox_lookupAheadDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_alphaBeta);
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

        // Tool bar.
        private System.Windows.Forms.ToolBar playToolBar;
        private System.Windows.Forms.ImageList playImageList;
        private System.Windows.Forms.ToolBarButton newGameToolBarButton;
        private System.Windows.Forms.ToolBarButton resignGameToolBarButton;

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
        private System.Windows.Forms.CheckBox checkBox_alphaBeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_lookupAheadDepth;
    }
}