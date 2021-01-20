namespace Doctors_Patients_portal
{
    partial class Notification
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
            this.dataGridViewn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewn
            // 
            this.dataGridViewn.AllowUserToAddRows = false;
            this.dataGridViewn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewn.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewn.Name = "dataGridViewn";
            this.dataGridViewn.Size = new System.Drawing.Size(651, 397);
            this.dataGridViewn.TabIndex = 0;
            // 
            // notificationsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewn);
            this.Name = "notificationsform";
            this.Size = new System.Drawing.Size(651, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewn;
    }
}
