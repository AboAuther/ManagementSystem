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
    public partial class Form4_4_1 : Form
    {
        #region 常量变量的定义
        PostwageManager pm = new PostwageManager();
        postwage pw = new postwage();
        string[] s = new string[2];
        #endregion

        #region 窗体登陆、关闭
        public Form4_4_1()
        {
            InitializeComponent();
        }
        public Form4_4_1(string[] a)
        {
            InitializeComponent();
            s[0] = a[0];
            s[1] = a[1];
            label2.Text = a[0];
            label4.Text = a[1];
            textBox1.Text = a[2];
            textBox2.Text = a[3];
        }
        private void Form4_4_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 返回
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region 修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            #region 旧方法
            /*string sql = "update postwage set post_wage='" + textBox1.Text + "', basicsalary='" + textBox2.Text + "' where department='" + s[0] + "'and post='" + s[1] + "'";
            Dao dao = new Dao();
            dao.Excute(sql);*/
            #endregion
            pw.Post = s[1];
            pw.Department = s[0];
            pw.Post_wage = Convert.ToInt32(textBox1.Text.Trim());
            pw.Basicsalary = Convert.ToInt32(textBox2.Text.Trim());
            pm.UpdatePostwage(pw);
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion
    }
}
