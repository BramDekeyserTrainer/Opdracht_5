namespace Oefening3
{
    partial class ColorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorDialog));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupdwnAlpha = new System.Windows.Forms.NumericUpDown();
            this.nupdwnBlauw = new System.Windows.Forms.NumericUpDown();
            this.nupdwnGroen = new System.Windows.Forms.NumericUpDown();
            this.nupdwnRood = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnBlauw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnRood)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nupdwnAlpha
            // 
            resources.ApplyResources(this.nupdwnAlpha, "nupdwnAlpha");
            this.nupdwnAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdwnAlpha.Name = "nupdwnAlpha";
            this.nupdwnAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nupdwnBlauw
            // 
            resources.ApplyResources(this.nupdwnBlauw, "nupdwnBlauw");
            this.nupdwnBlauw.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdwnBlauw.Name = "nupdwnBlauw";
            // 
            // nupdwnGroen
            // 
            resources.ApplyResources(this.nupdwnGroen, "nupdwnGroen");
            this.nupdwnGroen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdwnGroen.Name = "nupdwnGroen";
            // 
            // nupdwnRood
            // 
            resources.ApplyResources(this.nupdwnRood, "nupdwnRood");
            this.nupdwnRood.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdwnRood.Name = "nupdwnRood";
            this.nupdwnRood.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // ColorDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupdwnAlpha);
            this.Controls.Add(this.nupdwnBlauw);
            this.Controls.Add(this.nupdwnGroen);
            this.Controls.Add(this.nupdwnRood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ColorDialog";
            this.Load += new System.EventHandler(this.ColorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnBlauw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnRood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nupdwnAlpha;
        private NumericUpDown nupdwnBlauw;
        private NumericUpDown nupdwnGroen;
        public NumericUpDown nupdwnRood;
    }
}