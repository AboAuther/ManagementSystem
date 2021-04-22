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
    public partial class Form4_3_1 : Form
    {
        #region 常量变量的定义
        financial_admin fa = new financial_admin();
        personel_admin pa = new personel_admin();
        FinancialAdminManager fam = new FinancialAdminManager();
        PersonelAdminManager pam = new PersonelAdminManager();
        string[] str = new string[3];
        int num = 3;
        #endregion

        #region 窗体的登录，关闭
        public Form4_3_1()
        {
            InitializeComponent();
        }
        public Form4_3_1(string[] a)
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
        }
        private void Form4_3_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form4_3 form4_3 = new Form4_3();
            form4_3.Show();
        }
        #endregion

        #region 添加管理员
        private void button1_Click(object sender, EventArgs e) 
       
        {
            if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入为空，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int a = (int.Parse(textBox1.Text)/1000);
            #region 旧方法
            /*string sql;
                if (a == 3 || a == 4)
                {
                    if (a == 3)
                    {
                        sql = "Insert into financial_admin(jobID,name,password,postnumber) select distinct '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + a + "' from financial_admin where not exists (select * from financial_admin where jobID='" + textBox1.Text + "')  ";
                    }
                    else 
                    {
                        sql = "Insert into personel_admin(jobID,name,password,postnumber) select distinct '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + a + "' from personel_admin where not exists (select * from personel_admin where jobID='" + textBox1.Text + "') ";
                    }
                    Dao dao = new Dao();
                    int i = dao.Excute(sql);       
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                        MessageBox.Show("该员工初始密码为工号，若需要修改请返回上层强制修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("插入失败,表中已有该员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                    }
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("插入失败,该工号不为相关部门员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                */
            #endregion

            #region 调用逻辑层
            fa.JobID = textBox1.Text.Trim();
            fa.Name = textBox2.Text.Trim();
            fa.Password = textBox1.Text.Trim();
            fa.Postnumber = a;
            pa.JobID = textBox1.Text.Trim();
            pa.Name = textBox2.Text.Trim();
            pa.Password = textBox1.Text.Trim();
            pa.Postnumber = a;
            try
            {
                if (a == 3)
                {
                    fam.AddFinancialAdmin(fa);
                }
                else
                {
                    pam.AddPersonelAdmin(pa);
                }
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                MessageBox.Show("该员工初始密码为工号，若需要修改请返回上层强制修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("插入失败,表中已有该员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            } 
            #endregion
            timer1.Start();
        }
        #endregion

        #region 取消
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            this.Close();
        }
        #endregion

        #region 自动关闭窗口
        private void timer1_Tick(object sender, EventArgs e)
        {
            num--;
            label4.Text = "本窗口将于" + num + "秒后自动关闭";
            if (num == 0)
            {
                this.Close();
                timer1.Stop();
            }

        }

        #endregion

    }
}
