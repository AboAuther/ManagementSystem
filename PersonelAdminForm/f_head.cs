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
    public partial class f_head : Form
    {
        #region 定义常量变量
        StaffManager staff = new StaffManager(); 
        #endregion

        #region 加载窗体
        public f_head()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
        } 
        #endregion

        #region 添加员工信息
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            add form2_1 = new add(this);
            form2_1.ShowDialog();

        }
        private void 添加员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add form2_1 = new add(this);
            form2_1.ShowDialog();
        }
        #endregion

        #region 修改员工信息
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString(), dataGridView1.SelectedCells[6].Value.ToString() };
            update form2_2 = new update(str, this);
            form2_2.ShowDialog();
        }
        private void 修改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString(), dataGridView1.SelectedCells[6].Value.ToString() };
            update form2_2 = new update(str, this);
            form2_2.ShowDialog();
        }
        #endregion

        #region 删除员工信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            delete form2_3 = new delete();
            form2_3.ShowDialog();
        }
        private void 删除员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete form2_3 = new delete();
            form2_3.ShowDialog();
        }
        #endregion

        #region 查看员工信息
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }
        private void 查看员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }

        #endregion       

        #region 让表显示数据
        public void Table()
        {
            #region 旧方法
            //dataGridView1.Rows.Clear();
            /*string sql = "select * from staffmessage order by jobID asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f, g;
                a = dr["jobID"].ToString();
                b = dr["name"].ToString();
                c = dr["gender"].ToString();
                d = dr["age"].ToString();
                e = dr["hireyear"].ToString();
                f = dr["post"].ToString();
                g = dr["seniorty"].ToString();
                string[] str = { a, b, c, d, f, g, e };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();//关闭连接*/
            #endregion
            dataGridView1.DataSource = staff.GetStaffData();
        }
        #endregion

        #region 控件功能
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 返回登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        } 
        #endregion
    }
}
