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
    public partial class Form3 : Form
    {
        #region 窗体的登陆加载关闭
        public Form3()
        {

            InitializeComponent();
            toolStripLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 显示系统时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion

        #region 员工工资计算
        private void button1_Click(object sender, EventArgs e)
        {
            Form3_1_1 form3_1_1 = new Form3_1_1();
            form3_1_1.Show();
            this.Hide();
        }
        #endregion

        #region 员工工资查询
        private void button2_Click(object sender, EventArgs e)
        {
            Form3_2_1 form3_2_1 = new Form3_2_1();
            form3_2_1.Show();
            this.Hide();

        }
        #endregion

        #region 返回
        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        } 
        #endregion
    }
}
