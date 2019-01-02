using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClassApp
{
    public partial class FormStudentInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dt_student=new DataTable();

        public FormStudentInfo()
        {
            InitializeComponent();
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            zapolnitTable();
            zapolnitGridView();
        }


        public  void zapolnitTable()
        {
            dt_student = new DataTable();
            string seltex = "Select student_id,student_number,student_surname, student_name, student_is_man FROM studentInfo order by student_surname";
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            try
            {
                adap.Fill(dt_student);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            int i = 1;
            foreach(DataRow drow in dt_student.Rows)
            {
                drow["student_number"] = i;
                i++;
            }
        }


      public   void zapolnitGridView()
        {
            dGVstudent.DataSource = dt_student;
           dGVstudent.Columns[0].Visible = false;
            dGVstudent.Columns[1].HeaderText = "t/b";
            dGVstudent.Columns[1].Width = 20;
            dGVstudent.Columns[2].HeaderText = "Familiýasy";
            dGVstudent.Columns[2].Width = 200;
            dGVstudent.Columns[3].HeaderText = "Ady";
            dGVstudent.Columns[3].Width = 200;
            dGVstudent.Columns[4].HeaderText = "Oglan/Gyz";
            dGVstudent.Columns[4].Width = 165;
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formaddstudent = new FormAddStudent();
            formaddstudent.ShowDialog();
            dt_student = new DataTable();
            zapolnitTable();
            zapolnitGridView();
        }

        private void dGVstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btProsmotr_Click(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(dGVstudent.SelectedRows[0].Cells["student_id"].Value);
            FormAddStudent formaddstudent = new FormAddStudent(studId);
            formaddstudent.ShowDialog();
            zapolnitTable();
            zapolnitGridView();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string deltex="DELETE FROM studentInfo WHERE student_id="+ Convert.ToInt32(dGVstudent.SelectedRows[0].Cells["student_id"].Value);
            
            SqlCommand com = new SqlCommand(deltex, conn);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                 deltex = "DELETE FROM gelmediklerInfo WHERE student_id=" + Convert.ToInt32(dGVstudent.SelectedRows[0].Cells["student_id"].Value);
                com.CommandText = deltex;
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch( Exception ex)
            {
              
                MessageBox.Show(ex.ToString());
                return;
            }
            zapolnitTable();
            zapolnitGridView();
            MessageBox.Show("Informasiýa öçürildi");

        }
    }
}
