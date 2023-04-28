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
    public partial class Student1 : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Student1()
        {
            InitializeComponent();
           con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void Student1_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAllStudents()
        {
            string qry = "select * from NewStudent";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;// add the PK to the col in the DataSet
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Student"); // emp is the new table name given to the DataSet table
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudents();
                DataRow row = ds.Tables["Student"].NewRow();
                row["name"] = txtName.Text;
                row["branch"] = txtBranch.Text;
                row["per"] = txtPer.Text;
                // add new row in the DataTable
                ds.Tables["Student"].Rows.Add(row);
                int res = da.Update(ds.Tables["Student"]); // reflect the changes from DataSet to DB
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
                ds = GetAllStudents();
                //Find() will only work if it is PK column
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtBranch.Text = row["branch"].ToString();
                    txtPer.Text = row["per"].ToString();

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
                ds = GetAllStudents();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["branch"] = txtBranch.Text;
                    row["per"] = txtPer.Text;
                    int res = da.Update(ds.Tables["Student"]); //reflect the changes from DataSet to DB
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
                ds = GetAllStudents();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["Student"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row.Delete();// removes from DataSet
                    int res = da.Update(ds.Tables["Student"]); // reflect the changes from DataSet to DB
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

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            ds = GetAllStudents();
            dataGridView1.DataSource = ds.Tables["Student"];
        }
    }
}
