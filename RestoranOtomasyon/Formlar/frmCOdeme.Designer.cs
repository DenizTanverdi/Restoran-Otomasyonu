namespace RestoranOtomasyon.Formlar
{
    partial class frmCOdeme
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
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.lblHsp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.BackColor = System.Drawing.Color.Red;
            this.btnVazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgeç.Location = new System.Drawing.Point(220, 172);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(151, 56);
            this.btnVazgeç.TabIndex = 4;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // lblHsp
            // 
            this.lblHsp.AutoSize = true;
            this.lblHsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHsp.Location = new System.Drawing.Point(171, 48);
            this.lblHsp.Name = "lblHsp";
            this.lblHsp.Size = new System.Drawing.Size(241, 85);
            this.lblHsp.TabIndex = 3;
            this.lblHsp.Text = "label1";
            // 
            // frmCOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 261);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.lblHsp);
            this.Name = "frmCOdeme";
            this.Text = "frmCOdeme";
            this.Load += new System.EventHandler(this.frmCOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.Label lblHsp;
    }
}