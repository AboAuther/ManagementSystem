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
    public partial class delete : Form
    {
        #region 常量变量的定义
        StaffManager sm = new StaffManager();
        staffmessage sme = new staffmessage(); 
        #endregion

        #region 窗体登陆、关闭
        public delete()
        {
            InitializeComponent();
        }
        private void delete_FormClosed(object sender, FormClosedEventArgs e)
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

        #region 查询
        private void button1_Click(object sender, EventArgs e)
        {
            #region 旧方法
            /*string sql = "select *from staffmessage where jobID='" + textBox9.Text + "'and name='" + textBox8.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    string a, b, c, d,f,g;

                    a = dr["gender"].ToString();
                    b = dr["age"].ToString();
                    c = dr["hireyear"].ToString();
                    d = dr["post"].ToString();
                    f = dr["seniorty"].ToString();
                    g = dr["password"].ToString();
                    textBox1.Text = c;
                    textBox3.Text = a;
                    textBox4.Text = b;
                    textBox5.Text = d;
                    textBox6.Text = f;
                    textBox7.Text = g;
                }
                else
                {
                    MessageBox.Show("未查询到该员工，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
            #endregion
            if (sm.CheckStaffIsExistsByJobIDandName(textBox1.Text.Trim(), textBox2.Text.Trim()))
            {
                textBox3.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Age.ToString();
                textBox4.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Gender.ToString();
                textBox5.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Post.ToString();
                textBox6.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Seniorty.ToString();
                textBox7.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Password.ToString();
                textBox8.Text = sm.GetStaffmessageByJobID(textBox1.Text.Trim()).Hireyear.ToString();
            }
            else
            {
                MessageBox.Show("未查询到该员工，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 删除
        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("请确认是否删除该员工信息", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                sm.DeleteStaffmessageByJobID(textBox1.Text.Trim());
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        } 
        #endregion


    }
}
