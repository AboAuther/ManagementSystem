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
    public partial class Form3_1_1 : Form
    {
        #region 常量变量的定义
        PostwageManager pm = new PostwageManager();
        SeniortySalaryManager ssm = new SeniortySalaryManager();
        WelfareSalaryManager wsm = new WelfareSalaryManager();
        StaffManager sm = new StaffManager();
        staffsalary ss = new staffsalary();
        StaffSalaryManager sssm = new StaffSalaryManager();
        int postnumber;
        int p;
        #endregion

        #region 加载窗体
        public Form3_1_1()
        {
            InitializeComponent();
        }
        private void Form3_1_1_Load(object sender, EventArgs e)
        {
            this.welfare_salaryTableAdapter.Fill(this.staffDataDataSet.welfare_salary);
            this.staffmessageTableAdapter.Fill(this.staffDataDataSet.staffmessage);
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox7.Text = "";
        }
        private void Form3_1_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        #endregion

        #region 添加控件
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ""|| textBox3.Text == "" || textBox8.Text == "" || textBox6.Text == ""
                || textBox5.Text == "" || textBox4.Text == "" || textBox1.Text == "" || textBox7.Text == ""
                || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("有信息未填，请重新确认", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ReturnIsTrue())
            {
                MessageBox.Show("该员工不属于该部门，请重新选择工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sssm.CheckIsSalaryRecord(int.Parse(textBox2.Text.Trim()), int.Parse(textBox3.Text.Trim()),comboBox3.Text.Trim()))
            {
                MessageBox.Show("该员工本月份已有工资记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ss.JobID = comboBox3.Text;
                ss.Name = textBox1.Text;
                ss.Year = Convert.ToInt32(textBox2.Text);
                ss.Month = Convert.ToInt32(textBox3.Text);
                ss.Basic_salary = Convert.ToInt32(textBox4.Text);
                ss.Job_salary = Convert.ToInt32(textBox5.Text);
                ss.Seniorty_salary = Convert.ToInt32(textBox6.Text);
                ss.Welfare_salary = Convert.ToInt32(textBox7.Text);
                ss.Totalsalary = Convert.ToInt32(textBox8.Text);
                if (sssm.AddSalary(ss) > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 返回控件

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        #endregion

        #region 计算控件
        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Text = (int.Parse(textBox7.Text) + int.Parse(textBox6.Text) + int.Parse(textBox5.Text) + int.Parse(textBox4.Text)).ToString();
        }
        #endregion

        #region 部门变化显示不同岗位
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "董事会")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("董事长");
            }
            else if (comboBox1.SelectedItem == "管理层")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("总经理");
                comboBox2.Items.Add("副总经理");
                comboBox2.Items.Add("总经理助理");
            }
            else if (comboBox1.SelectedItem == "采购部" || comboBox1.SelectedItem == "人事部" || 
                comboBox1.SelectedItem == "财务部" || comboBox1.SelectedItem == "市场部" || comboBox1.SelectedItem == "销售部" 
                || comboBox1.SelectedItem == "研发部")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("总监");
                comboBox2.Items.Add("员工");
            }
            else if (comboBox2.SelectedItem == "系统管理部")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("系统管理员");
            }
        } 
        #endregion

        #region 岗位变化显示工资
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "董事会" && comboBox2.SelectedItem == "董事长")
            {
                #region 旧方法
                /*string sql = "select post_wage,basicsalary from postwage where postnumber=1 ";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            textBox5.Text = dr["post_wage"].ToString();
                            textBox4.Text = dr["basicsalary"].ToString();
                        }*/
                #endregion
                textBox5.Text = pm.GetPostwageByPostnumber(1).Post_wage.ToString();
                textBox4.Text = pm.GetPostwageByPostnumber(1).Basicsalary.ToString();

            }
            if (comboBox1.SelectedItem == "管理层" )
            {
                #region 旧方法
                /*string sql = "select post_wage,basicsalary from postwage where postnumber=1 ";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            textBox5.Text = dr["post_wage"].ToString();
                            textBox4.Text = dr["basicsalary"].ToString();
                        }*/
                #endregion
                if(comboBox2.SelectedItem == "总经理")
                {
                    textBox5.Text = pm.GetPostwageByPost("总经理").Post_wage.ToString();
                    textBox4.Text = pm.GetPostwageByPost("总经理").Basicsalary.ToString();
                }
                else
                {
                    textBox5.Text = pm.GetPostwageByPost("总经理助理").Post_wage.ToString();
                    textBox4.Text = pm.GetPostwageByPost("总经理助理").Basicsalary.ToString();
                }
            }
            if (comboBox2.SelectedItem == "总监")
            {
                #region 旧方法
                /*string sql = "select post_wage,basicsalary from postwage where post like '%总监' ";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        if (dr.Read())
                        {
                            textBox5.Text = dr["post_wage"].ToString();
                            textBox4.Text = dr["basicsalary"].ToString();
                        }*/
                #endregion
                textBox5.Text = pm.GetPostwageByPost("总监").Post_wage.ToString();
                textBox4.Text = pm.GetPostwageByPost("总监").Basicsalary.ToString();
            }
            if (comboBox2.SelectedItem == "员工")
            {
                #region 旧方法
                /*string sql = "select post_wage,basicsalary from postwage where post like '%职工' ";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    textBox5.Text = dr["post_wage"].ToString();
                    textBox4.Text = dr["basicsalary"].ToString();
                }*/
                #endregion
                textBox5.Text = pm.GetPostwageByPost("员工").Post_wage.ToString();
                textBox4.Text = pm.GetPostwageByPost("员工").Basicsalary.ToString();
            }
            
        }
        #endregion

        #region 福利工资选择
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region 旧方法
            /* string sql = "select welfare_salary from welfare_salary where welfare_name='" + comboBox4.Text + "'  ";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    textBox7.Text = dr["welfare_salary"].ToString();
                }*/
            #endregion
            textBox7.Text = wsm.GetSalaryByName(comboBox4.Text.Trim()).Welfare_salary.ToString();
        }
        #endregion

        #region 工号姓名选择工龄工资
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            postnumber = (Convert.ToInt32(comboBox3.Text)) / 1000;
            string sql = "select max(seniorty_salary) from seniortysalary where seniorty < = (select seniorty from staffmessage where name='" + textBox1.Text + "'and jobID='" + comboBox3.Text + "') ";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    textBox6.Text = dr[""].ToString();
                }
            #region 未解决
            /*try
                {
                    int s = ssm.GetSeniortyByJobIDandName(comboBox3.Text, textBox1.Text).Seniorty;
                    textBox6.Text = ssm.GetSeniortySalaryBySeniorty(s).Seniorty_salary.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("工号姓名不对应，请重新检查","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }*/ 
            #endregion

        }
        #endregion

        #region 月份提醒
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            if (a != 1 && a != 2 && a != 3 && a != 4 && a != 5 && a != 6 && a != 7 && a != 8 && a != 9 && a != 10 && a != 11 && a != 12)
            {
                MessageBox.Show("请输入正确的月份", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 获取工号用于对比
        public void getjobid()
        {
            p = Convert.ToInt32(pm.SelecJobIDByDepartmentAndPost(comboBox1.Text.Trim(),comboBox2.Text.Trim()).Postnumber);
        }
        #endregion

        #region 返回部门号是否一致
        public bool ReturnIsTrue()
        {
            getjobid();
            if (p != postnumber)
                return true;
            else
                return false;
        }


        #endregion

    }
}
