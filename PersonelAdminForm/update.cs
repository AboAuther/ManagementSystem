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
    public partial class update : Form
    {

        #region 常量变量的定义
        StaffManager sm = new StaffManager();
        staffmessage sme = new staffmessage();
        f_head form2;
        string[] str = new string[7]; 
        #endregion

        #region 窗体登陆、关闭
        public update()
        {
            InitializeComponent();
        }
        private void update_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        public update(string[] a, f_head f)
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];
            textBox6.Text = str[5];
            textBox7.Text = str[6];
            form2 = f;
        }
        #endregion

        #region 返回
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 取消
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        } 
        #endregion

        #region 修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (MessageBox.Show("确认是否修改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox3.Text.Trim() != "男" && textBox3.Text.Trim() != "女")
                {
                    MessageBox.Show("修改失败，性别只能为男或者女", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (a != 0 && a != 2 && a != 3 && a != 4 && a != 5 && a != 6 && a != 7 && a != 8 && a != 1)
                {
                    MessageBox.Show("修改失败，该工号不属于公司", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox3.Text.Trim() != "总监" && textBox3.Text.Trim() != "员工")
                {
                    MessageBox.Show("修改失败，职位只能为总监或者员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    #region 旧方法
                    /*if (textBox1.Text != str[0])
                                {
                                    string sql = "update staffmessage set jobID='" + textBox1.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[0] = textBox1.Text;
                                }
                                if (textBox2.Text != str[1])
                                {
                                    string sql = "update staffmessage set name='" + textBox2.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[1] = textBox2.Text;
                                }
                                if (textBox3.Text != str[2])
                                {
                                    string sql = "update staffmessage set gender='" + textBox3.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[2] = textBox3.Text;
                                }
                                if (textBox4.Text != str[3])
                                {
                                    string sql = "update staffmessage set age='" + textBox4.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[3] = textBox4.Text;
                                }
                                if (textBox5.Text != str[4])
                                {
                                    string sql = "update staffmessage set post='" + textBox5.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[4] = textBox5.Text;
                                }
                                if (textBox6.Text != str[5])
                                {
                                    string sql = "update staffmessage set seniorty='" + textBox6.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[5] = textBox6.Text;
                                }
                                if (textBox7.Text != str[6])
                                {
                                    string sql = "update staffmessage set hireyear='" + textBox7.Text + "'where jobID='" + str[0] + "'and name='" + str[1] + "'";
                                    Dao dao = new Dao();
                                    dao.Excute(sql);
                                    str[6] = textBox7.Text;
                                }*/
                    #endregion
                    sme.JobID = textBox1.Text.Trim();
                    sme.Name = textBox2.Text.Trim();
                    sme.Age = Convert.ToInt32(textBox4.Text.Trim());
                    sme.Gender = textBox3.Text.Trim();
                    sme.Post = textBox5.Text.Trim();
                    sme.Seniorty = Convert.ToInt32(textBox6.Text.Trim());
                    sme.Hireyear = Convert.ToInt32(textBox7.Text.Trim());
                    sm.UpdateStaff(sme);
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                form2.Table();
            }


        } 
        #endregion

    }
}
