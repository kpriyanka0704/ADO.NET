using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Disconnected_Architecture
{
    public partial class Product1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Product1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void Product1_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAllProducts()
        {
            string qry = "select * from Product";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;// add the PK to the col in the DataSet
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Product1"); // emp is the new table name given to the DataSet table
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProducts();
                DataRow row = ds.Tables["Product1"].NewRow();
                row["name"] = txtName.Text;
                row["company"] = txtCompany.Text;
                row["price"] = txtPrice.Text;
                // add new row in the DataTable
                ds.Tables["Product1"].Rows.Add(row);
                int res = da.Update(ds.Tables["Product1"]); // reflect the changes from DataSet to DB
                if (res > 0)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProducts();
                //Find() will only work if it is PK column
                DataRow row = ds.Tables["Product1"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtCompany.Text = row["company"].ToString();
                    txtPrice.Text = row["price"].ToString();

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProducts();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["Product1"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["company"] = txtCompany.Text;
                    row["price"] = txtPrice.Text;
                    int res = da.Update(ds.Tables["Product1"]); // reflect the changes from DataSet to DB
                    if (res > 0)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetAllProducts();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["Product1"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();// removes from DataSet
                    int res = da.Update(ds.Tables["Product1"]); // reflect the changes from DataSet to DB
                    if (res > 0)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }

                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            ds = GetAllProducts();
            dataGridView1.DataSource = ds.Tables["Product1"];
        }
    }

}
