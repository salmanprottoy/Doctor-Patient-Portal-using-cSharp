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
    public partial class PHome : UserControl
    {
        public static DataTable ds;
        public PHome()
        {
            InitializeComponent();
                
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        public void init()
        {
            phomenamebox.Text = ds.Rows[0]["Name"].ToString();
            paddresshbox.Text = ds.Rows[0]["Address"].ToString();
        }

        private void phome_Load(object sender, EventArgs e)
        {

        }

       
    }
}
