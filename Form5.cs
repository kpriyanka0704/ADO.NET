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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;

        public Form5()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAllEmp()
        {
            string qry = "select * from Employee1";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;// add the PK to the col which is in the DataSet
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "emp"); // emp is the table name given to the DataSet table
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmp();
                DataRow row = ds.Tables["emp"].NewRow();
                row["name"] = txtEmployeeName.Text;
                row["salary"] = txtSalary.Text;
                // add new row in the DataTable
                ds.Tables["emp"].Rows.Add(row);
                int res = da.Update(ds.Tables["emp"]); // reflect the changes from DataSet to DB
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
                ds = GetAllEmp();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    txtEmployeeName.Text = row["name"].ToString();
                    txtSalary.Text = row["salary"].ToString();

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
                ds = GetAllEmp();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    row["name"] = txtEmployeeName.Text;
                    row["salary"] = txtSalary.Text;
                    int res = da.Update(ds.Tables["emp"]); // reflect the changes from DataSet to DB
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

        private void btbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmp();
                //Find() will only work if it is PK col
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    row.Delete();// removes from DataSet
                    int res = da.Update(ds.Tables["emp"]); // reflect the changes from DataSet to DB
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetAllEmp();
            dataGridView2.DataSource = ds.Tables["emp"];

        }
    }
}
