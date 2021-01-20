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
    public partial class DRequest : UserControl
    {
        public static DataTable doct;
        DataAccess db = new DataAccess();
        public DRequest()
        {
            InitializeComponent();
        }

       public void setgrid()
        {

            int a;
            string s = DHome.dd.Rows[0]["Id"].ToString();
            bool result = Int32.TryParse(s, out a);
            string st = "select Pname , Padd , Hospital from Requests where Id = " + a + ";";
            doct = db.Data(st);
            if (doct.Rows.Count > 0)
            {
                dataGridViewdoc.DataSource = doct;
                DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                btn.HeaderText = " ";
                btn.Name = "yesbtn";
                btn.Text = "Accept";
                btn.UseColumnTextForButtonValue = true;
                dataGridViewdoc.Columns.Add(btn);
            }
            else
            {
                dataGridViewdoc.DataSource = doct;
                DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                btn.HeaderText = " ";
                btn.Name = "yesbtn";
                btn.Text = "Accept";
                btn.UseColumnTextForButtonValue = true;
                dataGridViewdoc.Columns.Add(btn);
            }
        }

        private void dataGridViewdoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                string st = "Insert Into Accepted (Id,Dname,Pname,Padd,Hospital) values ( " + DHome.dd.Rows[0]["Id"] + " , '" + DHome.dd.Rows[0]["Name"].ToString() + "' , '" + dataGridViewdoc.Rows[e.RowIndex].Cells["Pname"].Value.ToString() + "' , '"+ dataGridViewdoc.Rows[e.RowIndex].Cells["Padd"].Value.ToString()+"' , '"+ dataGridViewdoc.Rows[e.RowIndex].Cells["Hospital"].Value.ToString()+"');";
                db.Execute(st);
                st = "Delete from Requests where Dname = '" + DHome.dd.Rows[0]["Name"].ToString() + "' and Pname =  '" + dataGridViewdoc.Rows[e.RowIndex].Cells["Pname"].Value.ToString() + "' and Hospital = '" + dataGridViewdoc.Rows[e.RowIndex].Cells["Hospital"].Value.ToString() + "';";
                db.Execute(st);
                this.setgrid();
            }
        }
    }
}
