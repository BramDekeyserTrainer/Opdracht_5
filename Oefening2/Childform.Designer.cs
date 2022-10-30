namespace Oefening2
{
    partial class formGemiddelde
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
            this.lbxGetallenlijst = new System.Windows.Forms.ListBox();
            this.btnNieuwGetal = new System.Windows.Forms.Button();
            this.tbNieuwGetal = new System.Windows.Forms.TextBox();
            this.lblGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxGetallenlijst
            // 
            this.lbxGetallenlijst.FormattingEnabled = true;
            this.lbxGetallenlijst.ItemHeight = 20;
            this.lbxGetallenlijst.Location = new System.Drawing.Point(119, 33);
            this.lbxGetallenlijst.Name = "lbxGetallenlijst";
            this.lbxGetallenlijst.Size = new System.Drawing.Size(388, 264);
            this.lbxGetallenlijst.TabIndex = 1;
            // 
            // btnNieuwGetal
            // 
            this.btnNieuwGetal.Location = new System.Drawing.Point(119, 341);
            this.btnNieuwGetal.Name = "btnNieuwGetal";
            this.btnNieuwGetal.Size = new System.Drawing.Size(154, 58);
            this.btnNieuwGetal.TabIndex = 2;
            this.btnNieuwGetal.Text = "Nieuw getal";
            this.btnNieuwGetal.UseVisualStyleBackColor = true;
            this.btnNieuwGetal.Click += new System.EventHandler(this.btnNieuwGetal_Click);
            // 
            // tbNieuwGetal
            // 
            this.tbNieuwGetal.Location = new System.Drawing.Point(294, 357);
            this.tbNieuwGetal.Name = "tbNieuwGetal";
            this.tbNieuwGetal.ReadOnly = true;
            this.tbNieuwGetal.Size = new System.Drawing.Size(213, 27);
            this.tbNieuwGetal.TabIndex = 3;
            this.tbNieuwGetal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(294, 334);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(44, 20);
            this.lblGetal.TabIndex = 4;
            this.lblGetal.Text = "Getal";
            // 
            // formGemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.tbNieuwGetal);
            this.Controls.Add(this.btnNieuwGetal);
            this.Controls.Add(this.lbxGetallenlijst);
            this.Name = "formGemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxGetallenlijst;
        private Button btnNieuwGetal;
        private TextBox tbNieuwGetal;
        private Label lblGetal;
    }
}