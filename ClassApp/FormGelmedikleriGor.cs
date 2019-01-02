using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp
{
    public partial class FormGelmedikleriGor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DateTime Dtime = new DateTime();
        DataTable Dtable = new DataTable();
        public FormGelmedikleriGor(DateTime dTime)
        {
            InitializeComponent();
            Dtime = dTime;
        }

        private void FormGelmedikleriGor_Load(object sender, EventArgs e)
        {
            zapolnitTable();
            zapolnitListBox();
        }
        void zapolnitTable()
        {
            string seltex = "SELECT student_id, student_surname, student_name FROM viewGelmedikler WHERE g_date='" + Dtime + "'";
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            try
            {
                adap.Fill(Dtable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        void zapolnitListBox()
        {
            foreach( DataRow drow in Dtable.Rows)
            {
                listBox.Items.Add(drow["student_surname"].ToString() + " " + drow["student_name"].ToString()); 
            }
        }
    }
}
