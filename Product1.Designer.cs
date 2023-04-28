namespace WindowsFormsApp1.Disconnected_Architecture
{
    partial class Product1
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
            this.btnShowProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.ProductCompany = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowProduct
            // 
            this.btnShowProduct.Location = new System.Drawing.Point(742, 499);
            this.btnShowProduct.Name = "btnShowProduct";
            this.btnShowProduct.Size = new System.Drawing.Size(184, 27);
            this.btnShowProduct.TabIndex = 27;
            this.btnShowProduct.Text = "Show All Product";
            this.btnShowProduct.UseVisualStyleBackColor = true;
            this.btnShowProduct.Click += new System.EventHandler(this.btnShowProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(590, 322);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(445, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(298, 472);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(150, 472);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(182, 344);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 26);
            this.txtPrice.TabIndex = 21;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(182, 272);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(216, 26);
            this.txtCompany.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 26);
            this.txtName.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(182, 129);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 26);
            this.txtId.TabIndex = 18;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.Location = new System.Drawing.Point(20, 344);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(44, 20);
            this.ProductPrice.TabIndex = 17;
            this.ProductPrice.Text = "Price";
            // 
            // ProductCompany
            // 
            this.ProductCompany.AutoSize = true;
            this.ProductCompany.Location = new System.Drawing.Point(20, 272);
            this.ProductCompany.Name = "ProductCompany";
            this.ProductCompany.Size = new System.Drawing.Size(76, 20);
            this.ProductCompany.TabIndex = 16;
            this.ProductCompany.Text = "Company";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(20, 200);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(51, 20);
            this.ProductName.TabIndex = 15;
            this.ProductName.Text = "Name";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(20, 129);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(78, 20);
            this.ProductId.TabIndex = 14;
            this.ProductId.Text = "ProductId";
            // 
            // Product1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 639);
            this.Controls.Add(this.btnShowProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductCompany);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductId);
            this.Name = "Product1";
            this.Text = "Product1";
            this.Load += new System.EventHandler(this.Product1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label ProductPrice;
        private System.Windows.Forms.Label ProductCompany;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductId;
    }
}