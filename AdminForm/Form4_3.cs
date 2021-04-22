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
    public partial class Form4_3 : Form
    {
        #region 常量,变量的定义
        financial_admin fa = new financial_admin();
        personel_admin pa = new personel_admin();
        FinancialAdminManager fam = new FinancialAdminManager();
        PersonelAdminManager pam = new PersonelAdminManager();
        StaffManager sm = new StaffManager();
        #endregion

        #region 表0（显示财务部员工）
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from staffmessage where postnumber='3'order by jobID asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c;
                a = dr["jobID"].ToString();
                b = dr["name"].ToString();
                c = dr["post"].ToString();
                string[] str = { a, b, c };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();//关闭连接 

        }
        #endregion

        #region 表1（显示人事部员工）
        public void Table1()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from staffmessage where postnumber='4' order by jobID asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c;
                a = dr["jobID"].ToString();
                b = dr["name"].ToString();
                c = dr["post"].ToString();
                string[] str = { a, b, c };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();//关闭连接
        }
        #endregion

        #region 表2（显示财务部管理员）
        public void Table2()
        {
            string sql = "select * from staffmessage where jobID in(select jobID from financial_admin where postnumber='3')order by jobID asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            string sql1 = "select password from financial_admin where postnumber='3'";
            Dao dao1 = new Dao();
            IDataReader dr1 = dao1.read(sql1);
            while (dr.Read()&& dr1.Read())
            {
                string a, b, c, d, f, g;
                a = dr["jobID"].ToString();
                b = dr["name"].ToString();
                c = dr["gender"].ToString();
                d = dr["age"].ToString();
                f = dr["post"].ToString();
                g = dr1["password"].ToString();
                string[] str = { a, b, c, d, f ,g};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
            dr1.Close();

        }
        #endregion

        #region 表3（显示人事部管理员）
        public void Table3()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from staffmessage where jobID in(select jobID from personel_admin where postnumber='4')order by jobID asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, f, g;
                a = dr["jobID"].ToString();
                b = dr["name"].ToString();
                c = dr["gender"].ToString();
                d = dr["age"].ToString();
                f = dr["post"].ToString();
                g = dr["password"].ToString();
                string[] str = { a, b, c, d, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
        #endregion

        #region 登录、退出、返回窗体
        public Form4_3()
        {
            InitializeComponent();
            toolStripButton3.Visible = false;
            toolStripButton2.Visible = false;
            toolStripButton1.Visible = false;
        }
        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        private void Form4_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 
        #endregion

        #region 显示财务部所有员工
        private void 财务部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "工号");
            dataGridView1.Columns.Add("", "姓名");
            dataGridView1.Columns.Add("", "职位");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toolStripButton3.Visible = false;
            toolStripButton2.Visible = false;
            toolStripButton1.Visible = true;
            Table();
        }
        #endregion

        #region 显示人事部所有员工
        private void 人事部ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "工号");
            dataGridView1.Columns.Add("", "姓名");
            dataGridView1.Columns.Add("", "职位");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table1();
            toolStripButton3.Visible = false;
            toolStripButton2.Visible = false;
            toolStripButton1.Visible = true;
        }
        #endregion

        #region 显示人事部管理员
        private void 人事部管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "工号");
            dataGridView1.Columns.Add("", "姓名");
            dataGridView1.Columns.Add("", "性别");
            dataGridView1.Columns.Add("", "年龄");
            dataGridView1.Columns.Add("", "职位");
            dataGridView1.Columns.Add("", "密码");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table3();
            toolStripButton1.Visible = false;
            toolStripButton2.Visible = true;
            toolStripButton3.Visible = true;

        }
        #endregion

        #region 显示财务部管理员
        private void 财务部管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "工号");
            dataGridView1.Columns.Add("", "姓名");
            dataGridView1.Columns.Add("", "性别");
            dataGridView1.Columns.Add("", "年龄");
            dataGridView1.Columns.Add("", "职位");
            dataGridView1.Columns.Add("", "密码");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table2();
            toolStripButton1.Visible = false;
            toolStripButton2.Visible = true;
            toolStripButton3.Visible = true;
        } 
        #endregion

        #region 删除管理员信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("将从表中删除该管理员，请确认", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                #region 旧方法
                /*
                string sql;
                if (a == 3)
                {
                    sql = "delete from financial_admin where jobID='" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
                }
                else
                {
                    sql = "delete from personel_admin where jobID='" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
                }
                Dao dao = new Dao();
                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
                #endregion

                int a = int.Parse(dataGridView1.SelectedCells[0].Value.ToString()) / 1000;
                try
                {
                    if (a == 3)
                        fam.DeleteFinancialAdminByJobID(dataGridView1.SelectedCells[0].Value.ToString());
                    else
                        pam.DeletePersonelAdminByJobID(dataGridView1.SelectedCells[0].Value.ToString());
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (a == 3)
                    Table2();
                else
                    Table3();
            }
;
        }
        #endregion

        #region 修改管理员密码
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString() };
            Form4_3_2 form4_3_2 = new Form4_3_2(str);
            form4_3_2.ShowDialog();
        }

        #endregion 

        #region 添加管理员
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("请先选择显示的部门信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString() };
                Form4_3_1 form4_3_1 = new Form4_3_1(str);
                form4_3_1.ShowDialog();
                this.Hide();
            }
        }  
        #endregion
    }
}
