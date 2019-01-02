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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void btStart_Click(object sender, EventArgs e)
        {
          //  if ((tbLogin.Text=="Mugallym" || tbLogin.Text=="mugallym") && (tbPassword.Text=="mugallym123" ) )
          //  {
                ////
                FormMain formmain = new FormMain();
                this.Hide();
                formmain.ShowDialog();
               
                this.Close();
          //  }
           // else
          //  {
          //      MessageBox.Show("Login ýa-da Parolda ýalňyşlyk bar, täzeden ýazyp görüň");
           //     tbPassword.Text = "";
         //   }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
