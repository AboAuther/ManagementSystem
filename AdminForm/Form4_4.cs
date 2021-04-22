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
    public partial class Form4_4 : Form
    {
        #region 常量变量的定义
        PostwageManager pm = new PostwageManager();
        #region 旧方法
        /*public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from postwage order by postnumber asc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, f;
                a = dr["postnumber"].ToString();
                b = dr["department"].ToString();
                c = dr["post"].ToString();
                d = dr["post_wage"].ToString();
                f = dr["basicsalary"].ToString();
                dataGridView1.Rows.Add(a, b, c, d, f);
            }
            dr.Close();
        } */
        #endregion
        #endregion

        #region 窗体登陆、关闭
        public Form4_4()
        {
            InitializeComponent();
            dataGridView1.DataSource = pm.GetPostwageData();
            //Table();
        }
        private void Form4_4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 
        #endregion

        #region 控件功能
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Table();
            dataGridView1.DataSource = pm.GetPostwageData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString() };
            Form4_4_1 form4_4_1 = new Form4_4_1(str);
            form4_4_1.ShowDialog();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        } 
        #endregion

    }
}
