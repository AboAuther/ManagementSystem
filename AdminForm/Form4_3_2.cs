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
    public partial class Form4_3_2 : Form
    {
        #region 常量变量的定义
        string[] message;
        FinancialAdminManager fam = new FinancialAdminManager();
        PersonelAdminManager pam = new PersonelAdminManager();
        #endregion

        #region 窗体登陆
        public Form4_3_2()
        {
            InitializeComponent();
        }
        public Form4_3_2(string[] str)
        {
            message = str;
            InitializeComponent();
        }
        private void Form4_3_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入为空，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (textBox2.Text == textBox3.Text)
                {
                    int a = int.Parse(message[0]);
                    if (a == 4)
                    {
                        pam.ChangePassword(message[0], textBox3.Text.Trim());
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        fam.ChangePassword(message[0], textBox3.Text.Trim());
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码不一致，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Text = null;
                }
            }
        }
        #endregion

        #region 返回按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
