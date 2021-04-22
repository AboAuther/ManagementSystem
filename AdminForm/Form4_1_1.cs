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
    public partial class Form4_1_1 : Form
    {
        #region 常量变量的定义
        string s; 
        #endregion

        #region 窗体登陆、关闭
        public Form4_1_1()
        {
            InitializeComponent();
        }
        public Form4_1_1(string[] a)
        {
            s = a[0];
            InitializeComponent();
            label1.Text = "第" + a[0] + "年";
            textBox1.Text = a[1];
        }
        private void Form4_1_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update seniortysalary set seniorty_salary='" + textBox1.Text + "'where seniorty='" + s + "'";
            Dao dao = new Dao();
            dao.Excute(sql);
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 返回按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion


    }
}
