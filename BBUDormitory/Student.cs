using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace BBUDormitory
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            
        }

        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from stu_info where stuID='" + Login.text_id + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                //string test = dr.GetString(dr.GetOrdinal("stuName"));
                label_sname.Text = "姓名:" + dr.GetString(dr.GetOrdinal("stuName"));
                label_ssex.Text = "性别:" + dr.GetString(dr.GetOrdinal("stuSex"));
                label_sdor.Text = "宿舍:" + dr.GetString(dr.GetOrdinal("stuDor"));

                temp1 = dr.GetString(dr.GetOrdinal("stuName"));
                temp_name = temp1;
                temp_sex = dr.GetString(dr.GetOrdinal("stuSex"));
                temp_tel = dr.GetString(dr.GetOrdinal("stuTel"));
                temp_dor = dr.GetString(dr.GetOrdinal("stuDor"));
            }
            if (label_ssex.Text == "性别:女")
                pictureBox1.Image = imageList1.Images[0];
            else
                pictureBox1.Image = imageList1.Images[1];

            dr.Close();
            con.Close();    
           
        }

        private void button_alter_Click(object sender, EventArgs e)
        {
            Alter a = new Alter();
            a.Show();
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_updatenews_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from stu_info where stuID='" + Login.text_id + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            SqlCommand cmd1 = new SqlCommand("select * from news where object ='all' or  object ='"+dr.GetString(dr.GetOrdinal("stuDor"))+"'",con);
            dr.Close();

            //DataSet ds = new DataSet("select * from news where object ='all' or  object ='" + dr.GetString(dr.GetOrdinal("stuDor")) + "'", con);

            
            SqlDataReader dr1 = cmd1.ExecuteReader();
            textBox_news.Text = "";

            while (dr1.Read())
            {
                //textBox_news.Text = "";
                textBox_news.Text = textBox_news.Text+"\r\n"+dr1.GetString(dr1.GetOrdinal("news"));
                //dr1.Close();
                //con.Close();
            }
            
            
            dr1.Close();
            con.Close();


        }
    }
}
