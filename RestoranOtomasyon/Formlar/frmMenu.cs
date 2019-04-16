using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RestoranOtomasyon.Entities;

namespace RestoranOtomasyon.Formlar
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public string MasaId { get; set; }
        public string MasaName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string Adress { get; set; }
        

        public string cName;
        

        private void btnIcck_Click(object sender, EventArgs e)
        {


            int sayi = 0;

            lvUrun.Items.Clear();
            DbRestoran context = new DbRestoran();
            var icecek = context.Product.Where(i => i.CategoryId == "icecek").Select(i => i);
            foreach (var value in icecek)
            {

                lvUrun.Items.Add(value.FullName);
                lvUrun.Items[sayi].SubItems.Add(Convert.ToInt32(value.Price).ToString());
                lvUrun.Items[sayi].SubItems.Add(value.Id.ToString());

                sayi++;


            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            btn0.Click += new EventHandler(Hesap);
            btn1.Click += new EventHandler(Hesap);
            btn2.Click += new EventHandler(Hesap);
            btn3.Click += new EventHandler(Hesap);
            btn4.Click += new EventHandler(Hesap);
            btn5.Click += new EventHandler(Hesap);
            btn6.Click += new EventHandler(Hesap);
            btn7.Click += new EventHandler(Hesap);
            btn8.Click += new EventHandler(Hesap);
            btn9.Click += new EventHandler(Hesap);
            btnTemizle.Click += new EventHandler(Hesap);
            if (CustomerName == null) { lblMasaıd.Text = MasaName; }
            else { lblMasaıd.Text = CustomerName; }
          



        }
        void Hesap(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn1":
                    txtBxAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtBxAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtBxAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtBxAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtBxAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtBxAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtBxAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtBxAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtBxAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtBxAdet.Text += (0).ToString();
                    break;
                case "btnTemizle":
                    txtBxAdet.Text = "";
                    break;

                default:
                    MessageBox.Show("Sayı Giriniz");
                    break;
            }
        }

        private void BtnIzgara_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            lvUrun.Items.Clear();
            DbRestoran context = new DbRestoran();
            var Izgara = context.Product.Where(i => i.CategoryId == "Izgara").Select(i => i);
            foreach (var value in Izgara)
            {

                lvUrun.Items.Add(value.FullName);
                lvUrun.Items[sayi].SubItems.Add(Convert.ToInt32(value.Price).ToString());
                lvUrun.Items[sayi].SubItems.Add(value.Id.ToString());

                sayi++;


            }

        }

        private void btnDrm_Click(object sender, EventArgs e)
        {

            int sayi = 0;

            lvUrun.Items.Clear();
            DbRestoran context = new DbRestoran();
            var Durum = context.Product.Where(i => i.CategoryId == "Dürüm").Select(i => i);
            foreach (var value in Durum)
            {

                lvUrun.Items.Add(value.FullName);
                lvUrun.Items[sayi].SubItems.Add(Convert.ToInt32(value.Price).ToString());
                lvUrun.Items[sayi].SubItems.Add(value.Id.ToString());

                sayi++;


            }
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {


            int sayi = 0;

            lvUrun.Items.Clear();
            DbRestoran context = new DbRestoran();
            var tatli = context.Product.Where(i => i.CategoryId == "tatli").Select(i => i);
            foreach (var value in tatli)
            {

                lvUrun.Items.Add(value.FullName);
                lvUrun.Items[sayi].SubItems.Add(Convert.ToInt32(value.Price).ToString());
                lvUrun.Items[sayi].SubItems.Add(value.Id.ToString());

                sayi++;


            }
        }
        int sayac = 0;
        int sayac2 = 0;
        private void lvUrun_DoubleClick(object sender, EventArgs e)
        {
            if (txtBxAdet.Text == "")
            {
                txtBxAdet.Text = "1";
            }
            if (lvUrun.Items.Count > 0)
            {
                sayac = lvSiparis.Items.Count;
                lvSiparis.Items.Add(lvUrun.SelectedItems[0].Text);
                lvSiparis.Items[sayac].SubItems.Add(txtBxAdet.Text);
                lvSiparis.Items[sayac].SubItems.Add((Convert.ToInt32(lvUrun.SelectedItems[0].SubItems[1].Text) * Convert.ToInt32(txtBxAdet.Text)).ToString());
                lvSiparis.Items[sayac].SubItems.Add(lvUrun.SelectedItems[0].SubItems[2].Text);

            }
        }

        private void btnSprs_Click(object sender, EventArgs e)
        {
            int state;
           
            if (MasaName == null)
            {
                state = 0;
                cName = CustomerId;
            }
            else
            {
                state = 1;
                cName = MasaName;
            }

            using (DbRestoran context = new DbRestoran())
            {
                
                for (int i = 0; i < lvSiparis.Items.Count; i++)
                {
                    Order siparis = new Order
                    {
                        FullName = cName,
                        OrderType = state, // 1 ise masadan geldiğini belli eder 
                        Piece = Convert.ToInt32(lvSiparis.Items[i].SubItems[1].Text),
                        ProductId = Convert.ToInt32(lvSiparis.Items[i].SubItems[3].Text),
                        ProductName = lvSiparis.Items[i].SubItems[0].Text,
                        Price = Convert.ToInt32(lvSiparis.Items[i].SubItems[2].Text),
                        State = true,
                        Adress = Adress,
                        UserName = CustomerName,





                    };
                    context.Order.Add(siparis);
                    

                }
                var value = context.Table.Select(i => i);
                foreach (var valu in value)
                {

                    if (valu.Name == MasaName)
                    {
                        valu.State = true;
                    }
                    


                }
                context.SaveChanges();

            }
           
            MessageBox.Show("Ürünler Eklendi...");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            lvSiparis.Items.Clear();

        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            frmOdeme frm = new frmOdeme();
            frmCOdeme frm2 = new frmCOdeme();
            if (MasaName == null)
            {
                
                cName = CustomerId;
                frm2.MasaName = cName;
                frm2.ShowDialog();
            }
            else
            {
                
                cName = MasaName;
                frm.MasaName = cName;
                frm.ShowDialog();
            }
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            if (MasaName == null)
            {

                AnaSayfa frm = new AnaSayfa();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {

                frmTable frm = new frmTable();
                this.Hide();
                frm.ShowDialog();
            }
         
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
