namespace Doctors_Patients_portal
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.loginbt = new System.Windows.Forms.Button();
            this.signupbt = new System.Windows.Forms.Button();
            this.adminradiobtnlog = new System.Windows.Forms.RadioButton();
            this.radioButtonpatientlog = new System.Windows.Forms.RadioButton();
            this.radioButtondoclog = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(259, 124);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(299, 29);
            this.UserName.TabIndex = 2;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserPass
            // 
            this.UserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPass.Location = new System.Drawing.Point(259, 187);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(299, 29);
            this.UserPass.TabIndex = 3;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // loginbt
            // 
            this.loginbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginbt.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbt.Location = new System.Drawing.Point(338, 272);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(220, 61);
            this.loginbt.TabIndex = 4;
            this.loginbt.Text = "Login";
            this.loginbt.UseVisualStyleBackColor = false;
            this.loginbt.Click += new System.EventHandler(this.loginbt_Click);
            // 
            // signupbt
            // 
            this.signupbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signupbt.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbt.Location = new System.Drawing.Point(107, 272);
            this.signupbt.Name = "signupbt";
            this.signupbt.Size = new System.Drawing.Size(225, 61);
            this.signupbt.TabIndex = 5;
            this.signupbt.Text = "Sign up";
            this.signupbt.UseVisualStyleBackColor = false;
            this.signupbt.Click += new System.EventHandler(this.signupbt_Click);
            // 
            // adminradiobtnlog
            // 
            this.adminradiobtnlog.AutoSize = true;
            this.adminradiobtnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminradiobtnlog.Location = new System.Drawing.Point(442, 240);
            this.adminradiobtnlog.Name = "adminradiobtnlog";
            this.adminradiobtnlog.Size = new System.Drawing.Size(83, 28);
            this.adminradiobtnlog.TabIndex = 40;
            this.adminradiobtnlog.TabStop = true;
            this.adminradiobtnlog.Text = "Admin";
            this.adminradiobtnlog.UseVisualStyleBackColor = true;
            // 
            // radioButtonpatientlog
            // 
            this.radioButtonpatientlog.AutoSize = true;
            this.radioButtonpatientlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonpatientlog.Location = new System.Drawing.Point(352, 238);
            this.radioButtonpatientlog.Name = "radioButtonpatientlog";
            this.radioButtonpatientlog.Size = new System.Drawing.Size(84, 28);
            this.radioButtonpatientlog.TabIndex = 39;
            this.radioButtonpatientlog.TabStop = true;
            this.radioButtonpatientlog.Text = "Patient";
            this.radioButtonpatientlog.UseVisualStyleBackColor = true;
            // 
            // radioButtondoclog
            // 
            this.radioButtondoclog.AutoSize = true;
            this.radioButtondoclog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtondoclog.Location = new System.Drawing.Point(263, 238);
            this.radioButtondoclog.Name = "radioButtondoclog";
            this.radioButtondoclog.Size = new System.Drawing.Size(83, 28);
            this.radioButtondoclog.TabIndex = 38;
            this.radioButtondoclog.TabStop = true;
            this.radioButtondoclog.Text = "Doctor";
            this.radioButtondoclog.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 520);
            this.Controls.Add(this.adminradiobtnlog);
            this.Controls.Add(this.radioButtonpatientlog);
            this.Controls.Add(this.radioButtondoclog);
            this.Controls.Add(this.signupbt);
            this.Controls.Add(this.loginbt);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Button loginbt;
        private System.Windows.Forms.Button signupbt;
        private System.Windows.Forms.RadioButton adminradiobtnlog;
        private System.Windows.Forms.RadioButton radioButtonpatientlog;
        private System.Windows.Forms.RadioButton radioButtondoclog;
    }
}

