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
    public partial class FormCareklik : Form
    {
        public FormCareklik()
        {
            InitializeComponent();
        }

        private void bt4çaryek_Click(object sender, EventArgs e)
        {
            FormEditCareklik formeditcareklik = new FormEditCareklik(4);
            formeditcareklik.ShowDialog();
        }

        private void bt1çaryek_Click(object sender, EventArgs e)
        {
            FormEditCareklik formeditcareklik = new FormEditCareklik(1);
            formeditcareklik.ShowDialog();
        }

        private void bt2çaryek_Click(object sender, EventArgs e)
        {
            FormEditCareklik formeditcareklik = new FormEditCareklik(2);
            formeditcareklik.ShowDialog();
        }

        private void bt3çaryek_Click(object sender, EventArgs e)
        {
            FormEditCareklik formeditcareklik = new FormEditCareklik(3);
            formeditcareklik.ShowDialog();
        }

        private void FormCareklik_Load(object sender, EventArgs e)
        {

        }
    }
}
