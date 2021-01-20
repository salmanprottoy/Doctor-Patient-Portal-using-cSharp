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
    public partial class DoctorsPortal : Form
    {
        public DoctorsPortal()
        {
            InitializeComponent();
            dhome1.Show();
            dhome1.BringToFront();

        }

        private void dhome1_Load(object sender, EventArgs e)
        {
            dhome1.init();
        }

        private void dhomebtn_Click(object sender, EventArgs e)
        {
            dhome1.Show();
            dhome1.BringToFront();
        }

        private void drequestbtn_Click(object sender, EventArgs e)
        {
            
            drequests1.Show();
            drequests1.BringToFront();
            drequests1.setgrid();
        }

        private void drequests1_Load(object sender, EventArgs e)
        {
            //drequests1.setgrid();
        }

        private void dlogoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }
    }
}
