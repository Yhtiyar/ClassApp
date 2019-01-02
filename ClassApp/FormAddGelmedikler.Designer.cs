namespace ClassApp
{
    partial class FormAddGelmedikler
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
            this.lbsStudents = new System.Windows.Forms.CheckedListBox();
            this.Dtime = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsStudents
            // 
            this.lbsStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbsStudents.FormattingEnabled = true;
            this.lbsStudents.Location = new System.Drawing.Point(22, 10);
            this.lbsStudents.Name = "lbsStudents";
            this.lbsStudents.Size = new System.Drawing.Size(301, 316);
            this.lbsStudents.TabIndex = 0;
            this.lbsStudents.SelectedIndexChanged += new System.EventHandler(this.lbsStudents_SelectedIndexChanged);
            // 
            // Dtime
            // 
            this.Dtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtime.Location = new System.Drawing.Point(390, 12);
            this.Dtime.Name = "Dtime";
            this.Dtime.Size = new System.Drawing.Size(276, 29);
            this.Dtime.TabIndex = 1;
            this.Dtime.Value = new System.DateTime(2017, 1, 9, 13, 51, 47, 0);
            this.Dtime.ValueChanged += new System.EventHandler(this.Dtime_ValueChanged);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(390, 257);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(276, 72);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Ok";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FormAddGelmedikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 341);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.Dtime);
            this.Controls.Add(this.lbsStudents);
            this.Name = "FormAddGelmedikler";
            this.Text = "FormAddGelmedikler";
            this.Load += new System.EventHandler(this.FormAddGelmedikler_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAddGelmedikler_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbsStudents;
        private System.Windows.Forms.DateTimePicker Dtime;
        private System.Windows.Forms.Button btSave;
    }
}