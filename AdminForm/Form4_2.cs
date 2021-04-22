using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemBll;
using ManagementSystemModels;

namespace WindowsFormsApp
{
    public partial class Form4_2 : Form
    {
        #region 常量变量的定义
        StaffManager sm = new StaffManager();
        staffmessage staff = new staffmessage();
        string jobid; 
        #endregion

        #region 窗体登陆、返回
        public Form4_2()
        {
            InitializeComponent();
        }
        public Form4_2(string s)
        {
            jobid = s;
            InitializeComponent();
            groupBox1.Text = "请输入" + sm.GetNameByJobID(jobid).Name + "的新密码：";
        }

        private void Form4_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 
        #endregion

        #region 返回
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        } 
        #endregion

        #region 修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            #region 旧方法
            /* string sql = "select *from staffmessage where jobID='"+jobid+"'and password='"+textBox1.Text+"' ";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("输入有为空，请重新确认", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!dr.Read())
                    {
                        MessageBox.Show("原密码输入错误，请重新确认", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                    }
                    else
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            string sq = "update staffmessage set password='" + textBox2.Text + "'where jobID='" + jobid + "'";
                            Dao dao1 = new Dao();
                            dao1.Excute(sq);
                            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("两次密码不一致，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox3.Text = null;
                        }
                    }
                }*/
            #endregion
            if (textBox2.Text == textBox3.Text)
            {
                #region 旧方法
                /*string sq = "update staffmessage set password='" + textBox2.Text + "'where jobID='" + jobid + "'";
                        Dao dao1 = new Dao();
                        dao1.Excute(sq);*/
                #endregion
                sm.ChangePassword(jobid, textBox2.Text.Trim());
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = null;
                textBox3.Text = null;
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("两次密码不一致，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Text = null;
            }
        }
        #endregion

        #region 显示密码
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        } 
        #endregion
    }
}
