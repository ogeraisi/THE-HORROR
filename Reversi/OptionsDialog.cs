using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Reversi
{
    /// <summary>
    /// Summary description for OptionsDialog.
    /// </summary>
    public class OptionsDialog : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage displayTabPage;
        private System.Windows.Forms.CheckBox showValidMovesCheckBox;
        private System.Windows.Forms.CheckBox previewMovesCheckBox;
        private System.Windows.Forms.CheckBox animateMovesCheckBox;
        private System.Windows.Forms.Label boardColorLabel;
        private System.Windows.Forms.Panel boardColorPanel;
        private System.Windows.Forms.Button boardColorButton;
        private System.Windows.Forms.Label validColorLabel;
        private System.Windows.Forms.Panel validColorPanel;
        private System.Windows.Forms.Button validColorButton;
        private System.Windows.Forms.Label activeColorLabel;
        private System.Windows.Forms.Panel activeColorPanel;
        private System.Windows.Forms.Button activeColorButton;
        private System.Windows.Forms.Label moveIndicatorColorLabel;
        private System.Windows.Forms.Panel moveIndicatorColorPanel;
        private System.Windows.Forms.Button moveIndicatorColorButton;
        private System.Windows.Forms.Label firstMoveLabel;
        private System.Windows.Forms.Panel firstMovePanel;
        private System.Windows.Forms.RadioButton firstMoveBlackRadioButton;
        private System.Windows.Forms.RadioButton firstMoveWhiteRadioButton;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.Panel blackPlayerPanel;
        private System.Windows.Forms.RadioButton blackPlayerComputerRadioButton;
        private System.Windows.Forms.RadioButton blackPlayerUserRadioButton;
        private System.Windows.Forms.Panel whitePlayerPanel;
        private System.Windows.Forms.RadioButton whitePlayerComputerRadioButton;
        private System.Windows.Forms.RadioButton whitePlayerUserRadioButton;
        private System.Windows.Forms.Label blackPlayerLabel;
        private System.Windows.Forms.Label whitePlayerLabel;
        private System.Windows.Forms.Button restoreDefaultsButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.Container components = null;

        // The game options.
        public Options Options;

        // An array to store custom colors added by the user.
        private static int[] customColors = new int[] { };

        public OptionsDialog(Options options)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Create a copy of the given game options.
            this.Options = new Options(options);

            // Set the form controls based on those options.
            this.MapOptionsToControls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.displayTabPage = new System.Windows.Forms.TabPage();
            this.previewMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.moveIndicatorColorButton = new System.Windows.Forms.Button();
            this.moveIndicatorColorPanel = new System.Windows.Forms.Panel();
            this.moveIndicatorColorLabel = new System.Windows.Forms.Label();
            this.animateMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.validColorButton = new System.Windows.Forms.Button();
            this.validColorPanel = new System.Windows.Forms.Panel();
            this.validColorLabel = new System.Windows.Forms.Label();
            this.activeColorButton = new System.Windows.Forms.Button();
            this.activeColorPanel = new System.Windows.Forms.Panel();
            this.activeColorLabel = new System.Windows.Forms.Label();
            this.boardColorButton = new System.Windows.Forms.Button();
            this.boardColorPanel = new System.Windows.Forms.Panel();
            this.boardColorLabel = new System.Windows.Forms.Label();
            this.showValidMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.whitePlayerPanel = new System.Windows.Forms.Panel();
            this.whitePlayerUserRadioButton = new System.Windows.Forms.RadioButton();
            this.whitePlayerComputerRadioButton = new System.Windows.Forms.RadioButton();
            this.whitePlayerLabel = new System.Windows.Forms.Label();
            this.blackPlayerPanel = new System.Windows.Forms.Panel();
            this.blackPlayerUserRadioButton = new System.Windows.Forms.RadioButton();
            this.blackPlayerComputerRadioButton = new System.Windows.Forms.RadioButton();
            this.blackPlayerLabel = new System.Windows.Forms.Label();
            this.firstMovePanel = new System.Windows.Forms.Panel();
            this.firstMoveWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.firstMoveBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.firstMoveLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.restoreDefaultsButton = new System.Windows.Forms.Button();
            this.optionsTabControl.SuspendLayout();
            this.displayTabPage.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            this.whitePlayerPanel.SuspendLayout();
            this.blackPlayerPanel.SuspendLayout();
            this.firstMovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.displayTabPage);
            this.optionsTabControl.Controls.Add(this.playersTabPage);
            this.optionsTabControl.Location = new System.Drawing.Point(10, 18);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(345, 250);
            this.optionsTabControl.TabIndex = 0;
            // 
            // displayTabPage
            // 
            this.displayTabPage.Controls.Add(this.previewMovesCheckBox);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorButton);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorPanel);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorLabel);
            this.displayTabPage.Controls.Add(this.animateMovesCheckBox);
            this.displayTabPage.Controls.Add(this.validColorButton);
            this.displayTabPage.Controls.Add(this.validColorPanel);
            this.displayTabPage.Controls.Add(this.validColorLabel);
            this.displayTabPage.Controls.Add(this.activeColorButton);
            this.displayTabPage.Controls.Add(this.activeColorPanel);
            this.displayTabPage.Controls.Add(this.activeColorLabel);
            this.displayTabPage.Controls.Add(this.boardColorButton);
            this.displayTabPage.Controls.Add(this.boardColorPanel);
            this.displayTabPage.Controls.Add(this.boardColorLabel);
            this.displayTabPage.Controls.Add(this.showValidMovesCheckBox);
            this.displayTabPage.Location = new System.Drawing.Point(4, 25);
            this.displayTabPage.Name = "displayTabPage";
            this.displayTabPage.Size = new System.Drawing.Size(337, 221);
            this.displayTabPage.TabIndex = 0;
            this.displayTabPage.Text = "Display";
            // 
            // previewMovesCheckBox
            // 
            this.previewMovesCheckBox.Location = new System.Drawing.Point(173, 12);
            this.previewMovesCheckBox.Name = "previewMovesCheckBox";
            this.previewMovesCheckBox.Size = new System.Drawing.Size(125, 27);
            this.previewMovesCheckBox.TabIndex = 1;
            this.previewMovesCheckBox.Text = "Preview moves";
            // 
            // moveIndicatorColorButton
            // 
            this.moveIndicatorColorButton.Location = new System.Drawing.Point(210, 181);
            this.moveIndicatorColorButton.Name = "moveIndicatorColorButton";
            this.moveIndicatorColorButton.Size = new System.Drawing.Size(90, 27);
            this.moveIndicatorColorButton.TabIndex = 14;
            this.moveIndicatorColorButton.Text = "Select...";
            this.moveIndicatorColorButton.Click += new System.EventHandler(this.moveIndicatorColorButton_Click);
            // 
            // moveIndicatorColorPanel
            // 
            this.moveIndicatorColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveIndicatorColorPanel.Location = new System.Drawing.Point(172, 185);
            this.moveIndicatorColorPanel.Name = "moveIndicatorColorPanel";
            this.moveIndicatorColorPanel.Size = new System.Drawing.Size(19, 18);
            this.moveIndicatorColorPanel.TabIndex = 13;
            // 
            // moveIndicatorColorLabel
            // 
            this.moveIndicatorColorLabel.AutoSize = true;
            this.moveIndicatorColorLabel.Location = new System.Drawing.Point(32, 187);
            this.moveIndicatorColorLabel.Name = "moveIndicatorColorLabel";
            this.moveIndicatorColorLabel.Size = new System.Drawing.Size(139, 17);
            this.moveIndicatorColorLabel.TabIndex = 12;
            this.moveIndicatorColorLabel.Text = "Move indicator color:";
            // 
            // animateMovesCheckBox
            // 
            this.animateMovesCheckBox.Location = new System.Drawing.Point(19, 39);
            this.animateMovesCheckBox.Name = "animateMovesCheckBox";
            this.animateMovesCheckBox.Size = new System.Drawing.Size(125, 28);
            this.animateMovesCheckBox.TabIndex = 2;
            this.animateMovesCheckBox.Text = "Animate moves";
            // 
            // validColorButton
            // 
            this.validColorButton.Location = new System.Drawing.Point(210, 107);
            this.validColorButton.Name = "validColorButton";
            this.validColorButton.Size = new System.Drawing.Size(90, 27);
            this.validColorButton.TabIndex = 8;
            this.validColorButton.Text = "Select...";
            this.validColorButton.Click += new System.EventHandler(this.validColorButton_Click);
            // 
            // validColorPanel
            // 
            this.validColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validColorPanel.Location = new System.Drawing.Point(172, 111);
            this.validColorPanel.Name = "validColorPanel";
            this.validColorPanel.Size = new System.Drawing.Size(19, 18);
            this.validColorPanel.TabIndex = 7;
            // 
            // validColorLabel
            // 
            this.validColorLabel.AutoSize = true;
            this.validColorLabel.Location = new System.Drawing.Point(54, 113);
            this.validColorLabel.Name = "validColorLabel";
            this.validColorLabel.Size = new System.Drawing.Size(116, 17);
            this.validColorLabel.TabIndex = 6;
            this.validColorLabel.Text = "Valid move color:";
            // 
            // activeColorButton
            // 
            this.activeColorButton.Location = new System.Drawing.Point(210, 144);
            this.activeColorButton.Name = "activeColorButton";
            this.activeColorButton.Size = new System.Drawing.Size(90, 27);
            this.activeColorButton.TabIndex = 11;
            this.activeColorButton.Text = "Select...";
            this.activeColorButton.Click += new System.EventHandler(this.activeColorButton_Click);
            // 
            // activeColorPanel
            // 
            this.activeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeColorPanel.Location = new System.Drawing.Point(172, 148);
            this.activeColorPanel.Name = "activeColorPanel";
            this.activeColorPanel.Size = new System.Drawing.Size(19, 18);
            this.activeColorPanel.TabIndex = 10;
            // 
            // activeColorLabel
            // 
            this.activeColorLabel.AutoSize = true;
            this.activeColorLabel.Location = new System.Drawing.Point(38, 150);
            this.activeColorLabel.Name = "activeColorLabel";
            this.activeColorLabel.Size = new System.Drawing.Size(133, 17);
            this.activeColorLabel.TabIndex = 9;
            this.activeColorLabel.Text = "Active square color:";
            // 
            // boardColorButton
            // 
            this.boardColorButton.Location = new System.Drawing.Point(210, 70);
            this.boardColorButton.Name = "boardColorButton";
            this.boardColorButton.Size = new System.Drawing.Size(90, 27);
            this.boardColorButton.TabIndex = 5;
            this.boardColorButton.Text = "Select...";
            this.boardColorButton.Click += new System.EventHandler(this.boardColorButton_Click);
            // 
            // boardColorPanel
            // 
            this.boardColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardColorPanel.Location = new System.Drawing.Point(172, 74);
            this.boardColorPanel.Name = "boardColorPanel";
            this.boardColorPanel.Size = new System.Drawing.Size(19, 18);
            this.boardColorPanel.TabIndex = 4;
            // 
            // boardColorLabel
            // 
            this.boardColorLabel.AutoSize = true;
            this.boardColorLabel.Location = new System.Drawing.Point(85, 76);
            this.boardColorLabel.Name = "boardColorLabel";
            this.boardColorLabel.Size = new System.Drawing.Size(85, 17);
            this.boardColorLabel.TabIndex = 3;
            this.boardColorLabel.Text = "Board color:";
            // 
            // showValidMovesCheckBox
            // 
            this.showValidMovesCheckBox.Location = new System.Drawing.Point(19, 12);
            this.showValidMovesCheckBox.Name = "showValidMovesCheckBox";
            this.showValidMovesCheckBox.Size = new System.Drawing.Size(144, 27);
            this.showValidMovesCheckBox.TabIndex = 0;
            this.showValidMovesCheckBox.Text = "Show valid moves";
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.whitePlayerPanel);
            this.playersTabPage.Controls.Add(this.blackPlayerPanel);
            this.playersTabPage.Controls.Add(this.firstMovePanel);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Size = new System.Drawing.Size(337, 221);
            this.playersTabPage.TabIndex = 1;
            this.playersTabPage.Text = "Players";
            // 
            // whitePlayerPanel
            // 
            this.whitePlayerPanel.Controls.Add(this.whitePlayerUserRadioButton);
            this.whitePlayerPanel.Controls.Add(this.whitePlayerComputerRadioButton);
            this.whitePlayerPanel.Controls.Add(this.whitePlayerLabel);
            this.whitePlayerPanel.Location = new System.Drawing.Point(48, 147);
            this.whitePlayerPanel.Name = "whitePlayerPanel";
            this.whitePlayerPanel.Size = new System.Drawing.Size(240, 64);
            this.whitePlayerPanel.TabIndex = 5;
            // 
            // whitePlayerUserRadioButton
            // 
            this.whitePlayerUserRadioButton.Location = new System.Drawing.Point(106, 37);
            this.whitePlayerUserRadioButton.Name = "whitePlayerUserRadioButton";
            this.whitePlayerUserRadioButton.Size = new System.Drawing.Size(124, 28);
            this.whitePlayerUserRadioButton.TabIndex = 1;
            this.whitePlayerUserRadioButton.Text = "User";
            // 
            // whitePlayerComputerRadioButton
            // 
            this.whitePlayerComputerRadioButton.Location = new System.Drawing.Point(106, 9);
            this.whitePlayerComputerRadioButton.Name = "whitePlayerComputerRadioButton";
            this.whitePlayerComputerRadioButton.Size = new System.Drawing.Size(124, 28);
            this.whitePlayerComputerRadioButton.TabIndex = 0;
            this.whitePlayerComputerRadioButton.Text = "Computer";
            // 
            // whitePlayerLabel
            // 
            this.whitePlayerLabel.AutoSize = true;
            this.whitePlayerLabel.Location = new System.Drawing.Point(10, 14);
            this.whitePlayerLabel.Name = "whitePlayerLabel";
            this.whitePlayerLabel.Size = new System.Drawing.Size(91, 17);
            this.whitePlayerLabel.TabIndex = 4;
            this.whitePlayerLabel.Text = "White player:";
            // 
            // blackPlayerPanel
            // 
            this.blackPlayerPanel.Controls.Add(this.blackPlayerUserRadioButton);
            this.blackPlayerPanel.Controls.Add(this.blackPlayerComputerRadioButton);
            this.blackPlayerPanel.Controls.Add(this.blackPlayerLabel);
            this.blackPlayerPanel.Location = new System.Drawing.Point(48, 77);
            this.blackPlayerPanel.Name = "blackPlayerPanel";
            this.blackPlayerPanel.Size = new System.Drawing.Size(240, 65);
            this.blackPlayerPanel.TabIndex = 3;
            // 
            // blackPlayerUserRadioButton
            // 
            this.blackPlayerUserRadioButton.Location = new System.Drawing.Point(106, 37);
            this.blackPlayerUserRadioButton.Name = "blackPlayerUserRadioButton";
            this.blackPlayerUserRadioButton.Size = new System.Drawing.Size(124, 28);
            this.blackPlayerUserRadioButton.TabIndex = 1;
            this.blackPlayerUserRadioButton.Text = "User";
            // 
            // blackPlayerComputerRadioButton
            // 
            this.blackPlayerComputerRadioButton.Location = new System.Drawing.Point(106, 9);
            this.blackPlayerComputerRadioButton.Name = "blackPlayerComputerRadioButton";
            this.blackPlayerComputerRadioButton.Size = new System.Drawing.Size(124, 28);
            this.blackPlayerComputerRadioButton.TabIndex = 0;
            this.blackPlayerComputerRadioButton.Text = "Computer";
            // 
            // blackPlayerLabel
            // 
            this.blackPlayerLabel.AutoSize = true;
            this.blackPlayerLabel.Location = new System.Drawing.Point(11, 14);
            this.blackPlayerLabel.Name = "blackPlayerLabel";
            this.blackPlayerLabel.Size = new System.Drawing.Size(89, 17);
            this.blackPlayerLabel.TabIndex = 2;
            this.blackPlayerLabel.Text = "Black player:";
            // 
            // firstMovePanel
            // 
            this.firstMovePanel.Controls.Add(this.firstMoveWhiteRadioButton);
            this.firstMovePanel.Controls.Add(this.firstMoveBlackRadioButton);
            this.firstMovePanel.Controls.Add(this.firstMoveLabel);
            this.firstMovePanel.Location = new System.Drawing.Point(48, 8);
            this.firstMovePanel.Name = "firstMovePanel";
            this.firstMovePanel.Size = new System.Drawing.Size(240, 65);
            this.firstMovePanel.TabIndex = 1;
            // 
            // firstMoveWhiteRadioButton
            // 
            this.firstMoveWhiteRadioButton.Location = new System.Drawing.Point(106, 37);
            this.firstMoveWhiteRadioButton.Name = "firstMoveWhiteRadioButton";
            this.firstMoveWhiteRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstMoveWhiteRadioButton.TabIndex = 1;
            this.firstMoveWhiteRadioButton.Text = "White";
            // 
            // firstMoveBlackRadioButton
            // 
            this.firstMoveBlackRadioButton.Location = new System.Drawing.Point(106, 9);
            this.firstMoveBlackRadioButton.Name = "firstMoveBlackRadioButton";
            this.firstMoveBlackRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstMoveBlackRadioButton.TabIndex = 0;
            this.firstMoveBlackRadioButton.Text = "Black";
            // 
            // firstMoveLabel
            // 
            this.firstMoveLabel.AutoSize = true;
            this.firstMoveLabel.Location = new System.Drawing.Point(22, 14);
            this.firstMoveLabel.Name = "firstMoveLabel";
            this.firstMoveLabel.Size = new System.Drawing.Size(77, 17);
            this.firstMoveLabel.TabIndex = 0;
            this.firstMoveLabel.Text = "First move:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(163, 277);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 26);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(265, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 26);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            // 
            // restoreDefaultsButton
            // 
            this.restoreDefaultsButton.Location = new System.Drawing.Point(10, 277);
            this.restoreDefaultsButton.Name = "restoreDefaultsButton";
            this.restoreDefaultsButton.Size = new System.Drawing.Size(115, 26);
            this.restoreDefaultsButton.TabIndex = 3;
            this.restoreDefaultsButton.Text = "Restore Defaults";
            this.restoreDefaultsButton.Click += new System.EventHandler(this.restoreDefaultsButton_Click);
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(361, 307);
            this.ControlBox = false;
            this.Controls.Add(this.restoreDefaultsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.optionsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.optionsTabControl.ResumeLayout(false);
            this.displayTabPage.ResumeLayout(false);
            this.displayTabPage.PerformLayout();
            this.playersTabPage.ResumeLayout(false);
            this.whitePlayerPanel.ResumeLayout(false);
            this.whitePlayerPanel.PerformLayout();
            this.blackPlayerPanel.ResumeLayout(false);
            this.blackPlayerPanel.PerformLayout();
            this.firstMovePanel.ResumeLayout(false);
            this.firstMovePanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        //
        // Sets the form controls based on the current game options.
        //
        private void MapOptionsToControls()
        {
            this.showValidMovesCheckBox.Checked = this.Options.ShowValidMoves;
            this.previewMovesCheckBox.Checked = this.Options.PreviewMoves;
            this.animateMovesCheckBox.Checked = this.Options.AnimateMoves;
            this.boardColorPanel.BackColor = this.Options.BoardColor;
            this.validColorPanel.BackColor = this.Options.ValidMoveColor;
            this.activeColorPanel.BackColor = this.Options.ActiveSquareColor;
            this.moveIndicatorColorPanel.BackColor = this.Options.MoveIndicatorColor;

            if (this.Options.FirstMove == Board.Black)
                this.firstMoveBlackRadioButton.Checked = true;
            else
                this.firstMoveWhiteRadioButton.Checked = true;
            this.blackPlayerComputerRadioButton.Checked = this.Options.ComputerPlaysBlack;
            this.blackPlayerUserRadioButton.Checked = !this.Options.ComputerPlaysBlack;
            this.whitePlayerComputerRadioButton.Checked = this.Options.ComputerPlaysWhite;
            this.whitePlayerUserRadioButton.Checked = !this.Options.ComputerPlaysWhite;

            this.Refresh();
        }

        //
        // Sets the game options based on the current state of the form
        // controls.
        //
        private void MapControlsToOptions()
        {
            this.Options.ShowValidMoves = this.showValidMovesCheckBox.Checked;
            this.Options.PreviewMoves = this.previewMovesCheckBox.Checked;
            this.Options.AnimateMoves = this.animateMovesCheckBox.Checked;
            this.Options.BoardColor = this.boardColorPanel.BackColor;
            this.Options.ValidMoveColor = this.validColorPanel.BackColor;
            this.Options.ActiveSquareColor = this.activeColorPanel.BackColor;
            this.Options.MoveIndicatorColor = this.moveIndicatorColorPanel.BackColor;

            this.Options.FirstMove = this.firstMoveBlackRadioButton.Checked ? Board.Black : Board.White;
            this.Options.ComputerPlaysBlack = this.blackPlayerComputerRadioButton.Checked;
            this.Options.ComputerPlaysWhite = this.whitePlayerComputerRadioButton.Checked;
        }

        // ===================================================================
        // Event handlers for the color select buttons.
        // ===================================================================

        private void boardColorButton_Click(object sender, System.EventArgs e)
        {
            // Open a color dialog.
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.boardColorPanel.BackColor;
            dlg.CustomColors = OptionsDialog.customColors;

            // Set the board color based on that selection.
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.boardColorPanel.BackColor = dlg.Color;
                this.boardColorPanel.Refresh();
                OptionsDialog.customColors = dlg.CustomColors;
            }
        }

        private void validColorButton_Click(object sender, System.EventArgs e)
        {
            // Open a color dialog.
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.validColorPanel.BackColor;
            dlg.CustomColors = OptionsDialog.customColors;

            // Set the valid move color based on that selection.
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.validColorPanel.BackColor = dlg.Color;
                this.validColorPanel.Refresh();
                OptionsDialog.customColors = dlg.CustomColors;
            }
        }

        private void activeColorButton_Click(object sender, System.EventArgs e)
        {
            // Open a color dialog.
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.activeColorPanel.BackColor;
            dlg.CustomColors = OptionsDialog.customColors;

            // Set the active square color based on that selection.
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.activeColorPanel.BackColor = dlg.Color;
                this.activeColorPanel.Refresh();
                OptionsDialog.customColors = dlg.CustomColors;
            }
        }

        private void moveIndicatorColorButton_Click(object sender, System.EventArgs e)
        {
            // Open a color dialog.
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.moveIndicatorColorPanel.BackColor;
            dlg.CustomColors = OptionsDialog.customColors;

            // Set the move indicator color based on that selection.
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.moveIndicatorColorPanel.BackColor = dlg.Color;
                this.moveIndicatorColorPanel.Refresh();
                OptionsDialog.customColors = dlg.CustomColors;
            }
        }

        // ===================================================================
        // Event handlers for the form buttons.
        // ===================================================================

        private void restoreDefaultsButton_Click(object sender, System.EventArgs e)
        {
            // Reset the game options to their defaults.
            this.Options.RestoreDefaults();

            // Update the form controls.
            this.MapOptionsToControls();
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            // Set game options based on the form control values.
            this.MapControlsToOptions();
        }
    }
}
