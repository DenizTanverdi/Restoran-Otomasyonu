namespace RestoranOtomasyon.Formlar
{
    partial class SiparisGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisGoruntule));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(671, 224);
            this.dataGridView.TabIndex = 0;
            // 
            // btnKaldir
            // 
            this.btnKaldir.BackColor = System.Drawing.Color.Lime;
            this.btnKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaldir.Location = new System.Drawing.Point(745, 80);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(112, 40);
            this.btnKaldir.TabIndex = 1;
            this.btnKaldir.Text = "Sipariş Onayı";
            this.btnKaldir.UseVisualStyleBackColor = false;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.Cıkış;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(33, 303);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(78, 52);
            this.btnexit.TabIndex = 3;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.geriDön;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(136, 303);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 52);
            this.btngeri.TabIndex = 2;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // SiparisGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 367);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnKaldir);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisGoruntule";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.SiparisGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btngeri;
    }
}