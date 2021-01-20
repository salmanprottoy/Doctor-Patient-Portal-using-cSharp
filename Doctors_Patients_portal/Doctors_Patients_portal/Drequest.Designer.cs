namespace Doctors_Patients_portal
{
    partial class DRequest
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
            this.dataGridViewdoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdoc
            // 
            this.dataGridViewdoc.AllowUserToAddRows = false;
            this.dataGridViewdoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewdoc.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewdoc.Name = "dataGridViewdoc";
            this.dataGridViewdoc.Size = new System.Drawing.Size(734, 399);
            this.dataGridViewdoc.TabIndex = 0;
            this.dataGridViewdoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdoc_CellClick);
            // 
            // drequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewdoc);
            this.Name = "drequests";
            this.Size = new System.Drawing.Size(734, 399);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdoc;
    }
}
