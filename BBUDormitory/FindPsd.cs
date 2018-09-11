using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BBUDormitory
{
    public partial class FindPsd : Form
    {
        public FindPsd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from stu_info where stuID='" + textBox_id.Text.ToString() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
            String tel = dr.GetString(dr.GetOrdinal("stuTel"));
            String dor = dr.GetString(dr.GetOrdinal("stuDor"));
            String psd = dr.GetString(dr.GetOrdinal("stuPsd"));
            if (textBox_Tel.Text == tel && textBox_Dor.Text == dor)
            {
                MessageBox.Show("您的密码为:" + psd + " 建议登录系统后修改密码！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("账号信息输入有误！","失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox_Tel.Text = "";
                textBox_Dor.Text = "";
            }
        }
    }
}
