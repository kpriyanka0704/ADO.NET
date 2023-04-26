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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtEmployeeId.Clear();
            txtEmployeeName.Clear();
            txtSalary.Clear();

        }
        private void btbDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                string qry = "Delete from Employee1 where id=@id";
               
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmployeeId.Text));
                con.Open();
                
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("Record Deleted");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                string qry = "insert into Employee1 values(@name,@salary)";
               
                cmd = new SqlCommand(qry, con);
               
                cmd.Parameters.AddWithValue("@name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
                con.Open();
                
                int response = cmd.ExecuteNonQuery();
                if (response > 0)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee1 where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmployeeId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // if record is present then return true else false
                {
                    while (dr.Read())
                    {
                        txtEmployeeName.Text = dr["name"].ToString();
                        txtSalary.Text = dr["salary"].ToString();
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
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                string qry = "update Employee1 set name=@name, salary=@salary where id=@id";
                
                cmd = new SqlCommand(qry, con);
                
                cmd.Parameters.AddWithValue("@name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmployeeId.Text));

                con.Open();
               
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Record updated");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee1";

                cmd = new SqlCommand(qry, con);

                con.Open();

                dr = cmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView2.DataSource = table;
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
            finally
            {
                con.Close();
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
