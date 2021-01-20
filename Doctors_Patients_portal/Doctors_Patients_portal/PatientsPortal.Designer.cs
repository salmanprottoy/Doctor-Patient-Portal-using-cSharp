namespace Doctors_Patients_portal
{
    partial class PatientsPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.plogoutbtn = new System.Windows.Forms.Button();
            this.prequestbtn = new System.Windows.Forms.Button();
            this.phomebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notificationbtn = new System.Windows.Forms.Button();
            this.takeappoin1 = new Doctors_Patients_portal.TakeAppoinment();
            this.phome1 = new Doctors_Patients_portal.PHome();
            this.notificationsform1 = new Doctors_Patients_portal.Notification();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.notificationbtn);
            this.panel1.Controls.Add(this.plogoutbtn);
            this.panel1.Controls.Add(this.prequestbtn);
            this.panel1.Controls.Add(this.phomebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 478);
            this.panel1.TabIndex = 0;
            // 
            // plogoutbtn
            // 
            this.plogoutbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.plogoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plogoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plogoutbtn.Location = new System.Drawing.Point(0, 188);
            this.plogoutbtn.Margin = new System.Windows.Forms.Padding(0);
            this.plogoutbtn.Name = "plogoutbtn";
            this.plogoutbtn.Size = new System.Drawing.Size(213, 68);
            this.plogoutbtn.TabIndex = 2;
            this.plogoutbtn.Text = "Logout";
            this.plogoutbtn.UseVisualStyleBackColor = false;
            this.plogoutbtn.Click += new System.EventHandler(this.plogoutbtn_Click);
            // 
            // prequestbtn
            // 
            this.prequestbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prequestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prequestbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prequestbtn.Location = new System.Drawing.Point(0, 61);
            this.prequestbtn.Margin = new System.Windows.Forms.Padding(0);
            this.prequestbtn.Name = "prequestbtn";
            this.prequestbtn.Size = new System.Drawing.Size(213, 68);
            this.prequestbtn.TabIndex = 2;
            this.prequestbtn.Text = "Take appointments";
            this.prequestbtn.UseVisualStyleBackColor = false;
            this.prequestbtn.Click += new System.EventHandler(this.prequestbtn_Click);
            // 
            // phomebtn
            // 
            this.phomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.phomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phomebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phomebtn.Location = new System.Drawing.Point(0, 0);
            this.phomebtn.Name = "phomebtn";
            this.phomebtn.Size = new System.Drawing.Size(213, 68);
            this.phomebtn.TabIndex = 1;
            this.phomebtn.Text = "Home";
            this.phomebtn.UseVisualStyleBackColor = false;
            this.phomebtn.Click += new System.EventHandler(this.phomebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notificationsform1);
            this.panel2.Controls.Add(this.takeappoin1);
            this.panel2.Controls.Add(this.phome1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 478);
            this.panel2.TabIndex = 1;
            // 
            // notificationbtn
            // 
            this.notificationbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.notificationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationbtn.Location = new System.Drawing.Point(0, 129);
            this.notificationbtn.Margin = new System.Windows.Forms.Padding(0);
            this.notificationbtn.Name = "notificationbtn";
            this.notificationbtn.Size = new System.Drawing.Size(213, 68);
            this.notificationbtn.TabIndex = 3;
            this.notificationbtn.Text = "Notifications";
            this.notificationbtn.UseVisualStyleBackColor = false;
            this.notificationbtn.Click += new System.EventHandler(this.notificationbtn_Click);
            // 
            // takeappoin1
            // 
            this.takeappoin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takeappoin1.Location = new System.Drawing.Point(0, 0);
            this.takeappoin1.Name = "takeappoin1";
            this.takeappoin1.Size = new System.Drawing.Size(730, 478);
            this.takeappoin1.TabIndex = 1;
            this.takeappoin1.Load += new System.EventHandler(this.takeappoin1_Load);
            // 
            // phome1
            // 
            this.phome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phome1.Location = new System.Drawing.Point(0, 0);
            this.phome1.Name = "phome1";
            this.phome1.Size = new System.Drawing.Size(730, 478);
            this.phome1.TabIndex = 0;
            this.phome1.Load += new System.EventHandler(this.phome1_Load);
            // 
            // notificationsform1
            // 
            this.notificationsform1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsform1.Location = new System.Drawing.Point(0, 0);
            this.notificationsform1.Name = "notificationsform1";
            this.notificationsform1.Size = new System.Drawing.Size(730, 478);
            this.notificationsform1.TabIndex = 2;
            // 
            // patientportal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "patientportal";
            this.Text = "welcome";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button plogoutbtn;
        private System.Windows.Forms.Button prequestbtn;
        private System.Windows.Forms.Button phomebtn;
        private System.Windows.Forms.Panel panel2;
        private PHome phome1;
        private TakeAppoinment takeappoin1;
        private System.Windows.Forms.Button notificationbtn;
        private Notification notificationsform1;
    }
}