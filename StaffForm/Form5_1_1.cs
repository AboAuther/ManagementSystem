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
    public partial class Form5_1_1 : Form
    {
        #region 窗体登陆、关闭
        public Form5_1_1()
        {
            InitializeComponent();
        }
        private void Form5_1_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form5_1 form5_1 = new Form5_1(textBox3.Text);
                form5_1.Show();
                this.Hide();
            }
        }
        #endregion

        #region 查询
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Form5_1 form5_1 = new Form5_1(textBox3.Text, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                form5_1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("输入为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 输入工号返回
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form5_1 form5_1 = new Form5_1(textBox3.Text);
                form5_1.Show();
                this.Hide();
            }
        } 
        #endregion

    }
}
