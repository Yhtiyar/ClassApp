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
    public partial class FormAddGelmedikler : Form
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        SqlConnection conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dt_student = new DataTable();
        DateTime time = new DateTime();
        public FormAddGelmedikler()
        {
            InitializeComponent();
        }

        private void FormAddGelmedikler_Load(object sender, EventArgs e)
        {
           
            string seltex = "SELECT student_id, student_surname,student_name from studentInfo order by student_surname";
            time = Dtime.Value;
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            int i = 0;
            try
            {
                adap.Fill(dt_student);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (DataRow drow in dt_student.Rows)
            {
                lbsStudents.Items.Add(drow["student_surname"]+" "+drow["student_name"].ToString());
                dict[i] = Convert.ToInt32(drow["student_id"]);
                i++;
            }
 
         
            
        }

        private void Dtime_ValueChanged(object sender, EventArgs e)
        {
            if (Dtime.Value!=time)
            { MessageBox.Show("You can't change value!");
                Dtime.Value = time;
                return; }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var a = lbsStudents.CheckedIndices;
            conn.Open();
            
            for (int i = 0; i < a.Count; i++) 
            {
                string insertText = "INSERT INTO gelmediklerInfo (student_id, g_date) VALUES (" + dict[a[i]] + ", '" + Dtime.Value + "') ";
                SqlCommand ins_com = new SqlCommand(insertText, conn);
                try
                {
                    ins_com.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();
            DialogResult = DialogResult.OK;
        }

        private void lbsStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormAddGelmedikler_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(Convert.ToString((char)e.KeyChar));
            if (e.KeyChar==(char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}


