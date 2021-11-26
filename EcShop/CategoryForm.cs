using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcShop
{
    public partial class CategoryForm : Form
    {
        internal DataAccess Da { get;set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public CategoryForm()
        {
            InitializeComponent();
           this.Da = new DataAccess();
            this.PopulateGridView();
          
        }
        private void grdCatView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtCatIdTbl.Text = grdCatView.CurrentRow.Cells["ID"].Value.ToString();
            CatnameTbl.Text = grdCatView.CurrentRow.Cells["catName"].Value.ToString();
            CatDescTbl.Text = grdCatView.CurrentRow.Cells["catDesc"].Value.ToString();

        }
       
        private void PopulateGridView(string sql = "select * from Categorytbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.grdCatView.AutoGenerateColumns = false;
            this.grdCatView.DataSource = Ds.Tables[0];
          
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CatnameTbl.Text == "" && CatDescTbl.Text == "")
            {
                MessageBox.Show("You must fill textbox");
            }
            else { 
            try
            {   
               
                this.Sql = @"insert into CategoryTbl(CatName,CatDesc) values('"+CatnameTbl.Text+"','"+CatDescTbl.Text+"');";
                int count = Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                    MessageBox.Show("Successfully Category addted to database");
                
                 else
                    MessageBox.Show("Insert unsuccessful");
                this.PopulateGridView();
              }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       // int i = 1;
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
           
            string sql = "select * from CategoryTbl where CatName like '" + txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);

        }

    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grdCatView.CurrentRow.Cells[0].Value.ToString());
           
            if (CatnameTbl.Text == "" && CatDescTbl.Text == "")
            {
                MessageBox.Show("You must fill textbox");
            }
            else
            {
                try{
                    this.Sql = @"Update CategoryTbl set CatName ='" + CatnameTbl.Text + "',CatDesc ='" + CatDescTbl.Text + "' where CatId = '" + id + "'";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 0)
                        MessageBox.Show("Edit unsuccessful");
                    else
                        { this.PopulateGridView(); MessageBox.Show("Edit Successful"); }

                }
                catch (Exception ex)
                {MessageBox.Show(ex.Message);}
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grdCatView.CurrentRow.Cells[0].Value.ToString());

            if (CatnameTbl.Text == "rr" && CatDescTbl.Text == "rr")
            {
                MessageBox.Show("You must fill textbox to Delete");
            }
            else
            {
                try
                {
                    this.Sql = @"delete from CategoryTbl where Catid = '"+id+"' ;";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 0)
                        MessageBox.Show("Delete unsuccessful");
                    else
                    { this.PopulateGridView();
                       MessageBox.Show("Successfully Deleted");}
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
       
        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (a == 0) { this.txtAutoSearch.Text = ""; a = 1; }         
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }
    }
}

