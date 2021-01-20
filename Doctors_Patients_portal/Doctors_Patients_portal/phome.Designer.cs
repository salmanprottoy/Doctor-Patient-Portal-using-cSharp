namespace Doctors_Patients_portal
{
    partial class PHome
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
            this.phomename = new System.Windows.Forms.Label();
            this.phomenamebox = new System.Windows.Forms.TextBox();
            this.paddresshbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phomename
            // 
            this.phomename.AutoSize = true;
            this.phomename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phomename.Location = new System.Drawing.Point(83, 124);
            this.phomename.Name = "phomename";
            this.phomename.Size = new System.Drawing.Size(86, 25);
            this.phomename.TabIndex = 0;
            this.phomename.Text = "Name : ";
            // 
            // phomenamebox
            // 
            this.phomenamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phomenamebox.Location = new System.Drawing.Point(160, 121);
            this.phomenamebox.Name = "phomenamebox";
            this.phomenamebox.ReadOnly = true;
            this.phomenamebox.Size = new System.Drawing.Size(328, 31);
            this.phomenamebox.TabIndex = 1;
            // 
            // paddresshbox
            // 
            this.paddresshbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddresshbox.Location = new System.Drawing.Point(160, 178);
            this.paddresshbox.Name = "paddresshbox";
            this.paddresshbox.ReadOnly = true;
            this.paddresshbox.Size = new System.Drawing.Size(328, 31);
            this.paddresshbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address : ";
            // 
            // phome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paddresshbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phomenamebox);
            this.Controls.Add(this.phomename);
            this.Name = "phome";
            this.Size = new System.Drawing.Size(637, 376);
            this.Load += new System.EventHandler(this.phome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phomename;
        private System.Windows.Forms.TextBox phomenamebox;
        private System.Windows.Forms.TextBox paddresshbox;
        private System.Windows.Forms.Label label1;
    }
}
