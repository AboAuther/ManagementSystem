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
    public partial class Form4_2_1 : Form
    {
        #region 常量变量的定义
        string jobid;
        StaffManager sm = new StaffManager();
        #endregion

        #region 窗体的登录、关闭
        public Form4_2_1()
        {
            InitializeComponent();
        }

        private void Form4_2_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        #endregion

        #region 取消按钮
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        #endregion

        #region 查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            #region 旧方法
            /*
                jobid = textBox2.Text;
                string sql = "select * from staffmessage where name='"+textBox1.Text+"'and jobID='"+textBox2.Text +"'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    Form4_2 form4_2 = new Form4_2(jobid);
                    form4_2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("未查询到该员工，请重新确认工号和姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    textBox2.Text = null;
                }*/
            #endregion
            jobid = textBox2.Text;
            if (sm.CheckStaffIsExistsByJobIDandName(textBox2.Text.Trim(), textBox1.Text.Trim()))
            {
                Form4_2 form4_2 = new Form4_2(jobid);
                form4_2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("未查询到该员工，请重新确认工号和姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = null;
                textBox2.Text = null;
            }
        } 
        #endregion
    }
}
