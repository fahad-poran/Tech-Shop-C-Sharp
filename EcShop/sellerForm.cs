﻿using System;
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
    public partial class sellerForm : Form
    {
        internal DataAccess DA { get; set; }
        internal DataSet DS { get; set; }
        internal string SQL { get; set; }

        public sellerForm()
        {
            InitializeComponent();
            this.DA = new DataAccess();
            this.populatedGridView();
        }

        private void populatedGridView(string sql = "select * from SellerTbl")
        {
            this.DS = this.DA.ExecuteQuery(sql);
            this.dgvSellerView.DataSource = DS.Tables[0];
        }

        private void dgvSellerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvSellerView.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dgvSellerView.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvSellerView.CurrentRow.Cells[3].Value.ToString();
            txtPass.Text = dgvSellerView.CurrentRow.Cells[4].Value.ToString();

        }
        private bool IsValidToSave()
        {
            if(String.IsNullOrWhiteSpace(this.txtName.Text)||String.IsNullOrWhiteSpace(this.txtAge.Text)||
                String.IsNullOrWhiteSpace(this.txtPhone.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidToSave())
            {
                this.SQL = "insert into SellerTbl values('" + txtName.Text + "'," + txtAge.Text + "," + txtPhone.Text + "," + txtPass.Text + ")";
                int row = DA.ExecuteUpdateQuery(this.SQL);
                if (row == 1)
                    MessageBox.Show("Data insertion Successfull:");
                else
                    MessageBox.Show("Error in data insertion");

                this.populatedGridView();
            }
            else { MessageBox.Show("Please fill the contents"); }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvSellerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvSellerView.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dgvSellerView.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvSellerView.CurrentRow.Cells[3].Value.ToString();
            txtPass.Text = dgvSellerView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvSellerView.CurrentRow.Cells[0].Value.ToString());

            if (txtName.Text == "" || txtAge.Text == "" || txtPass.Text == "" ||txtPhone.Text == "")
            {
                MessageBox.Show("You must fill textbox");
            }
            else
            {
                try
                {
                    //  MessageBox.Show(SP.ToString());
                    this.SQL = @"Update SellerTbl set SellerName ='" + txtName.Text + "',SellerAge ='" + txtAge.Text + "',SellerPhone ='" + txtPhone.Text + "',SellerPass ='" + txtPass.Text + "' where SellerId = '" + id + "'";
                    int count = DA.ExecuteUpdateQuery(this.SQL);
                    if (count == 0)
                        MessageBox.Show("Edit unsuccessful");
                    else
                    {
                        this.populatedGridView(); MessageBox.Show("Edit Successful");
                           txtName.Text = "";txtAge.Text = "";txtPass.Text="" ;txtPhone.Text = "";
                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvSellerView.CurrentRow.Cells[0].Value.ToString());

            if (txtName.Text == "" || txtAge.Text == "" || txtPass.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("You must fill textbox");
            }
            else
            {
                try
                {
                    this.SQL = @"delete from SellerTbl where Catid = '" + id + "' ;";
                    int count = DA.ExecuteUpdateQuery(this.SQL);
                    if (count == 0)
                        MessageBox.Show("Delete unsuccessful");
                    else
                    {
                        this.populatedGridView();
                        MessageBox.Show("Successfully Deleted");
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
    }
}
