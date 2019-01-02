using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            string _n = Environment.MachineName;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pbStudent_Click(object sender, EventArgs e)
        {
            FormStudentInfo formstudentinfo = new FormStudentInfo();
            formstudentinfo.ShowDialog();

        }

        private void pbGelmediler_Click(object sender, EventArgs e)
        {
            FormGelmedikler formgelmedikler = new FormGelmedikler();
            formgelmedikler.ShowDialog();
        }

        private void pbCareklik_Click(object sender, EventArgs e)
        {
            FormCareklik formcareklik = new FormCareklik();
            formcareklik.ShowDialog();

        }
    }
}
