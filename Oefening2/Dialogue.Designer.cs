namespace Oefening2
{
    partial class formDialogue
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
            this.lblGetal = new System.Windows.Forms.Label();
            this.tbGeefGetal = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(97, 93);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(44, 20);
            this.lblGetal.TabIndex = 0;
            this.lblGetal.Text = "Getal";
            // 
            // tbGeefGetal
            // 
            this.tbGeefGetal.Location = new System.Drawing.Point(147, 90);
            this.tbGeefGetal.Name = "tbGeefGetal";
            this.tbGeefGetal.Size = new System.Drawing.Size(125, 27);
            this.tbGeefGetal.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(129, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 39);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // formDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 278);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbGeefGetal);
            this.Controls.Add(this.lblGetal);
            this.Name = "formDialogue";
            this.Text = "Dialogue";
            this.Load += new System.EventHandler(this.formDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGetal;
        private TextBox tbGeefGetal;
        private Button btnOK;
    }
}