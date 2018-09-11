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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.text_id = textBox1.Text;
            Login.text_psd = textBox2.Text;
             
            //未选择账号类型
            if (!checkBox_student.Checked && !checkBox_manager.Checked)
                MessageBox.Show("请选择账号类型！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //账号类型为学生
            else if (checkBox_student.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入账号！", "未输入账号", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入密码！", "未输入密码", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //链接db
                    SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                    con.Open();

                    SqlCommand com = new SqlCommand("select *  from login_student where id='" + textBox1.Text.ToString() + "' and password='" + textBox2.Text.ToString() + "'", con);
                    SqlDataReader dr = com.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        MessageBox.Show("用户" + textBox1.Text + "登录成功！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Student s = new Student();
                        s.Show();
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("账号不存在或密码错误！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                        con.Close();
                    }

                }

            }

            //账号类型为宿管
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入账号！", "未输入账号", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入密码！", "未输入密码", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //链接db
                    SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                    con.Open();

                    SqlCommand com = new SqlCommand("select *  from login_manager where id='" + textBox1.Text.ToString() + "' and password='" + textBox2.Text.ToString() + "'", con);
                    SqlDataReader dr = com.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        MessageBox.Show("宿舍管理员" + textBox1.Text + "登录成功！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                        con.Close();

                        Manager m = new Manager();
                        m.Show();
                    }
                    else
                    {

                        MessageBox.Show("账号不存在或密码错误！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                        con.Close(); 
                    }
                }
 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_student.Checked)
            {
                checkBox_manager.Checked = false;
            }
            //设置单选
            /*if ((sender as CheckBox).Checked == true)
            {

                foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                {

                    if (chk != sender)
                    {

                        chk.Checked = false;

                    }

                }

            }*/
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpsd.Checked)
            {
                textBox2.PasswordChar = new char();
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void checkBox_manager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_manager.Checked)
            {
                checkBox_student.Checked = false;
            }

            //设置单选
            /* if ((sender as CheckBox).Checked == true)
             {

                 foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                 {

                     if (chk != sender)
                     {

                         chk.Checked = false;

                     }

                 }

             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Register register = new Register();
            register.Show(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号后再点击！", "未输入账号", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand com = new SqlCommand("select *  from login_student where id='" + textBox1.Text.ToString() + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("账号" + textBox1.Text + "不存在！新入学请先注册账号。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FindPsd f = new FindPsd();
                    f.Show();
                    f.textBox_id.Enabled = false;
                    f.textBox_id.ReadOnly = true;
                    f.textBox_id.Text = textBox1.Text;
                }
            }
        }
    }
}
