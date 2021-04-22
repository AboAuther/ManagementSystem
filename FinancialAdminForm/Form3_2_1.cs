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
    public partial class Form3_2_1 : Form
    {

        #region 窗体的加载、关闭
        public Form3_2_1()
        {
            InitializeComponent();
        }
        private void Form3_2_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 查询
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入对应的年份月份", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form3_2 form3_2 = new Form3_2(textBox1.Text, textBox2.Text);
                form3_2.Show();
                this.Hide();
            }
        } 
        #endregion

        #region 关闭
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        } 
        #endregion

    }
}
