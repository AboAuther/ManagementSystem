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
    public partial class Form5_2 : Form
    {
        #region 常量、变量的定义

        string jobid;
        StaffManager sm = new StaffManager(); 
        #endregion

        #region 窗体的登陆、关闭
        public Form5_2()
        {
            InitializeComponent();
        }
        public Form5_2(string x)
        {
            jobid = x;
            InitializeComponent();
        }
        private void Form5_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 form5 = new Form5(jobid);
            form5.Show();
            this.Hide();
        } 
        #endregion

        #region 修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入有为空，请重新确认", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!sm.CheckStaffIsExistsByJobIDandPassword(jobid, textBox1.Text.Trim()))
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
                        if (sm.ChangePassword(jobid, textBox3.Text.Trim()) > 0)
                        {
                            if (MessageBox.Show("确认修改密码？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                            {
                                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                Form5 form5 = new Form5(jobid);
                                form5.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次密码不一致，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Text = null;
                    }
                }
            }
        }

        #endregion

        #region 取消按钮
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(jobid);
            form5.Show();
            this.Hide();
        }
        #endregion

        #region 显示密码
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }


        #endregion

        
    }
}
