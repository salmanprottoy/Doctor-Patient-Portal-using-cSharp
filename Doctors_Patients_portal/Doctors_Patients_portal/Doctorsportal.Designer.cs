namespace Doctors_Patients_portal
{
    partial class DoctorsPortal
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
            this.docpanel = new System.Windows.Forms.Panel();
            this.dlogoutbtn = new System.Windows.Forms.Button();
            this.drequestbtn = new System.Windows.Forms.Button();
            this.dhomebtn = new System.Windows.Forms.Button();
            this.drequests1 = new Doctors_Patients_portal.DRequest();
            this.dhome1 = new Doctors_Patients_portal.DHome();
            this.docpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // docpanel
            // 
            this.docpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.docpanel.Controls.Add(this.dlogoutbtn);
            this.docpanel.Controls.Add(this.drequestbtn);
            this.docpanel.Controls.Add(this.dhomebtn);
            this.docpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.docpanel.Location = new System.Drawing.Point(0, 0);
            this.docpanel.Name = "docpanel";
            this.docpanel.Size = new System.Drawing.Size(213, 450);
            this.docpanel.TabIndex = 1;
            // 
            // dlogoutbtn
            // 
            this.dlogoutbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.dlogoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlogoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlogoutbtn.Location = new System.Drawing.Point(0, 129);
            this.dlogoutbtn.Margin = new System.Windows.Forms.Padding(0);
            this.dlogoutbtn.Name = "dlogoutbtn";
            this.dlogoutbtn.Size = new System.Drawing.Size(213, 68);
            this.dlogoutbtn.TabIndex = 2;
            this.dlogoutbtn.Text = "Logout";
            this.dlogoutbtn.UseVisualStyleBackColor = false;
            this.dlogoutbtn.Click += new System.EventHandler(this.dlogoutbtn_Click);
            // 
            // drequestbtn
            // 
            this.drequestbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drequestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drequestbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drequestbtn.Location = new System.Drawing.Point(0, 61);
            this.drequestbtn.Margin = new System.Windows.Forms.Padding(0);
            this.drequestbtn.Name = "drequestbtn";
            this.drequestbtn.Size = new System.Drawing.Size(213, 68);
            this.drequestbtn.TabIndex = 2;
            this.drequestbtn.Text = "Requests";
            this.drequestbtn.UseVisualStyleBackColor = false;
            this.drequestbtn.Click += new System.EventHandler(this.drequestbtn_Click);
            // 
            // dhomebtn
            // 
            this.dhomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dhomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dhomebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhomebtn.Location = new System.Drawing.Point(0, 0);
            this.dhomebtn.Name = "dhomebtn";
            this.dhomebtn.Size = new System.Drawing.Size(213, 68);
            this.dhomebtn.TabIndex = 1;
            this.dhomebtn.Text = "Home";
            this.dhomebtn.UseVisualStyleBackColor = false;
            this.dhomebtn.Click += new System.EventHandler(this.dhomebtn_Click);
            // 
            // drequests1
            // 
            this.drequests1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drequests1.Location = new System.Drawing.Point(213, 0);
            this.drequests1.Name = "drequests1";
            this.drequests1.Size = new System.Drawing.Size(587, 450);
            this.drequests1.TabIndex = 3;
            this.drequests1.Load += new System.EventHandler(this.drequests1_Load);
            // 
            // dhome1
            // 
            this.dhome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dhome1.Location = new System.Drawing.Point(213, 0);
            this.dhome1.Name = "dhome1";
            this.dhome1.Size = new System.Drawing.Size(587, 450);
            this.dhome1.TabIndex = 2;
            this.dhome1.Load += new System.EventHandler(this.dhome1_Load);
            // 
            // Doctorsportal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drequests1);
            this.Controls.Add(this.dhome1);
            this.Controls.Add(this.docpanel);
            this.Name = "Doctorsportal";
            this.Text = "Doctorsportal";
            this.docpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel docpanel;
        private System.Windows.Forms.Button dlogoutbtn;
        private System.Windows.Forms.Button drequestbtn;
        private System.Windows.Forms.Button dhomebtn;
        private DHome dhome1;
        private DRequest drequests1;
    }
}