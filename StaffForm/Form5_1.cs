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
    public partial class Form5_1 : Form
    {
        #region 常量变量的定义
        StaffSalaryManager ssm = new StaffSalaryManager();
        string jobid;
        int year, month;
        #endregion

        #region 窗体登陆、关闭
        public Form5_1()
        {
            InitializeComponent();
        }
        public Form5_1(string x)
        {
            jobid = x;
            InitializeComponent();
        }
        public Form5_1(string x, int y, int z)
        {
            jobid = x;
            year = y;
            month = z;
            InitializeComponent();
        }
        private void Form5_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 form5 = new Form5(jobid);
            form5.Show();
            this.Hide();
        }
        #endregion

        #region 所有记录
        private void 所有记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ssm.GetStaffsalariesByJobID(jobid);
        } 
        #endregion

        #region 按月查询
        private void 开始查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ssm.GetStaffsalariesByYearandMonthandJobID(jobid, year, month);
        }
        private void 选择年月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_1_1 form5_1_1 = new Form5_1_1();
            form5_1_1.Show();
            this.Hide();
        }
        #endregion

        #region 返回
        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(jobid);
            form5.Show();
            this.Hide();
        } 
        #endregion

    }
}
