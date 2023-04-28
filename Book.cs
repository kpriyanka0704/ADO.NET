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

namespace WindowsFormsApp1
{
    public partial class Book : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Book()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAllBooks()
        {
            string qry = "select * from Book";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;// add the PK to the col which is in the DataSet
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Book1"); // emp is the new table name given to the DataSet table
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllBooks();
                DataRow row = ds.Tables["Book1"].NewRow();
                row["name"] = txtBookName.Text;
                row["price"] = txtPrice.Text;
                // add new row in the DataTable
                ds.Tables["Book1"].Rows.Add(row);
                int res = da.Update(ds.Tables["Book1"]); // reflect the changes from DataSet to DB
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
                ds= GetAllBooks();
                DataRow row = ds.Tables["Book1"].Rows.Find(txtBookId.Text);
                if (row != null)
                {
                    txtBookName.Text = row["name"].ToString();
                    txtPrice.Text = row["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds= GetAllBooks();
                DataRow row = ds.Tables["Book1"].Rows.Find(txtBookId.Text);
                int res = da.Update(ds.Tables["Book1"]);
                if (res > 0)
                {
                    MessageBox.Show("Record updated");
                }
                else
                {
                    Console.WriteLine("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds= GetAllBooks();
                DataRow row = ds.Tables["Book1"].Rows.Find(txtBookId.Text);
                if(row != null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Book1"]);

                    if(res>0)
                    {
                        Console.WriteLine("Record Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAllBook_Click(object sender, EventArgs e)
        {
            ds= GetAllBooks();
            dataGridView1.DataSource = ds.Tables["Book1"];
        }
    }
}
