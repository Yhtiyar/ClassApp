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
    public partial class CareklikBelle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dtstudent = new DataTable();
        int caryek;
        int studentid;
        bool isnew;
        public CareklikBelle(int fx_caryek, int fx_id, bool fx_bool)
        {
            InitializeComponent();
            caryek = fx_caryek;
            studentid = fx_id;
            isnew = fx_bool;
            zapolnitName();
            labelCaryek.Text = fx_caryek.ToString() + "Çärýek";

        }
        
        private void labelCaryek_Click(object sender, EventArgs e)
        {

        }
       
            
        
        void zapolnitName()
        {
            string seltex = "SELECT student_name,student_surname FROM studentInfo where student_id=" + studentid;
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            try
            {
                adap.Fill(dtstudent);
            }
            catch (Exception e)
            {
                MessageBox.Show("error"+e.ToString());
            }
            DataRow drow = dtstudent.Rows[0];
            labelName.Text = drow["student_surname"].ToString() + " " + drow["student_name"].ToString();
           
            tbox3.Text = 0.ToString();
            tbox4.Text = 0.ToString();
            tbox5.Text = 0.ToString();
            string selText="";
            if (!isnew)
            {
                if (caryek == 1)
                    selText = "Select student_1_caryeklik_3, student_1_caryeklik_4, student_1_caryeklik_5 FROM studentInfo where student_id=" + studentid;
                if (caryek == 2)
                    selText = "Select student_2_caryeklik_3, student_2_caryeklik_4, student_2_caryeklik_5 FROM studentInfo where student_id=" + studentid;
                if (caryek == 3)
                    selText = "Select student_3_caryeklik_3, student_3_caryeklik_4, student_3_caryeklik_5 FROM studentInfo where student_id=" + studentid;
                if (caryek == 4)
                    selText = "Select student_4_caryeklik_3, student_4_caryeklik_4, student_4_caryeklik_5 FROM studentInfo where student_id=" + studentid;
                SqlDataAdapter adp = new SqlDataAdapter(selText, conn);
                DataTable d_table = new DataTable();
                    try
                {
                    adap.Fill(d_table);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

            }
        }

        private void CareklikBelle_Load(object sender, EventArgs e)
        {
            
        }
        string zaopolnittext()

        {
            string s="";
            if (caryek==1)
            {
                s = "UPDATE  studentInfo SET student_1_caryeklik_3=" + Convert.ToInt32(tbox3.Text) + ", student_1_caryeklik_4=" + Convert.ToInt32(tbox4.Text) + ", student_1_caryeklik_5=" + Convert.ToInt32(tbox5.Text) + " WHERE student_id=" + studentid ;
            }
            if (caryek == 2)
            {
                s = "UPDATE  studentInfo SET student_2_caryeklik_3=" + Convert.ToInt32(tbox3.Text) + ", student_2_caryeklik_4=" + Convert.ToInt32(tbox4.Text) + ", student_2_caryeklik_5=" + Convert.ToInt32(tbox5.Text) + " WHERE student_id=" + studentid;
            }
            if (caryek == 3)
            {
                s = "UPDATE  studentInfo SET student_3_caryeklik_3=" + Convert.ToInt32(tbox3.Text) + ", student_3_caryeklik_4=" + Convert.ToInt32(tbox4.Text) + ", student_3_caryeklik_5=" + Convert.ToInt32(tbox5.Text) + " WHERE student_id=" + studentid;
            }
            if (caryek == 4)
            {
                s = "UPDATE  studentInfo SET student_4_caryeklik_3=" + Convert.ToInt32(tbox3.Text) + ", student_4_caryeklik_4=" + Convert.ToInt32(tbox4.Text) + ", student_4_caryeklik_5=" + Convert.ToInt32(tbox5.Text) + " WHERE student_id=" + studentid;
            }

            return s;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string ins_com = zaopolnittext(); 
            SqlCommand com = new SqlCommand(ins_com, conn);
            
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception b)
            {
                conn.Close();
                MessageBox.Show(b.ToString());
            }
            this.Close();
        }
    }
}
