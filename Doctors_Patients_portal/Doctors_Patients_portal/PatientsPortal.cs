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
    public partial class PatientsPortal : Form
    {
       
        public PatientsPortal()
        {
            
            InitializeComponent();
            phome1.Show();
            phome1.BringToFront();
        }

        private void prequestbtn_Click(object sender, EventArgs e)
        {
            takeappoin1.Show();
            takeappoin1.BringToFront();
        }

        private void phomebtn_Click(object sender, EventArgs e)
        {
            phome1.Show();
            phome1.BringToFront();
        }

        private void phome1_Load(object sender, EventArgs e)
        {
            phome1.init();
        }

        private void plogoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.Show();

        }

        private void takeappoin1_Load(object sender, EventArgs e)
        {

        }

        private void notificationbtn_Click(object sender, EventArgs e)
        {
            notificationsform1.Show();
            notificationsform1.BringToFront();
            notificationsform1.setnotifications();
        }
    }
}
