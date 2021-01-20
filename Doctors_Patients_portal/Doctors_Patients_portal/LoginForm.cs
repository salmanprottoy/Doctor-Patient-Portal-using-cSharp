using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_Patients_portal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            string st;
            string user = UserName.Text;
            string pass = UserPass.Text;
            if(user!=null && pass!=null )
            {
                DataAccess db = new DataAccess();
                if(radioButtondoclog.Checked)
                {
                    st = "select * from Doctor where User_name='" + user + "' and Password='" + pass + "';";
                    DataTable dt = db.Data(st);
                    if (dt.Rows.Count == 1)
                    {
                        DHome.dd = dt;
                        DoctorsPortal p = new DoctorsPortal();
                        this.Hide();
                        p.Show();
                    }
                    else MessageBox.Show("invalid username or password");
                }
                else if(radioButtonpatientlog.Checked)
                {
                    st = "select * from Patient where User_name='" + user + "' and Password='" + pass + "';";
                    DataTable dt = db.Data(st);
                    if (dt.Rows.Count == 1)
                    {
                        PHome.ds = dt;
                        PatientsPortal p = new PatientsPortal();
                        this.Hide();
                        p.Show();
                        
                        
                    }
                    else
                        MessageBox.Show("invalid username or password");
                }
                else if(adminradiobtnlog.Checked)
                {
                    st = "select * from Admin where User_name='" + user + "' and Password='" + pass + "';";
                    DataTable dt = db.Data(st);
                    if (dt.Rows.Count == 1)
                    {
                        //MessageBox.Show("admin");
                        admin a = new admin();
                        this.Hide();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("invalid username or password");
                    }
                }
                else
                    MessageBox.Show("Let us know whether you're a doctor or a patient!!");
            }
            else
            {
                MessageBox.Show("Maybe you left some fields blank!!");
            }
        }
        private void signupbt_Click(object sender, EventArgs e)
        {
            Signup sn = new Signup();
            this.Hide();
            sn.Show();
        }
    }
}
