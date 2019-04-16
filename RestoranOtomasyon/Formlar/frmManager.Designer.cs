namespace RestoranOtomasyon.Formlar
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxCustomerMaas = new System.Windows.Forms.TextBox();
            this.txtBxCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtBxUserPassword = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.txtBxCustomerName = new System.Windows.Forms.TextBox();
            this.btnAddP = new System.Windows.Forms.Button();
            this.dataGridEmploye = new System.Windows.Forms.DataGridView();
            this.btnRemoveP = new System.Windows.Forms.Button();
            this.btnGunP = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGunU = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddU = new System.Windows.Forms.Button();
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.txtBxProdcutPi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comBxCategoryName = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGunM = new System.Windows.Forms.Button();
            this.btnRemoveM = new System.Windows.Forms.Button();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.btnAddM = new System.Windows.Forms.Button();
            this.txtBxTableName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmBxGarder = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmBxGarder);
            this.tabPage2.Controls.Add(this.btnGunP);
            this.tabPage2.Controls.Add(this.btnRemoveP);
            this.tabPage2.Controls.Add(this.dataGridEmploye);
            this.tabPage2.Controls.Add(this.btnAddP);
            this.tabPage2.Controls.Add(this.txtBxCustomerName);
            this.tabPage2.Controls.Add(this.txtBxUserName);
            this.tabPage2.Controls.Add(this.txtBxUserPassword);
            this.tabPage2.Controls.Add(this.txtBxCustomerPhone);
            this.tabPage2.Controls.Add(this.txtBxCustomerMaas);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Ekle-Sil-Düzelt";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // txtBxCustomerMaas
            // 
            this.txtBxCustomerMaas.Location = new System.Drawing.Point(151, 284);
            this.txtBxCustomerMaas.Name = "txtBxCustomerMaas";
            this.txtBxCustomerMaas.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustomerMaas.TabIndex = 9;
            // 
            // txtBxCustomerPhone
            // 
            this.txtBxCustomerPhone.Location = new System.Drawing.Point(151, 229);
            this.txtBxCustomerPhone.Name = "txtBxCustomerPhone";
            this.txtBxCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustomerPhone.TabIndex = 10;
            // 
            // txtBxUserPassword
            // 
            this.txtBxUserPassword.Location = new System.Drawing.Point(151, 170);
            this.txtBxUserPassword.Name = "txtBxUserPassword";
            this.txtBxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxUserPassword.TabIndex = 11;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(151, 117);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBxUserName.TabIndex = 12;
            // 
            // txtBxCustomerName
            // 
            this.txtBxCustomerName.Location = new System.Drawing.Point(151, 52);
            this.txtBxCustomerName.Name = "txtBxCustomerName";
            this.txtBxCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustomerName.TabIndex = 13;
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(130, 373);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(87, 33);
            this.btnAddP.TabIndex = 14;
            this.btnAddP.Text = "Ekle";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // dataGridEmploye
            // 
            this.dataGridEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmploye.Location = new System.Drawing.Point(352, 67);
            this.dataGridEmploye.Name = "dataGridEmploye";
            this.dataGridEmploye.Size = new System.Drawing.Size(592, 260);
            this.dataGridEmploye.TabIndex = 15;
            // 
            // btnRemoveP
            // 
            this.btnRemoveP.Location = new System.Drawing.Point(454, 373);
            this.btnRemoveP.Name = "btnRemoveP";
            this.btnRemoveP.Size = new System.Drawing.Size(101, 30);
            this.btnRemoveP.TabIndex = 16;
            this.btnRemoveP.Text = "Sil";
            this.btnRemoveP.UseVisualStyleBackColor = true;
            this.btnRemoveP.Click += new System.EventHandler(this.btnRemoveP_Click);
            // 
            // btnGunP
            // 
            this.btnGunP.Location = new System.Drawing.Point(651, 373);
            this.btnGunP.Name = "btnGunP";
            this.btnGunP.Size = new System.Drawing.Size(105, 30);
            this.btnGunP.TabIndex = 17;
            this.btnGunP.Text = "Güncelle";
            this.btnGunP.UseVisualStyleBackColor = true;
            this.btnGunP.Click += new System.EventHandler(this.btnGunP_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comBxCategoryName);
            this.tabPage1.Controls.Add(this.btnGunU);
            this.tabPage1.Controls.Add(this.U);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.btnAddU);
            this.tabPage1.Controls.Add(this.txtBxProductName);
            this.tabPage1.Controls.Add(this.txtBxProdcutPi);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ürün Ekle-Sil-Düzelt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGunU
            // 
            this.btnGunU.Location = new System.Drawing.Point(646, 356);
            this.btnGunU.Name = "btnGunU";
            this.btnGunU.Size = new System.Drawing.Size(105, 30);
            this.btnGunU.TabIndex = 33;
            this.btnGunU.Text = "Güncelle";
            this.btnGunU.UseVisualStyleBackColor = true;
            this.btnGunU.Click += new System.EventHandler(this.btnGunU_Click);
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(449, 356);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(101, 30);
            this.U.TabIndex = 32;
            this.U.Text = "Sil";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(347, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(592, 260);
            this.dataGridView2.TabIndex = 31;
            // 
            // btnAddU
            // 
            this.btnAddU.Location = new System.Drawing.Point(125, 356);
            this.btnAddU.Name = "btnAddU";
            this.btnAddU.Size = new System.Drawing.Size(87, 33);
            this.btnAddU.TabIndex = 30;
            this.btnAddU.Text = "Ekle";
            this.btnAddU.UseVisualStyleBackColor = true;
            this.btnAddU.Click += new System.EventHandler(this.btnAddU_Click);
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(160, 107);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(100, 20);
            this.txtBxProductName.TabIndex = 29;
            // 
            // txtBxProdcutPi
            // 
            this.txtBxProdcutPi.Location = new System.Drawing.Point(160, 172);
            this.txtBxProdcutPi.Name = "txtBxProdcutPi";
            this.txtBxProdcutPi.Size = new System.Drawing.Size(100, 20);
            this.txtBxProdcutPi.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kategori Adı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ürün Adı";
            // 
            // comBxCategoryName
            // 
            this.comBxCategoryName.FormattingEnabled = true;
            this.comBxCategoryName.Items.AddRange(new object[] {
            "Dürüm",
            "Izgara",
            "İcecek",
            "Tatlı"});
            this.comBxCategoryName.Location = new System.Drawing.Point(150, 229);
            this.comBxCategoryName.Name = "comBxCategoryName";
            this.comBxCategoryName.Size = new System.Drawing.Size(121, 21);
            this.comBxCategoryName.TabIndex = 34;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGunM);
            this.tabPage3.Controls.Add(this.btnRemoveM);
            this.tabPage3.Controls.Add(this.dataGridTable);
            this.tabPage3.Controls.Add(this.btnAddM);
            this.tabPage3.Controls.Add(this.txtBxTableName);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(965, 407);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Masa Ekle-Sil-Düzelt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGunM
            // 
            this.btnGunM.Location = new System.Drawing.Point(646, 356);
            this.btnGunM.Name = "btnGunM";
            this.btnGunM.Size = new System.Drawing.Size(105, 30);
            this.btnGunM.TabIndex = 33;
            this.btnGunM.Text = "Güncelle";
            this.btnGunM.UseVisualStyleBackColor = true;
            this.btnGunM.Click += new System.EventHandler(this.btnGunM_Click);
            // 
            // btnRemoveM
            // 
            this.btnRemoveM.Location = new System.Drawing.Point(449, 356);
            this.btnRemoveM.Name = "btnRemoveM";
            this.btnRemoveM.Size = new System.Drawing.Size(101, 30);
            this.btnRemoveM.TabIndex = 32;
            this.btnRemoveM.Text = "Sil";
            this.btnRemoveM.UseVisualStyleBackColor = true;
            // 
            // dataGridTable
            // 
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Location = new System.Drawing.Point(347, 50);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.Size = new System.Drawing.Size(592, 260);
            this.dataGridTable.TabIndex = 31;
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(125, 356);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(87, 33);
            this.btnAddM.TabIndex = 30;
            this.btnAddM.Text = "Ekle";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // txtBxTableName
            // 
            this.txtBxTableName.Location = new System.Drawing.Point(159, 186);
            this.txtBxTableName.Name = "txtBxTableName";
            this.txtBxTableName.Size = new System.Drawing.Size(100, 20);
            this.txtBxTableName.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Masa Adı";
            // 
            // cmBxGarder
            // 
            this.cmBxGarder.FormattingEnabled = true;
            this.cmBxGarder.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.cmBxGarder.Location = new System.Drawing.Point(151, 324);
            this.cmBxGarder.Name = "cmBxGarder";
            this.cmBxGarder.Size = new System.Drawing.Size(121, 21);
            this.cmBxGarder.TabIndex = 35;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.Cıkış;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(12, 445);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(78, 52);
            this.btnexit.TabIndex = 31;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::RestoranOtomasyon.Properties.Resources.geriDön;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(115, 445);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 52);
            this.btngeri.TabIndex = 30;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 509);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploye)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEmploye;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.TextBox txtBxCustomerName;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.TextBox txtBxUserPassword;
        private System.Windows.Forms.TextBox txtBxCustomerPhone;
        private System.Windows.Forms.TextBox txtBxCustomerMaas;
        private System.Windows.Forms.Button btnGunP;
        private System.Windows.Forms.Button btnRemoveP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comBxCategoryName;
        private System.Windows.Forms.Button btnGunU;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddU;
        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.TextBox txtBxProdcutPi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGunM;
        private System.Windows.Forms.Button btnRemoveM;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.TextBox txtBxTableName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmBxGarder;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btngeri;
    }
}