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
    public partial class Login : Form
    {
        StaffManager sm = new StaffManager();
        PersonelAdminManager pam = new PersonelAdminManager();
        FinancialAdminManager fam = new FinancialAdminManager();
        string jobid;
        public Login()
        {
            InitializeComponent();
        }

        #region 计时器启动
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 395)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
            }
            else
            {
                if (comboBox1.Text == "人事管理员")
                {
                    f_head form2 = new f_head();
                    form2.Show();
                    this.Hide();
                }
                else if (comboBox1.Text == "财务管理员")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else if (comboBox1.Text == "系统管理员")
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else if (comboBox1.Text == "员工")
                {
                    Form5 form5 = new Form5(jobid);
                    form5.Show();
                    this.Hide();
                }
                timer1.Stop();
            }
        }
        #endregion

        #region 登录按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (login())
            {
                timer1.Start();
                label4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            jobid=Convert.ToString(sm.GetJobIDByNameAndPassword(textBox1.Text.Trim(),textBox2.Text.Trim()).JobID);
        }
        #endregion

        #region 登录检测
        private bool login()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            if (comboBox1.Text == "员工")
            {
                #region 旧方法
                /*string sql = "select *from staffmessage where name='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;   
                        }*/
                #endregion
                if (!sm.CheckStaffLogin(textBox1.Text.Trim(), textBox2.Text.Trim()))
                {
                    MessageBox.Show("用户名或密码错误，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return false;
                }
                return true;
            }
            if (comboBox1.Text == "人事管理员")
            {
                #region 旧方法
                /*string sql = "select *from personel_admin where name='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误，或您未含有该权限，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;  
                        }*/
                #endregion
                if (!pam.CheckPersonelAdminLogin(textBox1.Text.Trim(), textBox2.Text.Trim()))
                {
                    MessageBox.Show("用户名或密码错误，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return false;
                }
                return true;
            }
            if (comboBox1.Text == "财务管理员")
            {
                #region 旧方法
                /*string sql = "select *from financial_admin where name='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误，请重试！或您未含有该权限，", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }*/
                #endregion
                if (!fam.CheckFinancialAdminLogin(textBox1.Text.Trim(), textBox2.Text.Trim()))
                {
                    MessageBox.Show("用户名或密码错误，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return false;
                }
                return true;
            }
            if (comboBox1.Text == "系统管理员")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重试！或您未含有该权限，", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region 取消按钮
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
        } 
        #endregion
    }
}
