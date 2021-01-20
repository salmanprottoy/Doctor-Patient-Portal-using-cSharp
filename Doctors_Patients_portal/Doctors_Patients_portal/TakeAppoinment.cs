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
    public partial class TakeAppoinment : UserControl
    {
        public TakeAppoinment()
        {
            InitializeComponent();
        }
        public void fillgrid()
        {
            
        }
        public DataTable dt,dr;
        DataAccess db = new DataAccess();
        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            string hos=null, spe=null;
            hos = searchhospital.Text;
            spe = searchspecial.Text;
            if(hos=="" || spe=="")
            {
                MessageBox.Show("Invalid request!!");
            }
            else
            {
                hos = hos.Replace(' ', '_');
                string st = "Select * from " + hos + " where Specialist like '%"+spe+"%'";
                 dt = db.Data(st);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
                this.dataGridView1.Refresh();
                if (dt.Rows.Count>0)
                 {
                    
                     dataGridView1.DataSource = dt;
                    DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                    btn.HeaderText = "";
                    btn.Name = "yesbtn";
                    btn.Text = "Request";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn);
                    hos = hos.Replace('_', ' ');
                    st = "Select * from Requests where Pname = '" + PHome.ds.Rows[0]["Name"].ToString() + "' and Hospital = '" + hos + "';";
                    dr = db.Data(st);
                    for (int i=0;i<dr.Rows.Count;i++)
                    {
                        for(int j=0;j<dataGridView1.Rows.Count;j++)
                        {
                            
                            if (dr.Rows[i]["Dname"].ToString() == dataGridView1.Rows[j].Cells["Name"].Value.ToString())
                            {

                                ((DataGridViewDisableButtonCell)dataGridView1.Rows[j].Cells[5]).Enabled = false;
                            }
                        }
                    }
                    dataGridView1.Refresh();
                }
                 else
                 {
                     MessageBox.Show("No Results found!!");
                 }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && ((DataGridViewDisableButtonCell)dataGridView1.Rows[e.RowIndex].Cells[5]).Enabled != false)
            {
                int a;
                string s = dt.Rows[e.RowIndex]["Id"].ToString();
                bool result = Int32.TryParse(s, out a);
                string st = "INSERT INTO Requests (Id,Dname,Pname,Padd,Hospital) VALUES ( " + a + " , '" + dt.Rows[e.RowIndex]["Name"].ToString() + "' , '" + PHome.ds.Rows[0]["Name"].ToString() + "' , '" + PHome.ds.Rows[0]["Address"].ToString() + "' , '" + searchhospital.Text + "');";
                db.Execute(st);
                ((DataGridViewDisableButtonCell)dataGridView1.Rows[e.RowIndex].Cells[5]).Enabled = false;
                dataGridView1.Refresh();
            }
        }

        
    }
}
