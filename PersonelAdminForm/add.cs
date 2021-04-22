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
    public partial class add : Form
    {
        #region 常量变量的定义
        StaffManager sm = new StaffManager();
        staffmessage sme = new staffmessage();
        f_head form2; 
        #endregion

        #region 窗体的登陆、关闭
        public add(f_head f)
        {
            InitializeComponent();
            form2 = f;
        }
        private void add_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
            textBox8.Text = null;
        }
        #endregion

        #region 添加员工信息
        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBox1.Text);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text.Trim() != "男" && textBox3.Text.Trim() != "女")
            {
                MessageBox.Show("插入失败，性别只能为男或者女", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a != 0 && a != 2 && a != 3 && a != 4 && a != 5 && a != 6 && a != 7 && a != 8 && a != 1)
            {
                MessageBox.Show("插入失败，该工号不属于公司", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text.Trim() != "总监" && textBox3.Text.Trim() != "员工")
            {
                MessageBox.Show("插入失败，职位只能为总监或者员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("是否添加？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sme.JobID = textBox1.Text.Trim();
                    sme.Name = textBox2.Text.Trim();
                    sme.Age = Convert.ToInt32(textBox4.Text.Trim());
                    sme.Gender = textBox3.Text.Trim();
                    sme.Post = textBox5.Text.Trim();
                    sme.Seniorty = Convert.ToInt32(textBox6.Text.Trim());
                    sme.Password = textBox7.Text.Trim();
                    sme.Hireyear = Convert.ToInt32(textBox8.Text.Trim());
                    sme.Postnumber = a;
                    try
                    {
                        if (sm.AddStaff(sme) > 0)
                        {
                            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox4.Text = null;
                            textBox5.Text = null;
                            textBox6.Text = null;
                            textBox7.Text = null;
                            textBox8.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("插入失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("插入失败,系统中已有该员工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    #region 旧方法
                    /*string sql = "Insert into staffmessage values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + (a / 1000) + "')";
                                Dao dao = new Dao();
                                int i = dao.Excute(sql);
                                if (i > 0)
                                {
                                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); textBox1.Text = null;
                                    textBox2.Text = null;
                                    textBox3.Text = null;
                                    textBox4.Text = null;
                                    textBox5.Text = null;
                                    textBox6.Text = null;
                                    textBox7.Text = null;
                                    textBox8.Text = null;

                                }
                                else
                                {
                                    MessageBox.Show("插入失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }*/
                    #endregion
                    form2.Table();
                }


            }


        } 
        #endregion
    }
}
