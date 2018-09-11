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
    public partial class Alter : Form
    {
        public Alter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            con.Open();

            

            if (textBox_aldornum.Text != "" && textBox_alName.Text != "" && textBox_altel.Text != "" && textBox_alsex.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update stu_info set stuName ='" + textBox_alName.Text.ToString() + "',stuSex='" + textBox_alsex.Text.ToString() + "',stuTel='" + textBox_altel.Text.ToString() + "',stuDor='" + textBox_aldornum.Text.ToString() + "'" + " where stuName ='" + Student.temp1 + "'",con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("资料修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("没有任何数据发生变化！");
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("请填写完整！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Alter_Load(object sender, EventArgs e)
        {
            textBox_alName.Text = Student.temp_name;
            textBox_alsex.Text = Student.temp_sex;
            textBox_altel.Text = Student.temp_tel;
            textBox_aldornum.Text = Student.temp_dor;
        }
    }
}
