using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void label1_Click(object sender, EventArgs e)
       {

       }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Application Loaded");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked Login Button");
            if(txtUserName.Text=="Admin" && txtPassword.Text=="123")
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked Reset Button");
            txtUserName.Clear();
            txtPassword.Clear();

        }

       
    }
}
