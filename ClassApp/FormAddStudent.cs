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

    public partial class FormAddStudent : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source="+Environment.MachineName+@"\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dtable = new DataTable();
        bool isnew;
        int studentId;
        string isman;
        public FormAddStudent()
        {
            InitializeComponent();
            isnew = true;
        } 
        public FormAddStudent(int fx_id)
        {
            InitializeComponent();
            studentId = fx_id;
            isnew = false;
          
            string seltex = " SELECT student_surname, student_name FROM studentInfo where student_id=" + studentId;
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);

            try
            {
                adap.Fill(dtable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
          
           
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (isnew)
            {
                if (tbStudentName.Text == "" || tbStudentSurname.Text == "")
                {
                    MessageBox.Show("Ady ýa-da familiýany doldur");
                    return;
                }
                if (tbStudentSurname.Text[tbStudentSurname.Text.Length - 1] == 'a')
                {
                    isman = "Gyz";
                }
                else isman = "Oglan";
                string insertTex = "INSERT INTO studentInfo(student_surname, student_name, student_is_man) VALUES('" + tbStudentSurname.Text + "', '" + tbStudentName.Text + "', '" + isman +
                    "')";
                SqlCommand ins_com = new SqlCommand(insertTex, conn);
                try
                {
                   
                    conn.Open();
                    ins_com.ExecuteNonQuery();
                    Clipboard.SetText(insertTex);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                FormStudentInfo formstudentinfo = new FormStudentInfo();
                formstudentinfo.zapolnitTable();
                formstudentinfo.zapolnitGridView();
                clear();

            }
            else
            {
                if (tbStudentName.Text == "" || tbStudentSurname.Text == "")
                {
                    MessageBox.Show("Ady ýa-da familiýany doldur");
                    return;
                }
                if (tbStudentSurname.Text[tbStudentSurname.Text.Length - 1] == 'a')
                {
                    isman = "Gyz";
                }
                else isman = "Oglan";
                string uptTex = "UPDATE studentInfo  SET student_name='" + tbStudentName.Text + "', student_surname='" + tbStudentSurname.Text + "', student_is_man='" + isman + "' WHERE student_id = " + studentId ;


                SqlCommand upd_com = new SqlCommand(uptTex, conn);
                try

                {
                    conn.Open();
                    upd_com.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Prowerte Set ili Server.Error=" + ex.Message);
                }
                DialogResult = DialogResult.OK;
            }

        }
        private void clear()
        {
            tbStudentName.Text = "";
            tbStudentSurname.Text = "";
        }
        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            if (!isnew)
            {
                DataRow drow = dtable.Rows[0];
                tbStudentSurname.Text = drow["student_surname"].ToString();
                tbStudentName.Text = drow["student_name"].ToString();
            }
        }

        private void FormAddStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            { btSave.Focus(); }
            if (e.KeyChar>='0' && e.KeyChar <= '9')
            {
                e.Handled = true;
           
                return;
            }
            else if (tbStudentName.Text == "")
            {
                if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                {
                    e.Handled = true;
                    MessageBox.Show("Ady baş harp bilen giriziň");
                    return;
                }
            }
            else
            {
                if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                {
                    MessageBox.Show("Ady dürs ýazyň");
                    e.Handled = true;
                    return;
                }
            }
        }

        private void tbStudentSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                tbStudentName.Focus();
            else if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = true;

                return;
            }
            else if (tbStudentSurname.Text == "")
            {
                if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                {
                    e.Handled = true;
                    MessageBox.Show("Ady baş harp bilen giriziň");
                    return;
                }
            }
            else
            {
                if (e.KeyChar>='A' && e.KeyChar<='Z')
                {
                    MessageBox.Show("Ady dürs ýazyň");
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
