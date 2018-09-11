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
    public partial class Manager : Form
    {
        //private Timer Timer;
        public Manager()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.Red);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y,e.ClipRectangle.X + e.ClipRectangle.Width - 1,e.ClipRectangle.Y + e.ClipRectangle.Height - 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from stu_info where stuName='"+comboBoxCheck.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                labelName.Text = dr.GetString(dr.GetOrdinal("stuName"));
                labelSex.Text = dr.GetString(dr.GetOrdinal("stuSex"));
                labelTel.Text = dr.GetString(dr.GetOrdinal("stuTel"));
                labelDor.Text = dr.GetString(dr.GetOrdinal("stuDor"));


                textBox_Dor.Text = labelDor.Text;

                if (labelSex.Text == "女")
                    pictureBox.Image = imageList1.Images[0];
                else
                    pictureBox.Image = imageList1.Images[1];

                MessageBox.Show("检索成功！","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("没有找到输入的学生！请检查后重新输入！","失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Dor.Text == "")
            {
                MessageBox.Show("请先输入宿舍号！","错误");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dor_info where dorNum='"+textBox_Dor.Text.ToString()+"'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    int p = dr.GetInt32(dr.GetOrdinal("powerMoney"));
                    p += 50;
                    dr.Close();

                    SqlCommand cmd1 = new SqlCommand("update dor_info set powerMoney=' " + p + "' where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                    if (cmd1.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("电费充值成功！", "成功");
                        con.Close();
                    }
                    else 
                    {
                        MessageBox.Show("充值失败！请稍后重试。","失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("寝室不存在！请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Dor.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_Dor.Text == "")
            {
                MessageBox.Show("请先输入宿舍号！", "错误");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dor_info where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    int p = dr.GetInt32(dr.GetOrdinal("powerMoney"));
                    p += 100;
                    dr.Close();

                    SqlCommand cmd1 = new SqlCommand("update dor_info set powerMoney=' " + p + "' where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                    if (cmd1.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("电费充值成功！", "成功");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("充值失败！请稍后重试。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("寝室不存在！请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Dor.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox_Dor.Text == "")
            {
                MessageBox.Show("请先输入宿舍号！", "错误");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dor_info where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    int p = dr.GetInt32(dr.GetOrdinal("powerMoney"));
                    p += 150;
                    dr.Close();

                    SqlCommand cmd1 = new SqlCommand("update dor_info set powerMoney=' " + p + "' where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                    if (cmd1.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("电费充值成功！", "成功");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("充值失败！请稍后重试。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("寝室不存在！请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Dor.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_Dor.Text == "")
            {
                MessageBox.Show("请先输入宿舍号！", "错误");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dor_info where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    int p = dr.GetInt32(dr.GetOrdinal("powerMoney"));
                    p += 200;
                    dr.Close();

                    SqlCommand cmd1 = new SqlCommand("update dor_info set powerMoney=' " + p + "' where dorNum='" + textBox_Dor.Text.ToString() + "'", con);
                    if (cmd1.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("电费充值成功！", "成功");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("充值失败！请稍后重试。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("寝室不存在！请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Dor.Text = "";
                }
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            /*Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();*/

            label12.Text = System.DateTime.Now.ToString();
            
            SqlConnection Conn = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            //初始化，comboBox1绑定客户表
            string Sql = "select stuName from stu_info";
            DataSet Ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter(Sql, Conn);

            Da.Fill(Ds, "stu_info");
            comboBoxCheck.DataSource = Ds.Tables["stu_info"];
            comboBoxCheck.DisplayMember = "stuName";

            Conn.Close();

            SqlConnection Conn1 = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            //初始化，comboBox1绑定客户表
            string Sql1= "select dorNum from dor_info";
            DataSet Ds1= new DataSet();
            SqlDataAdapter Da1= new SqlDataAdapter(Sql1, Conn1);

            Da1.Fill(Ds1, "dor_info");
            comboBox1.DataSource = Ds1.Tables["dor_info"];
            comboBox1.DisplayMember = "dorNum";

            comboBox2.DataSource = Ds1.Tables["dor_info"];
            comboBox2.DisplayMember = "dorNum";
            //comboBox2.Items.Add("all");
            Conn1.Close();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
            conn.Open();//打开连接
            SqlCommand cmd = new SqlCommand("select * from stu_info where stuDor='"+comboBox1.Text.ToString()+"'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            /*sdr.Read();
            string temp=sdr.GetString(sdr.GetOrdinal("stuDor"));*/
            //string temp = "";

            while (sdr.Read())
            {
                
                //temp = sdr.GetString(sdr.GetOrdinal("stuDor"));
                string[] v = { sdr.GetString(sdr.GetOrdinal("stuName")), sdr.GetString(sdr.GetOrdinal("stuTel")) };
                dataGridView1.Rows.Add(v);
       
            }
            sdr.Close();
            conn.Close();



           /* SqlCommand cmd1 = new SqlCommand("select * from dor_info where dorNum =' " + temp + "'",conn);
            //SqlDataReader dr = cmd1.ExecuteReader();
            //dr.Read();
            if (cmd1.ExecuteNonQuery()!=0)
            {

                textBox1.Text = "电费余额：" + dr.GetString(dr.GetOrdinal(temp));
                //dr.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("12345");
            }*/




        }

        private void button7_Click(object sender, EventArgs e)
        {
            string art = "";
            string obj = "";
            if (checkBox1.Checked)
            {
                art = textBox1.Text.ToString();
                obj = "all";

                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into news (news,object) values('" + art + "','" + obj + "')",con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("全体消息发布成功！", "成功！");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("全体消息发布失败！，请检查是否为重复消息", "失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();

                }
            }
            else
            {
                art = textBox1.Text.ToString();
                obj = comboBox2.Text.ToString();

                SqlConnection con = new SqlConnection("server=.;database=Dormitory;integrated security=SSPI");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into news (news,object) values('" + art + "','" + obj + "')",con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("消息发布成功！", "成功！");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("消息发布失败！，请检查是否为重复消息", "失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("确定要退出登录吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
 
            }
        }
    }
}
