using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctor_Patient_Portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            lblAccount.Text = "Admin";
            lblAccount.Visible = true;
            lblSignup.Visible = false;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            lblAccount.Text = "Doctor";
            lblAccount.Visible = true;
            lblSignup.Visible = true;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            lblAccount.Text = "Patient";
            lblAccount.Visible = true;
            lblSignup.Visible = true;
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LogIns WHERE Id=" + this.txtUserId.Text + " AND Password='" + this.txtPassword.Text + "'";
            
        }
    }
}
