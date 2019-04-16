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
    public partial class SiparisGoruntule : Form
    {
        public SiparisGoruntule()
        {
            InitializeComponent();
        }
        string CustomerName;
        string CustomerAdres;
        int adet;
        string ProductName;
        int price;
        int Id;
        private void SiparisGoruntule_Load(object sender, EventArgs e)
        {
            getOrder();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            string value = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
            int deger = Convert.ToInt32(value);
            DbRestoran context = new DbRestoran();
            var value2=context.Order.Where(i => i.Id == deger);
            foreach (var val in value2)
            {
                val.State = false;

            }
            context.SaveChanges();
            dataGridView.ClearSelection();
            getOrder();


        }
        public void getOrder()
        {
            
            DbRestoran context = new DbRestoran();
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Müşteri Adı";
            dataGridView.Columns[2].Name = "Ürün Adı";
            dataGridView.Columns[3].Name = "Adet";
            dataGridView.Columns[4].Name = "Fiyat";
            dataGridView.Columns[5].Name = "Adress";
            var value = context.Order.Where(i => i.State == true);
            foreach (var val in value)
            {
                Id = val.Id;
                CustomerName = val.UserName;
                CustomerAdres = val.Adress;
                adet = val.Piece;
                ProductName = val.ProductName;
                price = Convert.ToInt32(val.Price);
               
                dataGridView.Rows.Add(Id, CustomerName, ProductName, adet, price, CustomerAdres);
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
