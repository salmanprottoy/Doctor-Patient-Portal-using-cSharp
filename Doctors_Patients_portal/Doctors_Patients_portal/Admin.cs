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
    public partial class admin : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        char c;
        public admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {

            c = 'd';
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dt.Clear();
            dataGridView2.Refresh();
            string query = "select * from Doctor";
            da.readDatathroughAdapter(query, dt);
            dataGridView2.DataSource = dt;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
            da.closeConn();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {

            c = 'p';
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dt.Clear();
            dataGridView2.Refresh();
            string query = "select * from Patient";
            da.readDatathroughAdapter(query, dt);
            dataGridView2.DataSource = dt;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
            da.closeConn();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            dataGridView2.Refresh();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(c=='d')
            {
                //MessageBox.Show(dataGridView2.Rows[e.row]);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //MessageBox.Show(c.ToString());
                if (c=='d')
                {
                    int a;
                    //string s = dataGridView2.Rows[e.RowIndex].Cells["Id"].ToString();
                    string s = dt.Rows[e.RowIndex]["Id"].ToString();
                    bool result = Int32.TryParse(s, out a);
                    string st = "Delete from Doctor where Id="+a+";";
                    da.Execute(st);

                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    dt.Clear();
                    string query = "select * from Doctor";
                    da.readDatathroughAdapter(query, dt);
                    dataGridView2.DataSource = dt;
                    DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                    btn.HeaderText = "";
                    btn.Name = "yesbtn";
                    btn.Text = "Delete";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView2.Columns.Add(btn);
                    da.closeConn();
                }
                else if(c=='p')
                {
                    int a;
                    string s = dt.Rows[e.RowIndex]["Id"].ToString();
                    bool result = Int32.TryParse(s, out a);
                    string st = "Delete from Patient where Id=" + a + ";";
                    da.Execute(st);
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    dt.Clear();
                    string query = "select * from Patient";
                    da.readDatathroughAdapter(query, dt);
                    dataGridView2.DataSource = dt;
                    DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                    btn.HeaderText = "";
                    btn.Name = "yesbtn";
                    btn.Text = "Delete";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView2.Columns.Add(btn);
                    da.closeConn();
                }
            }
        }
    }
}
