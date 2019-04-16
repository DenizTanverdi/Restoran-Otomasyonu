namespace RestoranOtomasyon.Formlar
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCstr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(351, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "KÖFTECİ ABİ";
            // 
            // flowLayoutPanel1
            // 
          //  this.flowLayoutPanel1.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.ArkaPlan2;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(182, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 595);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCstr
            // 
            this.btnCstr.BackColor = System.Drawing.Color.Lime;
            this.btnCstr.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnCstr.Location = new System.Drawing.Point(1000, 24);
            this.btnCstr.Name = "btnCstr";
            this.btnCstr.Size = new System.Drawing.Size(164, 74);
            this.btnCstr.TabIndex = 3;
            this.btnCstr.UseVisualStyleBackColor = false;
            this.btnCstr.Click += new System.EventHandler(this.btnCstr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(851, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "SİPARİŞLER";
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.Cıkış;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(12, 663);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(78, 52);
            this.btnexit.TabIndex = 6;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.geriDön;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(101, 663);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 52);
            this.btngeri.TabIndex = 5;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmTable
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
           // this.BackgroundImageStore = global::RestoranOtomasyon.Properties.Resources.ArkaPlan2;
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCstr);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTable";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCstr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btngeri;
    }
}