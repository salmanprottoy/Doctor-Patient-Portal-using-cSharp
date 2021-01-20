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
    public partial class DHome : UserControl
    {
        public static DataTable dd;
        public DHome()
        {
            InitializeComponent();
        }
        public void init()
        {
            dhomenamebox.Text = dd.Rows[0]["Name"].ToString();
            daddresshbox.Text = dd.Rows[0]["Address"].ToString();
            dspecialbox.Text = dd.Rows[0]["Specialist"].ToString();
        }
    }
}
