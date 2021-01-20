namespace Doctors_Patients_portal
{
    partial class DHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daddresshbox = new System.Windows.Forms.TextBox();
            this.daddress = new System.Windows.Forms.Label();
            this.dhomenamebox = new System.Windows.Forms.TextBox();
            this.dhomename = new System.Windows.Forms.Label();
            this.dspecialbox = new System.Windows.Forms.TextBox();
            this.dspecial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daddresshbox
            // 
            this.daddresshbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daddresshbox.Location = new System.Drawing.Point(199, 179);
            this.daddresshbox.Name = "daddresshbox";
            this.daddresshbox.ReadOnly = true;
            this.daddresshbox.Size = new System.Drawing.Size(328, 31);
            this.daddresshbox.TabIndex = 7;
            // 
            // daddress
            // 
            this.daddress.AutoSize = true;
            this.daddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daddress.Location = new System.Drawing.Point(99, 179);
            this.daddress.Name = "daddress";
            this.daddress.Size = new System.Drawing.Size(109, 25);
            this.daddress.TabIndex = 6;
            this.daddress.Text = "Address : ";
            // 
            // dhomenamebox
            // 
            this.dhomenamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhomenamebox.Location = new System.Drawing.Point(199, 122);
            this.dhomenamebox.Name = "dhomenamebox";
            this.dhomenamebox.ReadOnly = true;
            this.dhomenamebox.Size = new System.Drawing.Size(328, 31);
            this.dhomenamebox.TabIndex = 5;
            // 
            // dhomename
            // 
            this.dhomename.AutoSize = true;
            this.dhomename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhomename.Location = new System.Drawing.Point(122, 125);
            this.dhomename.Name = "dhomename";
            this.dhomename.Size = new System.Drawing.Size(86, 25);
            this.dhomename.TabIndex = 4;
            this.dhomename.Text = "Name : ";
            // 
            // dspecialbox
            // 
            this.dspecialbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dspecialbox.Location = new System.Drawing.Point(199, 236);
            this.dspecialbox.Name = "dspecialbox";
            this.dspecialbox.ReadOnly = true;
            this.dspecialbox.Size = new System.Drawing.Size(328, 31);
            this.dspecialbox.TabIndex = 9;
            // 
            // dspecial
            // 
            this.dspecial.AutoSize = true;
            this.dspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dspecial.Location = new System.Drawing.Point(85, 239);
            this.dspecial.Name = "dspecial";
            this.dspecial.Size = new System.Drawing.Size(123, 25);
            this.dspecial.TabIndex = 8;
            this.dspecial.Text = "Specialist : ";
            // 
            // dhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dspecialbox);
            this.Controls.Add(this.dspecial);
            this.Controls.Add(this.daddresshbox);
            this.Controls.Add(this.daddress);
            this.Controls.Add(this.dhomenamebox);
            this.Controls.Add(this.dhomename);
            this.Name = "dhome";
            this.Size = new System.Drawing.Size(651, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daddresshbox;
        private System.Windows.Forms.Label daddress;
        private System.Windows.Forms.TextBox dhomenamebox;
        private System.Windows.Forms.Label dhomename;
        private System.Windows.Forms.TextBox dspecialbox;
        private System.Windows.Forms.Label dspecial;
    }
}
