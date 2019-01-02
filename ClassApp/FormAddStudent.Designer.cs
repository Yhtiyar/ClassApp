namespace ClassApp
{
    partial class FormAddStudent
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
            this.tbStudentSurname = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStudentSurname
            // 
            this.tbStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStudentSurname.Location = new System.Drawing.Point(28, 29);
            this.tbStudentSurname.Name = "tbStudentSurname";
            this.tbStudentSurname.Size = new System.Drawing.Size(181, 38);
            this.tbStudentSurname.TabIndex = 1;
            this.tbStudentSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentSurname_KeyPress);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(182, 92);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(143, 64);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Ok";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbStudentName
            // 
            this.tbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStudentName.Location = new System.Drawing.Point(295, 29);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(192, 38);
            this.tbStudentName.TabIndex = 2;
            this.tbStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ady";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familiýasy";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbStudentSurname);
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAddStudent_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudentSurname;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}