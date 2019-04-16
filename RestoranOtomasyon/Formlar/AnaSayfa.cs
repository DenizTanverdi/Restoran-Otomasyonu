using RestoranOtomasyon.Entities;
using RestoranOtomasyon.Formlar;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        string CustomerName;
        string Adress;
        int CustomerId;
        Form Login()
        {

            using (DbRestoran context = new DbRestoran())
            {
                
                if (context.Customer.Any(i => i.MailAddress == txtbxUserName.Text && i.Password == txtBxPass.Text))
                {
                    var value = context.Customer.Where(i=>i.MailAddress== txtbxUserName.Text).Select(i => i);
                    foreach(var val in value)
                    {
                        CustomerName = val.FullName;
                        CustomerId = val.Id;
                        Adress = val.Address;
                        
                    }

                    frmMenu frm = new frmMenu();
                    frm.CustomerName = CustomerName;
                    frm.CustomerId = CustomerId.ToString();
                    frm.Adress = Adress;
                    return frm;


                }
                else if (context.Employee.Any(i => i.MailAddress == txtbxUserName.Text && i.Password == txtBxPass.Text))
                {

                    return new frmTable();


                }
                else if(context.Manager.Any(i=>i.MailAddress==txtbxUserName.Text&& i.Password==txtBxPass.Text))
                {
                    return new frmManager();
                }
                else
                {
                    return null;
                }

            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            var result = Login();
            if (result == null)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız !!!!");

            }
            else
            {
                this.Hide();
                result.ShowDialog();

            }

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}