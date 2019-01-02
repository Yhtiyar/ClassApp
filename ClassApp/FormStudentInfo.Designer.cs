namespace ClassApp
{
    partial class FormStudentInfo
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
            this.dGVstudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btProsmotr = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVstudent
            // 
            this.dGVstudent.AllowUserToAddRows = false;
            this.dGVstudent.AllowUserToDeleteRows = false;
            this.dGVstudent.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dGVstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVstudent.Location = new System.Drawing.Point(-1, 56);
            this.dGVstudent.MultiSelect = false;
            this.dGVstudent.Name = "dGVstudent";
            this.dGVstudent.ReadOnly = true;
            this.dGVstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVstudent.Size = new System.Drawing.Size(575, 649);
            this.dGVstudent.TabIndex = 0;
            this.dGVstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVstudent_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okuwçylar";
            // 
            // btAddStudent
            // 
            this.btAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddStudent.Location = new System.Drawing.Point(239, 8);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(129, 45);
            this.btAddStudent.TabIndex = 2;
            this.btAddStudent.Text = "Täze okuwçy ";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // btProsmotr
            // 
            this.btProsmotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btProsmotr.Location = new System.Drawing.Point(374, 8);
            this.btProsmotr.Name = "btProsmotr";
            this.btProsmotr.Size = new System.Drawing.Size(129, 45);
            this.btProsmotr.TabIndex = 2;
            this.btProsmotr.Text = "Prosmotr";
            this.btProsmotr.UseVisualStyleBackColor = true;
            this.btProsmotr.Click += new System.EventHandler(this.btProsmotr_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDelete.Location = new System.Drawing.Point(520, 8);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(54, 45);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "X";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 707);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btProsmotr);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVstudent);
            this.Name = "FormStudentInfo";
            this.Text = "FormStudentInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btProsmotr;
        private System.Windows.Forms.Button btDelete;
    }
}