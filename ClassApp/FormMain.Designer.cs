namespace ClassApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGelmediler = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCareklik = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGelmediler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCareklik)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStudent
            // 
            this.pbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStudent.Image = ((System.Drawing.Image)(resources.GetObject("pbStudent.Image")));
            this.pbStudent.Location = new System.Drawing.Point(143, -10);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(256, 256);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStudent.TabIndex = 0;
            this.pbStudent.TabStop = false;
            this.pbStudent.Click += new System.EventHandler(this.pbStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okuwçylar";
            // 
            // pbGelmediler
            // 
            this.pbGelmediler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGelmediler.Image = ((System.Drawing.Image)(resources.GetObject("pbGelmediler.Image")));
            this.pbGelmediler.Location = new System.Drawing.Point(143, 359);
            this.pbGelmediler.Name = "pbGelmediler";
            this.pbGelmediler.Size = new System.Drawing.Size(256, 256);
            this.pbGelmediler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGelmediler.TabIndex = 0;
            this.pbGelmediler.TabStop = false;
            this.pbGelmediler.Click += new System.EventHandler(this.pbGelmediler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gelmedikler";
            // 
            // pbCareklik
            // 
            this.pbCareklik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCareklik.Image = ((System.Drawing.Image)(resources.GetObject("pbCareklik.Image")));
            this.pbCareklik.Location = new System.Drawing.Point(852, 12);
            this.pbCareklik.Name = "pbCareklik";
            this.pbCareklik.Size = new System.Drawing.Size(256, 256);
            this.pbCareklik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCareklik.TabIndex = 0;
            this.pbCareklik.TabStop = false;
            this.pbCareklik.Click += new System.EventHandler(this.pbCareklik_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(834, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çäreklik bahalar";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGelmediler);
            this.Controls.Add(this.pbCareklik);
            this.Controls.Add(this.pbStudent);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGelmediler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCareklik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGelmediler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCareklik;
        private System.Windows.Forms.Label label3;
    }
}