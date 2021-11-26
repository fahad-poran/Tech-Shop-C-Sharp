using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace EcShop
{

    public partial class loginForm : Form
    {
        private string Sql { get; set; }
        internal DataAccess DA { get; set; }
        internal DataSet Ds { get; set; }

        public loginForm()
        {
            this.DA = new DataAccess();
            InitializeComponent();
            this.DA = new DataAccess();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LOCAL);Initial Catalog=eShop;Persist Security Info=True;User ID=sa;Password=12345678");

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserPass.Text == "")
            {
                MessageBox.Show("Fill Username & Password");
            }
            else
            {
                if (cmbRole.SelectedIndex > -1)
                {
                    if (cmbRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txtUserName.Text == "Admin" && txtUserPass.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login failed");
                        }
                    }
                    else
                    {
                        
                        //MessageBox.Show("Your In The Seller Section ");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(1) from SellerTbl where SellerName='" + txtUserName.Text + "' and SellerPass='" + txtUserPass.Text + "'", Con);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            //Sellername = UnameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password");
                        }
                        Con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }
    }
}
