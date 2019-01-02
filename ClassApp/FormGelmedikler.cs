using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp
{
    public partial class FormGelmedikler : Form
    { 
        SqlConnection  conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dtable = new DataTable();

        public FormGelmedikler()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
        }

     
        private void btBelle_Click(object sender, EventArgs e)
        {
            DataTable dtable = new DataTable();
            DateTime dtime = new DateTime();
            dtime = dateTimePicker1.Value;
            string seltex = "SELECT g_date FROM gelmediklerInfo where g_date='" + dtime+"'";
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            try
            {
                adap.Fill(dtable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (dtable.Rows.Count == 0)
            {
                FormAddGelmedikler formaddgelmedikler = new FormAddGelmedikler();
                formaddgelmedikler.ShowDialog();
            }
            else
            {
                MessageBox.Show("Siz şu gün  gelmedikleri bellediňiz.");
                return;
            }
            zapolnitData();
            zapolnitGrid();
        }
        private void btGor_Click(object sender, EventArgs e)
        {
            DateTime dtime = new DateTime();
            dtime = dateTimePicker2.Value;
            FormGelmedikleriGor formgelmediklerigor = new FormGelmedikleriGor(dtime);
            formgelmediklerigor.ShowDialog();

        }

        void zapolnitData()
        {
            dtable = new DataTable();
            string selText = " SELECT student_surname+' '+student_name as ady, SUM(counter) as gm FROM (Select * , 1 as counter FROM viewGelmedikler) as t" +
            " group by student_surname + ' ' + student_name  ";
            SqlDataAdapter adap = new SqlDataAdapter(selText, conn);
            try
            {
                adap.Fill(dtable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void zapolnitGrid()
        {
            dGview.DataSource = dtable;
            dGview.Columns[0].HeaderText = "Ady";
            dGview.Columns[0].Width = 221;
            dGview.Columns[1].HeaderText = "Gelmedik günleriniň sany";
            dGview.Columns[1].Width = 221;
        }







        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormGelmedikler_Load(object sender, EventArgs e)
        {
            zapolnitData();
            zapolnitGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btGor.Focus();

            }
        }
    }
}

