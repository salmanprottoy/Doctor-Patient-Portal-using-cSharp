using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_Patients_portal
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        protected string name, add, username, pass, cpass, special,hospital1,hos1time,hospital2,hos2time;
        SortedDictionary<string, int> m = new SortedDictionary<string, int>();
        SortedDictionary<string, int> t = new SortedDictionary<string, int>();
        private void regiusertext_TextChanged(object sender, EventArgs e)
        {
            if (regiusertext.Text == "")
            {
                username = null;
                usernameinvalid.Visible = true;
            }
            else
            {
                username = regiusertext.Text;
                usernameinvalid.Visible = false;
            }
        }

        private void regipasstext_TextChanged(object sender, EventArgs e)
        {
            if (regipasstext.Text == "")
            {
                pass =null;
                passinvalid.Visible = true;
            }
            else
            {
                pass = regipasstext.Text;
                passinvalid.Visible = false;
            }
        }

        private void regiconpasstext_TextChanged(object sender, EventArgs e)
        {
            if (regiconpasstext.Text == "")
            {
                cpass = null;
                cpassinvalid.Visible = true;
            }
            else
            {
                cpass = regiconpasstext.Text;
                cpassinvalid.Visible = false;
            }
        }

        private void hos1combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = hos1combo.Text;
            if (m.ContainsKey(temp) == true)
            {
                MessageBox.Show("Already choosen");
                hos1combo.Text = hospital1; 
                
            }
            else
            {
                if (hospital1 != null) m.Remove(hospital1);
                hospital1 = temp;
                m.Add(hospital1, 1);
            }

        }

        private void hos2combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string temp = hos2combo.Text;
            if (m.ContainsKey(temp) == true)
            {
                MessageBox.Show("Already choosen");
                hos2combo.Text = hospital2; ;
                
            }
            else
            {
                if (hospital2 != null) m.Remove(hospital2);
                hospital2 = temp;
                m.Add(hospital2, 1);
            }
        }

        private void hos2slot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = hos2slot.Text;
            if (t.ContainsKey(temp) == true)
            {
                MessageBox.Show("Time clashed");
                hos2slot.Text = hos2time;

            }
            else
            {
                if (hos2time != null) t.Remove(hos2time);
                hos2time = temp;
                t.Add(hos2time, 1);
            }

        }

        private void specialtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specialtxt.Text == "")
            {
                special = null;
                specialinvalid.Visible = true;
            }
            else
            {
                special = specialtxt.Text;
                specialinvalid.Visible = false;
            }
        }

        private void specialtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void hos1slot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = hos1slot.Text;
            if (t.ContainsKey(temp) == true)
            {
                MessageBox.Show("Time clashed");
                hos1slot.Text = hos1time;

            }
            else
            {
                if (hos1time != null) t.Remove(hos1time);
                hos1time = temp;
                t.Add(hos1time, 1);
            }
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if(radioButtondoc.Checked)
            {
                string st;
                int flag = 0,noentry=0,id;
    
               if(name != null && add != null && pass != null && cpass != null && username != null && special!=null && ((hospital1!=null && hos1time!=null) || (hospital2!=null && hos2time!=null)))
                {
                    st = "select * from Doctor where Name='" + name + "' and Address ='" + add + "';";
                    DataTable dd = db.Data(st);
                    if (dd.Rows.Count!=1)
                    {
                        st = "INSERT INTO Doctor(Name,Address,User_Name,Password,Specialist) VALUES ('" + name + "','" + add + "','" + username + "','" + pass + "','" + special + "');";
                        db.Execute(st);
                        st = "select * from Doctor where Name='" + name + "' and Address ='" + add + "';";
                        dd = db.Data(st);
                        int a;
                        string s = dd.Rows[0]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        id = a;

                    }
                    else
                    {

                        int a;
                        string s = dd.Rows[0]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        id = a;
                    }
                    if (hospital1!=null && hos1time!=null && noentry==0)
                    {
                        hospital1= hospital1.Replace(' ', '_');
                        flag = 1;
                        noentry = 0;
                    }
                    else if((hospital1!=null && hos1time==null) || (hospital1==null && hos1time!=null))
                    {
                        noentry = 1;
                    }
                    if(hospital2!=null && hos2time!=null && noentry==0)
                    {
                        hospital2 = hospital2.Replace(' ', '_');
                    
                        flag = 1;
                        noentry = 0;
                    }
                    else if ((hospital2 != null && hos2time == null) || (hospital2 == null && hos2time != null))
                    {
                        noentry = 1;
                    }
                    if(flag==0)
                    {
                        MessageBox.Show("You haven't chosen any hospital!! ");
                    }
                    else if(noentry==1)
                    {
                        MessageBox.Show("You missed something!!");
                    }
                    else
                    {
                        if(hospital1!=null)
                        {
                            st = "INSERT INTO " + hospital1 + "(Id,Name,Address,Specialist,Slot) VALUES ( '" + id + "','" + name + "','" + add + "','" + special + "','" + hos1time + "');";
                            db.Execute(st);
                        }
                        if(hospital2!=null)
                        {
                            st = "INSERT INTO " + hospital2 + "(Id,Name,Address,Specialist,Slot) VALUES ( '" + id + "','" + name + "','" + add + "','" + special + "','" + hos2time + "');";
                            db.Execute(st);
                        }

                        //doctor's portal
                        st = "select * from Doctor where User_name='" + username + "' and Password='" + pass + "';";
                        DataTable dt = db.Data(st);
                        DHome.dd = dt;
                        DoctorsPortal p = new DoctorsPortal();
                        this.Hide();
                        p.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Maybe you left some fields blank!!");
                }
            }
            else if ( radioButtonpatient.Checked || adminradiobtn.Checked)
            {
                if(name!=null && add!=null && pass!=null && cpass!=null && username!=null )
                {
                    if(pass==cpass)
                    {
                        string st;
                        if(radioButtonpatient.Checked)  st = "INSERT INTO patient(Name,Address,User_name,Password) VALUES ('" + name + "','" + add + "','" + username + "','" + pass + "');";
                        else st = "INSERT INTO Admin(Name,Address,User_name,Password) VALUES ('" + name + "','" + add + "','" + username + "','" + pass + "');";
                        db.Execute(st);
                        if(radioButtonpatient.Checked)
                        {
                            st = "select * from Patient where User_name='" + username + "' and Password='" + pass + "';";
                            DataTable dt = db.Data(st);
                            PHome.ds = dt;
                            PatientsPortal p = new PatientsPortal();
                            this.Hide();
                            p.Show();
                        }
                        else
                        {
                            admin a = new admin();
                            this.Hide();
                            a.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password doesnt match!!");
                    }
                }
                else
                {
                    MessageBox.Show("Maybe you left some fields blank!!");
                }

            }
            else
            {
                MessageBox.Show("Let us know whether you're a doctor or a patient!!");
            }
        }

        private void adminradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            specialtxt.SelectedIndex = -1;
            hos1combo.SelectedIndex = -1;
            hos1slot.SelectedIndex = -1;
            hos2combo.SelectedIndex = -1;
            hos2slot.SelectedIndex = -1;
            specialtxt.Enabled = false;
            hos1combo.Enabled = false;
            hos1slot.Enabled = false;
            hos2combo.Enabled = false;
            hos2slot.Enabled = false;
        }

        private void reginametext_TextChanged(object sender, EventArgs e)
        {
            
            if (reginametext.Text == "")
            {
                name = "";
                nameinvalid.Visible = true;
            }
            else
            {
                name = reginametext.Text;
                nameinvalid.Visible = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (regiaddresstext.Text == "")
            {
                add = "";
                addinvalid.Visible = true;
            }
            else
            {
                add = regiaddresstext.Text;
                addinvalid.Visible = false;
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void radioButtondoc_CheckedChanged(object sender, EventArgs e)
        {
            specialtxt.Enabled = true;
            hos1combo.Enabled = true;
            hos1slot.Enabled = true;
            hos2combo.Enabled = true;
            hos2slot.Enabled = true;
        }

        private void radioButtonpatient_CheckedChanged(object sender, EventArgs e)
        {
            specialtxt.SelectedIndex=-1;
            hos1combo.SelectedIndex = -1;
            hos1slot.SelectedIndex = -1;
            hos2combo.SelectedIndex= -1;
            hos2slot.SelectedIndex = -1;
            specialtxt.Enabled = false;
            hos1combo.Enabled = false;
            hos1slot.Enabled = false;
            hos2combo.Enabled = false;
            hos2slot.Enabled = false;

        }
    }
}
