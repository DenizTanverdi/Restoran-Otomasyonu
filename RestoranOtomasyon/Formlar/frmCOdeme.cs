using RestoranOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon.Formlar
{
    public partial class frmCOdeme : Form
    {
        public frmCOdeme()
        {
            InitializeComponent();
        }
        public string MasaName { get; set; }
        string masaId;
        private void frmCOdeme_Load(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            masaId = MasaName;

            decimal sum = 0;
            using (DbRestoran context = new DbRestoran())
            {
                var value = context.Order.Where(i => i.State == true && i.FullName == masaId);
                foreach (var val in value)
                {
                    sum += val.Price;
                }


                lblHsp.Text = Convert.ToInt32(sum).ToString() + " TL ";

            }
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme işlemimiz kapıda gerçekleşmektedir...");
        }
    }
}
