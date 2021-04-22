using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        #region 窗体加载
        public Form4()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 控件功能

        #region 强制修改密码
        private void button2_Click(object sender, EventArgs e)
        {
            Form4_2_1 form4_2_1 = new Form4_2_1();
            form4_2_1.Show();
            this.Hide();
        } 
        #endregion

        #region 设置工龄工资
        private void button1_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.Show();
            this.Hide();
        }
        #endregion

        #region 设置岗位工资
        private void button3_Click(object sender, EventArgs e)
        {
            Form4_4 form4_4 = new Form4_4();
            form4_4.Show();
            this.Hide();
        }
        #endregion

        #region 管理员设置
        private void button4_Click(object sender, EventArgs e)
        {
            Form4_3 form4_3 = new Form4_3();
            form4_3.Show();
            this.Hide();
        }
        #endregion

        #region 系统时间显示
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        } 
        #endregion

        #region 返回登录
        private void 返回登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }  
        #endregion
        #endregion
    }
}
