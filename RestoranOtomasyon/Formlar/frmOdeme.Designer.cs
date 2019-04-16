namespace RestoranOtomasyon.Formlar
{
    partial class frmOdeme
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
            this.lblHsp = new System.Windows.Forms.Label();
            this.btnKpt = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHsp
            // 
            this.lblHsp.AutoSize = true;
            this.lblHsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHsp.Location = new System.Drawing.Point(140, 43);
            this.lblHsp.Name = "lblHsp";
            this.lblHsp.Size = new System.Drawing.Size(241, 85);
            this.lblHsp.TabIndex = 0;
            this.lblHsp.Text = "label1";
            // 
            // btnKpt
            // 
            this.btnKpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKpt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKpt.Location = new System.Drawing.Point(80, 161);
            this.btnKpt.Name = "btnKpt";
            this.btnKpt.Size = new System.Drawing.Size(161, 56);
            this.btnKpt.TabIndex = 1;
            this.btnKpt.Text = "Hesap Kapat";
            this.btnKpt.UseVisualStyleBackColor = false;
            this.btnKpt.Click += new System.EventHandler(this.btnKpt_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.BackColor = System.Drawing.Color.Red;
            this.btnVazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgeç.Location = new System.Drawing.Point(273, 161);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(151, 56);
            this.btnVazgeç.TabIndex = 2;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.btnKpt);
            this.Controls.Add(this.lblHsp);
            this.Name = "frmOdeme";
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHsp;
        private System.Windows.Forms.Button btnKpt;
        private System.Windows.Forms.Button btnVazgeç;
    }
}