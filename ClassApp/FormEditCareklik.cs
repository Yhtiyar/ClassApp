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
    public partial class FormEditCareklik : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AltynCom1\SQLEXPRESS;Initial Catalog=ClassInfo;Integrated Security=True");
        DataTable dt_info = new DataTable();
        int careklikNo;
        string seltex;
        public FormEditCareklik(int fx)
        {
            InitializeComponent();
            careklikNo = fx;
            label1.Text = fx.ToString() + " çärýek";
        }

        private void FormEditCareklik_Load(object sender, EventArgs e)
        {
            setDataTable();
            setDataGrid();
        }
        void setseltex()
        {
            if (careklikNo == 1)
            {
                seltex = "SELECT student_id,student_number,student_surname,student_name,student_1_caryeklik_3, student_1_caryeklik_4, student_1_caryeklik_5 FROM studentInfo order by student_surname";
            }
            else if (careklikNo == 2)
            {
                seltex = "SELECT student_id,student_number,student_surname,student_name,student_2_caryeklik_3, student_2_caryeklik_4, student_2_caryeklik_5 FROM studentInfo order by student_surname";
            }
            else if (careklikNo == 3)
            {
                seltex = "SELECT student_id,student_number,student_surname,student_name,student_3_caryeklik_3, student_3_caryeklik_4, student_3_caryeklik_5 FROM studentInfo order by student_surname";
            }
            else if (careklikNo == 4)
            {
                seltex = "SELECT student_id,student_number,student_surname,student_name,student_4_caryeklik_3, student_4_caryeklik_4, student_4_caryeklik_5 FROM studentInfo order by student_surname";
            }
        }
      void  setDataGrid()
        {
            DGview.DataSource = dt_info;
            DGview.Columns[0].Visible = false;
            DGview.Columns[1].HeaderText = "t/b";
            DGview.Columns[1].Width = 40;
            DGview.Columns[2].HeaderText = "Familiýasy";
            DGview.Columns[2].Width =  90;
            DGview.Columns[3].HeaderText = "Ady";
            DGview.Columns[3].Width = 90;
            DGview.Columns[4].HeaderText = "3";
            DGview.Columns[4].Width = 90;
            DGview.Columns[5].HeaderText = "4";
            DGview.Columns[5].Width = 90;
            DGview.Columns[6].HeaderText = "5";
            DGview.Columns[6].Width = 90;
        }
        void setDataTable()
        {
            dt_info = new DataTable();
            setseltex();
            SqlDataAdapter adap = new SqlDataAdapter(seltex, conn);
            try
            {
                adap.Fill(dt_info);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            int i = 1;
            foreach(DataRow drow in dt_info.Rows)
            {
                drow["student_number"] = i;
                i++;
            }
        }

        private void btBelle_Click(object sender, EventArgs e)
        {
            int studentId;
            studentId = Convert.ToInt32(DGview.SelectedRows[0].Cells["student_id"].Value);
            CareklikBelle careklikbelle = new CareklikBelle(careklikNo, studentId,true);
            careklikbelle.ShowDialog();
            setDataTable();
            setDataGrid();

        }
    }
}
