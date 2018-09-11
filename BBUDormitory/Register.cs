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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_respsd.Text != "admin")     //验证码错误
            {
                MessageBox.Show(textBox_resName.ToString());
                MessageBox.Show("注册码输入错误!请向所在宿舍管理员询问注册码完成注册！","提交失败",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

            else
            {
                if (textBox_psd.Text != textBox_repsd.Text)
                {
                    MessageBox.Show("两次密码输入不一致！请重新输入", "提交失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox_psd.Clear();
                    textBox_repsd.Clear();
                }
                else if(textBox_dornum.Text=="" || textBox_psd.Text==""||textBox_resID.Text==""||textBox_resName.Text==""||textBox_tel.Text==""||textBox_sex.Text=="")
                {
                    MessageBox.Show("请填写完整！", "提交失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                }
                else //提交数据库
                {
                    SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("select * from stu_info where stuDor='" + textBox_dornum.Text.ToString() + "'", con);
                    SqlDataReader dr = cmd2.ExecuteReader();
                    dr.Read();
                    if (!dr.HasRows)
                    {
                        dr.Close();
                        SqlCommand cmd = new SqlCommand("insert into stu_info(stuName,stuID,stuPsd,stuTel,stuDor,stuSex) values('" + textBox_resName.Text.ToString() + "','" + textBox_resID.Text.ToString() + "','" + textBox_psd.Text.ToString() + "','" + textBox_tel.Text.ToString() + "','" + textBox_dornum.Text.ToString() + "','" + textBox_sex.Text.ToString() + "')", con);
                        SqlCommand cmd1 = new SqlCommand("insert into login_student(id,password) values('" + textBox_resID.Text.ToString() + "','" + textBox_psd.Text.ToString() + "')", con);
                        if (cmd.ExecuteNonQuery() != 0 && cmd1.ExecuteNonQuery() != 0)
                        {
                            
                            SqlCommand cmd3 = new SqlCommand("insert into dor_info(dorNum,powermoney) values('" + textBox_dornum.Text.ToString() + "','100')", con);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("注册成功！请以注册的账号和密码登录系统。已经赠送100度电可使用！", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            con.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("发生未知错误，注册失败！");
                            con.Close();
                            this.Close();
                        }
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd = new SqlCommand("insert into stu_info(stuName,stuID,stuPsd,stuTel,stuDor,stuSex) values('" + textBox_resName.Text.ToString() + "','" + textBox_resID.Text.ToString() + "','" + textBox_psd.Text.ToString() + "','" + textBox_tel.Text.ToString() + "','" + textBox_dornum.Text.ToString() + "','" + textBox_sex.Text.ToString() + "')", con);
                        SqlCommand cmd1 = new SqlCommand("insert into login_student(id,password) values('" + textBox_resID.Text.ToString() + "','" + textBox_psd.Text.ToString() + "')", con);
                        if (cmd.ExecuteNonQuery() != 0 && cmd1.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("注册成功！请以注册的账号和密码登录系统！", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("发生未知错误，注册失败！");
                            con.Close();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

    }
}
