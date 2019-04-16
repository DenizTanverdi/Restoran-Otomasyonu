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
    public partial class frmTable : DevExpress.XtraEditors.XtraForm
    {
        public string masaId;
        public string masaName;
        public frmTable()
        {
            InitializeComponent();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();


            context.Table.ToList().ForEach(table =>
                {

                    if (table.State == true)
                    {
                        var chcTable = new Button
                        {
                            Text = table.Name,
                            Name = table.Id.ToString(),
                            BackColor = Color.Red,
                            Height = 125,
                            Width = 125,
                            Font = new Font(FontFamily.GenericSansSerif,
            25.0F, FontStyle.Bold)
                        };

                        flowLayoutPanel1.Controls.Add(chcTable);
                        chcTable.Click += chcTable_Clik;

                    }
                    else
                    {

                        var chcTable = new Button
                        {
                            Text = table.Name,
                            Name = table.Id.ToString(),
                            BackColor = Color.Green,
                            Height = 125,
                            Width = 125,
                            Font = new Font(FontFamily.GenericSansSerif,
            25.0F, FontStyle.Bold),


                        };
                        masaId = chcTable.Name;
                        flowLayoutPanel1.Controls.Add(chcTable);
                        chcTable.Click += chcTable_Clik;

                    }





                });
            var value = context.Order.Where(i => i.OrderType == 0 && i.State == true).Count();
            if (value >= 1)
            {

                btnCstr.BackColor = Color.Red;


            }
            btnCstr.Text = value.ToString();

        }
        public void chcTable_Clik(object sender, EventArgs e)
        {


            frmMenu frm = new frmMenu();
            frm.MasaId = ((Button)sender).Name;
            frm.MasaName = ((Button)sender).Text;
            this.Hide();
            frm.ShowDialog();

        }

        private void btnCstr_Click(object sender, EventArgs e)
        {
            SiparisGoruntule frm = new SiparisGoruntule();
            this.Hide();
            frm.ShowDialog();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}