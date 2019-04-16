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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }
        string masaId;
        public string MasaName { get; set; }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            masaId = MasaName;

            decimal sum = 0;
            using (DbRestoran context = new DbRestoran())
            {
                var value = context.Order.Where(i => i.State == true && i.FullName==masaId);
                foreach (var val in value)
                {
                    sum += val.Price;
                }

                
                lblHsp.Text = Convert.ToInt32(sum).ToString() + " TL ";

            }
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.ShowDialog();

        }

        private void btnKpt_Click(object sender, EventArgs e)
        {
            bool durum = false;
            DbRestoran context = new DbRestoran();
            var value = context.Order.Where(i => i.State == true && i.FullName == masaId);
            
            foreach (var valu in value)
            {
                valu.State = durum;


            }
            
            context.SaveChanges();

            MasaKapat();


        }
        public void MasaKapat()
        {
            DbRestoran context = new DbRestoran();
            var value = context.Table.Select(i => i);
            foreach (var valu in value)
            {

                if (valu.Name == masaId)
                {
                    valu.State = false;
                }



            }
            
            context.SaveChanges();
            frmTable frm = new frmTable();
            this.Hide();
            frm.ShowDialog();
        }
        
    }
}
