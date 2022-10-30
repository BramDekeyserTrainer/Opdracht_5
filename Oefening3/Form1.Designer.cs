namespace Oefening3
{
    partial class formRechthoeken
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
            this.btnVoegRechthoekToe = new System.Windows.Forms.Button();
            this.btnVerwijderRechthoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoegRechthoekToe
            // 
            this.btnVoegRechthoekToe.Location = new System.Drawing.Point(0, 0);
            this.btnVoegRechthoekToe.Name = "btnVoegRechthoekToe";
            this.btnVoegRechthoekToe.Size = new System.Drawing.Size(508, 48);
            this.btnVoegRechthoekToe.TabIndex = 0;
            this.btnVoegRechthoekToe.Text = "Rechthoek toevoegen";
            this.btnVoegRechthoekToe.UseVisualStyleBackColor = true;
            this.btnVoegRechthoekToe.Click += new System.EventHandler(this.btnVoegRechthoekToe_Click);
            // 
            // btnVerwijderRechthoek
            // 
            this.btnVerwijderRechthoek.Location = new System.Drawing.Point(510, 0);
            this.btnVerwijderRechthoek.Name = "btnVerwijderRechthoek";
            this.btnVerwijderRechthoek.Size = new System.Drawing.Size(496, 48);
            this.btnVerwijderRechthoek.TabIndex = 1;
            this.btnVerwijderRechthoek.Text = "Rechthoek verwijderen";
            this.btnVerwijderRechthoek.UseVisualStyleBackColor = true;
            this.btnVerwijderRechthoek.Click += new System.EventHandler(this.btnVerwijderRechthoek_Click);
            // 
            // formRechthoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 479);
            this.Controls.Add(this.btnVerwijderRechthoek);
            this.Controls.Add(this.btnVoegRechthoekToe);
            this.IsMdiContainer = true;
            this.Name = "formRechthoeken";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formRechthoeken_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVoegRechthoekToe;
        private Button btnVerwijderRechthoek;
    }
}