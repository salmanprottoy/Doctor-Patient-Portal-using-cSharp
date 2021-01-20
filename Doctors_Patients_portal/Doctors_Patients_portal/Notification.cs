using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_Patients_portal
{
    public partial class Notification : UserControl
    {
        public static DataTable dn;
        DataAccess db = new DataAccess();
        public Notification()
        {
            InitializeComponent();
        }

        public void setnotifications()
        {
            string st = "select * from Accepted where Pname =  '" + PHome.ds.Rows[0]["Name"].ToString() + "';"; ;
            dn = db.Data(st);
            dataGridViewn.DataSource = dn;
        }
    }
}
