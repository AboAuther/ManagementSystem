using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4_1 : Form
    {
        #region 窗体的登录、关闭
        public Form4_1()
        {
            InitializeComponent();
            Table();
        }
        private void Form4_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        #endregion

        #region 修改按钮
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString() };
            Form4_1_1 form4_1_1 = new Form4_1_1(str);
            form4_1_1.ShowDialog();
        }
        #endregion

        #region 查询按钮
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }
        #endregion

        #region 返回
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        #endregion

        #region 查询数据
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select* from seniortysalary";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b;
                a = dr["seniorty"].ToString();
                b = dr["seniorty_salary"].ToString();
                dataGridView1.Rows.Add(a, b);
            }
            dr.Close();
        } 
        #endregion
    }
}
