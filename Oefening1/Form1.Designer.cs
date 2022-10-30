namespace Oefening1
{
    partial class formMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstripMenu = new System.Windows.Forms.MenuStrip();
            this.mstitemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemBGColour = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemBGRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemBGGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemBGBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mstitemLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSerpentTooth = new System.Windows.Forms.TextBox();
            this.mstripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripMenu
            // 
            this.mstripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemFile,
            this.mstitemFormat});
            this.mstripMenu.Location = new System.Drawing.Point(0, 0);
            this.mstripMenu.Name = "mstripMenu";
            this.mstripMenu.Size = new System.Drawing.Size(452, 28);
            this.mstripMenu.TabIndex = 0;
            this.mstripMenu.Text = "menuStrip1";
            // 
            // mstitemFile
            // 
            this.mstitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemExit});
            this.mstitemFile.Name = "mstitemFile";
            this.mstitemFile.Size = new System.Drawing.Size(46, 24);
            this.mstitemFile.Text = "File";
            // 
            // mstitemExit
            // 
            this.mstitemExit.Name = "mstitemExit";
            this.mstitemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mstitemExit.Size = new System.Drawing.Size(224, 26);
            this.mstitemExit.Text = "Exit";
            this.mstitemExit.Click += new System.EventHandler(this.mstitemExit_Click);
            // 
            // mstitemFormat
            // 
            this.mstitemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemColor,
            this.mstitemBGColour,
            this.mstitemFont});
            this.mstitemFormat.Name = "mstitemFormat";
            this.mstitemFormat.Size = new System.Drawing.Size(70, 24);
            this.mstitemFormat.Text = "Format";
            // 
            // mstitemColor
            // 
            this.mstitemColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemRed,
            this.mstitemGreen,
            this.mstitemBlue});
            this.mstitemColor.Name = "mstitemColor";
            this.mstitemColor.Size = new System.Drawing.Size(209, 26);
            this.mstitemColor.Text = "Color";
            // 
            // mstitemRed
            // 
            this.mstitemRed.Name = "mstitemRed";
            this.mstitemRed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mstitemRed.Size = new System.Drawing.Size(183, 26);
            this.mstitemRed.Text = "Red";
            this.mstitemRed.Click += new System.EventHandler(this.mstitemRed_Click);
            // 
            // mstitemGreen
            // 
            this.mstitemGreen.Name = "mstitemGreen";
            this.mstitemGreen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mstitemGreen.Size = new System.Drawing.Size(183, 26);
            this.mstitemGreen.Text = "Green";
            this.mstitemGreen.Click += new System.EventHandler(this.mstitemGreen_Click);
            // 
            // mstitemBlue
            // 
            this.mstitemBlue.Name = "mstitemBlue";
            this.mstitemBlue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mstitemBlue.Size = new System.Drawing.Size(183, 26);
            this.mstitemBlue.Text = "Blue";
            this.mstitemBlue.Click += new System.EventHandler(this.mstitemBlue_Click);
            // 
            // mstitemBGColour
            // 
            this.mstitemBGColour.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemBGRed,
            this.mstitemBGGreen,
            this.mstitemBGBlue});
            this.mstitemBGColour.Name = "mstitemBGColour";
            this.mstitemBGColour.Size = new System.Drawing.Size(209, 26);
            this.mstitemBGColour.Text = "Background color";
            // 
            // mstitemBGRed
            // 
            this.mstitemBGRed.Name = "mstitemBGRed";
            this.mstitemBGRed.Size = new System.Drawing.Size(131, 26);
            this.mstitemBGRed.Text = "Red";
            this.mstitemBGRed.Click += new System.EventHandler(this.mstitemBGRed_Click);
            // 
            // mstitemBGGreen
            // 
            this.mstitemBGGreen.Name = "mstitemBGGreen";
            this.mstitemBGGreen.Size = new System.Drawing.Size(131, 26);
            this.mstitemBGGreen.Text = "Green";
            this.mstitemBGGreen.Click += new System.EventHandler(this.mstitemBGGreen_Click);
            // 
            // mstitemBGBlue
            // 
            this.mstitemBGBlue.Name = "mstitemBGBlue";
            this.mstitemBGBlue.Size = new System.Drawing.Size(131, 26);
            this.mstitemBGBlue.Text = "Blue";
            this.mstitemBGBlue.Click += new System.EventHandler(this.mstitemBGBlue_Click);
            // 
            // mstitemFont
            // 
            this.mstitemFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstitemSmall,
            this.mstitemNormal,
            this.mstitemLarge});
            this.mstitemFont.Name = "mstitemFont";
            this.mstitemFont.Size = new System.Drawing.Size(209, 26);
            this.mstitemFont.Text = "Font";
            this.mstitemFont.Click += new System.EventHandler(this.mstitemFont_Click);
            // 
            // mstitemSmall
            // 
            this.mstitemSmall.Name = "mstitemSmall";
            this.mstitemSmall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mstitemSmall.Size = new System.Drawing.Size(195, 26);
            this.mstitemSmall.Text = "Small";
            this.mstitemSmall.Click += new System.EventHandler(this.mstitemSmall_Click);
            // 
            // mstitemNormal
            // 
            this.mstitemNormal.Name = "mstitemNormal";
            this.mstitemNormal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mstitemNormal.Size = new System.Drawing.Size(195, 26);
            this.mstitemNormal.Text = "Normal";
            this.mstitemNormal.Click += new System.EventHandler(this.mstitemNormal_Click);
            // 
            // mstitemLarge
            // 
            this.mstitemLarge.Name = "mstitemLarge";
            this.mstitemLarge.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mstitemLarge.Size = new System.Drawing.Size(195, 26);
            this.mstitemLarge.Text = "Large";
            this.mstitemLarge.Click += new System.EventHandler(this.mstitemLarge_Click);
            // 
            // tbSerpentTooth
            // 
            this.tbSerpentTooth.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSerpentTooth.Location = new System.Drawing.Point(0, 28);
            this.tbSerpentTooth.Multiline = true;
            this.tbSerpentTooth.Name = "tbSerpentTooth";
            this.tbSerpentTooth.Size = new System.Drawing.Size(452, 272);
            this.tbSerpentTooth.TabIndex = 1;
            this.tbSerpentTooth.Text = "How sharper than a serpent\'s tooth it is to have a buggy program!";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 300);
            this.Controls.Add(this.tbSerpentTooth);
            this.Controls.Add(this.mstripMenu);
            this.MainMenuStrip = this.mstripMenu;
            this.Name = "formMenu";
            this.Text = "Menu";
            this.mstripMenu.ResumeLayout(false);
            this.mstripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mstripMenu;
        private ToolStripMenuItem mstitemFile;
        private ToolStripMenuItem mstitemExit;
        private ToolStripMenuItem mstitemFormat;
        private ToolStripMenuItem mstitemColor;
        private ToolStripMenuItem mstitemRed;
        private ToolStripMenuItem mstitemGreen;
        private ToolStripMenuItem mstitemBlue;
        private ToolStripMenuItem mstitemBGColour;
        private ToolStripMenuItem mstitemBGRed;
        private ToolStripMenuItem mstitemBGGreen;
        private ToolStripMenuItem mstitemBGBlue;
        private ToolStripMenuItem mstitemFont;
        private ToolStripMenuItem mstitemSmall;
        private ToolStripMenuItem mstitemNormal;
        private ToolStripMenuItem mstitemLarge;
        private TextBox tbSerpentTooth;
    }
}