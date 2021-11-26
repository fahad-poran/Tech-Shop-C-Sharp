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
    public partial class SellingForm : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        SqlConnection sc = new SqlConnection(@"Data Source=(LOCAL);Initial Catalog=eShop;Persist Security Info=True;User ID=sa;Password=12345678");
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public SellingForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            PopulateGridView1();
            fill_combo();
        }
        private void PopulateGridView(string sql = "select ProName,ProQty from ProductTbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvSelling1.DataSource = Ds.Tables[0];
        }
        private void PopulateGridView1(string sql = "select * from BillTbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvSelling2.DataSource = Ds.Tables[0];
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }


        private void dgvSelling1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSelling1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProName.Text = this.dgvSelling1.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQn.Text = this.dgvSelling1.CurrentRow.Cells["ProQty"].Value.ToString();
          
        }

        private void lblDate_Paint(object sender, PaintEventArgs e)
        {

            this.lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // need to understand
        { // need to add validateion!!! 

            int n = 0;
            int total = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQn.Text);
            int GrdTotal;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvSelling3);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txtProName.Text;
            newRow.Cells[2].Value = txtProPrice.Text;
            newRow.Cells[3].Value = txtProQn.Text;
            newRow.Cells[4].Value = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQn.Text);
            dgvSelling3.Rows.Add(newRow);
            GrdTotal =+ total;
            lblAmo.Text = ""+GrdTotal;
            n++; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProName.Text == "" || txtProPrice.Text == "" || txtProQn.Text == "")
            {
                MessageBox.Show("You must fill textbox");
            }
            else
            {
                try
                {

                    this.Sql = @"insert into BillTbl values('" + lblSellerName.Text + "','" + lblDate.Text + "','" + lblAmo.Text + "');";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                        MessageBox.Show("Successfully Order addted to database");

                    else
                        MessageBox.Show("Insert unsuccessful");
                    this.PopulateGridView1();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
             if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dgvSelling2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Tech Sop", new Font("Arial",30, FontStyle.Bold),Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: "+dgvSelling2.CurrentRow.Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Sold By:"+dgvSelling2.CurrentRow.Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Bill Date"+dgvSelling2.CurrentRow.Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: "+dgvSelling2.CurrentRow.Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(100, 160));


        }
        private void fill_combo() //need to update connection
        {

            //this.Ds = Da.ExecuteQuery("select CatName from CategoryTbl");
            sc.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", sc);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(dr);

            cmbProdCat.ValueMember = "CatName";
            cmbProdCat.DataSource = dt;
            //this.SP = cmbProdCat.Text;   // cut it off
            sc.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lg = new loginForm();
            lg.Show();
        }
    }
}
