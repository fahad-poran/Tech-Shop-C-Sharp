namespace EcShop
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblAmo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSelling3 = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSelling1 = new System.Windows.Forms.DataGridView();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.txtProPrice = new System.Windows.Forms.RichTextBox();
            this.btnProRef = new System.Windows.Forms.Button();
            this.dgvSelling2 = new System.Windows.Forms.DataGridView();
            this.btnProDel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProQn = new System.Windows.Forms.RichTextBox();
            this.txtProName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProId = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblSellerName);
            this.panel1.Controls.Add(this.lblAmo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvSelling3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbProdCat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvSelling1);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.txtProPrice);
            this.panel1.Controls.Add(this.btnProRef);
            this.panel1.Controls.Add(this.dgvSelling2);
            this.panel1.Controls.Add(this.btnProDel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProQn);
            this.panel1.Controls.Add(this.txtProName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 583);
            this.panel1.TabIndex = 1;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Location = new System.Drawing.Point(21, 7);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(44, 17);
            this.lblSellerName.TabIndex = 51;
            this.lblSellerName.Text = "Seller";
            // 
            // lblAmo
            // 
            this.lblAmo.AutoSize = true;
            this.lblAmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmo.Location = new System.Drawing.Point(625, 243);
            this.lblAmo.Name = "lblAmo";
            this.lblAmo.Size = new System.Drawing.Size(0, 18);
            this.lblAmo.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Name";
            // 
            // dgvSelling3
            // 
            this.dgvSelling3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSelling3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelling3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.Price,
            this.Qty,
            this.Total});
            this.dgvSelling3.Location = new System.Drawing.Point(398, 71);
            this.dgvSelling3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelling3.Name = "dgvSelling3";
            this.dgvSelling3.RowTemplate.Height = 28;
            this.dgvSelling3.Size = new System.Drawing.Size(524, 157);
            this.dgvSelling3.TabIndex = 48;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ID";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "PName";
            this.ProdName.Name = "ProdName";
            // 
            // Price
            // 
            this.Price.HeaderText = "PPrice";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "Sells List";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(530, 243);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 18);
            this.lblAmount.TabIndex = 46;
            this.lblAmount.Text = "Amount Tk";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(142, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(803, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Date";
            this.lblDate.Paint += new System.Windows.Forms.PaintEventHandler(this.lblDate_Paint);
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Location = new System.Drawing.Point(112, 269);
            this.cmbProdCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(128, 24);
            this.cmbProdCat.TabIndex = 43;
            this.cmbProdCat.Text = "Select Catagory";
            this.cmbProdCat.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Category";
            // 
            // dgvSelling1
            // 
            this.dgvSelling1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSelling1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelling1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSelling1.Location = new System.Drawing.Point(48, 313);
            this.dgvSelling1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelling1.Name = "dgvSelling1";
            this.dgvSelling1.RowTemplate.Height = 28;
            this.dgvSelling1.Size = new System.Drawing.Size(292, 263);
            this.dgvSelling1.TabIndex = 41;
            this.dgvSelling1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelling1_CellClick);
            this.dgvSelling1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelling1_CellContentClick);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtAutoSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAutoSearch.Location = new System.Drawing.Point(24, 27);
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(358, 27);
            this.txtAutoSearch.TabIndex = 40;
            this.txtAutoSearch.Text = "🔍 Search Product Name ";
            this.txtAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(61, 155);
            this.txtProPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(113, 26);
            this.txtProPrice.TabIndex = 39;
            this.txtProPrice.Text = "";
            // 
            // btnProRef
            // 
            this.btnProRef.BackColor = System.Drawing.Color.Coral;
            this.btnProRef.FlatAppearance.BorderSize = 0;
            this.btnProRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProRef.Location = new System.Drawing.Point(257, 264);
            this.btnProRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProRef.Name = "btnProRef";
            this.btnProRef.Size = new System.Drawing.Size(82, 32);
            this.btnProRef.TabIndex = 38;
            this.btnProRef.Text = "Refresh";
            this.btnProRef.UseVisualStyleBackColor = false;
            // 
            // dgvSelling2
            // 
            this.dgvSelling2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSelling2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelling2.Location = new System.Drawing.Point(398, 304);
            this.dgvSelling2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelling2.Name = "dgvSelling2";
            this.dgvSelling2.RowTemplate.Height = 28;
            this.dgvSelling2.Size = new System.Drawing.Size(524, 212);
            this.dgvSelling2.TabIndex = 36;
            this.dgvSelling2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelling2_CellContentClick);
            // 
            // btnProDel
            // 
            this.btnProDel.BackColor = System.Drawing.Color.Coral;
            this.btnProDel.FlatAppearance.BorderSize = 0;
            this.btnProDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProDel.Location = new System.Drawing.Point(764, 536);
            this.btnProDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(82, 32);
            this.btnProDel.TabIndex = 35;
            this.btnProDel.Text = "Delete";
            this.btnProDel.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Coral;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(644, 536);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 32);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Coral;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(519, 536);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price";
            // 
            // txtProQn
            // 
            this.txtProQn.Location = new System.Drawing.Point(256, 155);
            this.txtProQn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProQn.Name = "txtProQn";
            this.txtProQn.Size = new System.Drawing.Size(112, 26);
            this.txtProQn.TabIndex = 30;
            this.txtProQn.Text = "";
            // 
            // txtProName
            // 
            this.txtProName.Enabled = false;
            this.txtProName.Location = new System.Drawing.Point(257, 90);
            this.txtProName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(112, 26);
            this.txtProName.TabIndex = 29;
            this.txtProName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Product";
            // 
            // txtProId
            // 
            this.txtProId.Location = new System.Drawing.Point(61, 91);
            this.txtProId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(113, 26);
            this.txtProId.TabIndex = 26;
            this.txtProId.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bill Id";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblClose.Location = new System.Drawing.Point(915, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 27);
            this.lblClose.TabIndex = 24;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F);
            this.label1.Location = new System.Drawing.Point(314, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling Products";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(12, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 52;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.RichTextBox txtProPrice;
        private System.Windows.Forms.Button btnProRef;
        private System.Windows.Forms.DataGridView dgvSelling2;
        private System.Windows.Forms.Button btnProDel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtProQn;
        private System.Windows.Forms.RichTextBox txtProName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtProId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelling1;
        private System.Windows.Forms.ComboBox cmbProdCat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSelling3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblAmo;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
    }
}