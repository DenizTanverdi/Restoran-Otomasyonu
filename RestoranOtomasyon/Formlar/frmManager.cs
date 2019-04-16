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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (txtBxCustomerName.Text == "")
            {
                MessageBox.Show("Bilgileri Doldurunuz...");
            }


            else
            {
                bool gender = true;
                if (cmBxGarder.Text == "Bay")
                {
                    gender = true;
                }
                else
                {
                    gender = false;
                }
                DbRestoran context = new DbRestoran();
                Employee emp = new Employee
                {
                    FullName = txtBxCustomerName.Text,
                    MailAddress = txtBxUserName.Text,
                    Password = txtBxUserPassword.Text,
                    Phone = txtBxCustomerPhone.Text,
                    Price = Convert.ToInt32(txtBxCustomerMaas.Text),
                    Gender = gender,
                    IsActive = true,
                    SaveDate = DateTime.Now.ToLocalTime(),



                };
                context.Employee.Add(emp);
                context.SaveChanges();
                getAllEmployee();
            }
        }
        public void getAllEmployee()
        {
            DbRestoran context = new DbRestoran();

            var rsult = context.Employee.Where(i => i.IsActive == true).ToList();
            dataGridEmploye.DataSource = rsult;




        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            getAllEmployee();
            getAllProduct();
            getAllTable();
        }

        private void btnGunP_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();

            int sayi = Convert.ToInt32(dataGridEmploye.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = context.Employee.Where(w => w.Id == sayi).FirstOrDefault();
            guncelle.FullName = dataGridEmploye.CurrentRow.Cells["FullName"].Value.ToString();
            guncelle.Phone = dataGridEmploye.CurrentRow.Cells["Phone"].Value.ToString();
            guncelle.MailAddress = dataGridEmploye.CurrentRow.Cells["MailAddress"].Value.ToString();
            guncelle.Price = Convert.ToDecimal(dataGridEmploye.CurrentRow.Cells["Price"].Value.ToString());
            guncelle.Gender = Convert.ToBoolean(dataGridEmploye.CurrentRow.Cells["Gender"].Value.ToString());
            context.SaveChanges();
            getAllEmployee();
        }

        private void btnRemoveP_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();
            int sayi = Convert.ToInt32(dataGridEmploye.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = context.Employee.Where(w => w.Id == sayi).FirstOrDefault();
            guncelle.IsActive = false;
            context.SaveChanges();
            getAllEmployee();
        }

        private void btnAddU_Click(object sender, EventArgs e)
        {
            if (txtBxProductName.Text == "")
            {
                MessageBox.Show("Bilgileri Doldurunuz...");
            }
            else
            {
                DbRestoran context = new DbRestoran();
                Product product = new Product
                {
                    FullName = txtBxProductName.Text,
                    CategoryId = comBxCategoryName.Text,
                    Price = Convert.ToDecimal(txtBxProdcutPi.Text),



                };
                context.Product.Add(product);
                context.SaveChanges();
                getAllEmployee();
            }
        }
        public void getAllProduct()
        {
            DbRestoran context = new DbRestoran();

            var rsult = context.Product.Select(i => i).ToList();
            dataGridView2.DataSource = rsult;

        }

        private void btnGunU_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();

            int sayi = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = context.Product.Where(w => w.Id == sayi).FirstOrDefault();
            guncelle.FullName = dataGridView2.CurrentRow.Cells["FullName"].Value.ToString();

            guncelle.Price = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["Price"].Value.ToString());
            guncelle.CategoryId = dataGridView2.CurrentRow.Cells["CategoryId"].Value.ToString();

            context.SaveChanges();
            getAllProduct();

        }

        private void U_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();
            int sayi = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Id"].Value.ToString());
            context.Product.Where(i => i.Id == sayi);
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();
            Table table = new Table
            {
                Name = txtBxTableName.Text,
                State = false,
            };
            context.Table.Add(table);
            context.SaveChanges();
            getAllTable();
        }
        public void getAllTable()
        {
            DbRestoran context = new DbRestoran();
            var table = context.Table.Select(i => i).ToList();
            dataGridTable.DataSource = table;
        }

        private void btnGunM_Click(object sender, EventArgs e)
        {
            DbRestoran context = new DbRestoran();

            int sayi = Convert.ToInt32(dataGridTable.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = context.Table.Where(w => w.Id == sayi).FirstOrDefault();
            guncelle.Name = dataGridTable.CurrentRow.Cells["Name"].Value.ToString();

            guncelle.State = Convert.ToBoolean(dataGridTable.CurrentRow.Cells["State"].Value.ToString());
           

            context.SaveChanges();
            getAllTable();
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
