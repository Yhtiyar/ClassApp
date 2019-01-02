namespace ClassApp
{
    partial class FormEditCareklik
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
            this.DGview = new System.Windows.Forms.DataGridView();
            this.btBelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).BeginInit();
            this.SuspendLayout();
            // 
            // DGview
            // 
            this.DGview.AllowUserToAddRows = false;
            this.DGview.AllowUserToDeleteRows = false;
            this.DGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGview.Location = new System.Drawing.Point(1, 77);
            this.DGview.Name = "DGview";
            this.DGview.ReadOnly = true;
            this.DGview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGview.Size = new System.Drawing.Size(540, 674);
            this.DGview.TabIndex = 0;
            // 
            // btBelle
            // 
            this.btBelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBelle.Location = new System.Drawing.Point(1, 0);
            this.btBelle.Name = "btBelle";
            this.btBelle.Size = new System.Drawing.Size(176, 78);
            this.btBelle.TabIndex = 1;
            this.btBelle.Text = "Bahalary belle";
            this.btBelle.UseVisualStyleBackColor = true;
            this.btBelle.Click += new System.EventHandler(this.btBelle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(183, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bahalary üýtget";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(570, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FormEditCareklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBelle);
            this.Controls.Add(this.DGview);
            this.Name = "FormEditCareklik";
            this.Text = "FormEditCareklik";
            this.Load += new System.EventHandler(this.FormEditCareklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGview;
        private System.Windows.Forms.Button btBelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}