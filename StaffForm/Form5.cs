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
using System.IO;


namespace WindowsFormsApp
{
    public partial class Form5 : Form
    {
        StaffManager sm = new StaffManager();
        staffmessage staff = new staffmessage();
        PostwageManager pm = new PostwageManager();
        string jobid;
        string pic;
        public Form5()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            
        }
        public Form5(string id)
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            jobid = id;
            if (Convert.ToString(sm.GetNameByJobID(jobid).Pic_url)!="")
            {
                pictureBox1.Image = Image.FromFile(Convert.ToString(sm.GetNameByJobID(jobid).Pic_url));
            }
            show();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void show()
        {
            staff = sm.GetStaffmessageByJobID(jobid);
            textBox1.Text = Convert.ToString(staff.JobID);
            textBox2.Text = Convert.ToString(staff.Name);
            textBox3.Text = Convert.ToString(staff.Age);
            textBox4.Text = Convert.ToString(staff.Gender);
            textBox5.Text = Convert.ToString(staff.Hireyear);
            textBox6.Text = Convert.ToString(staff.Post);
            textBox7.Text = Convert.ToString(staff.Seniorty);
            textBox8.Text = Convert.ToString(pm.SelectDepartmentByJobID(jobid).Department);
            

        }


        //选择照片
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //显示选择文件对话框
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //所有的文件格式
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pic= openFileDialog1.FileName;   //显示文件路径
            }
        }

        //保存照片
        private void button2_Click(object sender, EventArgs e)
        {
            if (pic==null)
            {
                MessageBox.Show("照片未选择或已保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sm.AddStaffPic_url(pic, jobid) > 0)
                {
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("只能编辑个人信息，如需修改公司信息及工号，请联系人事管理员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff.Name = textBox2.Text;
            staff.Age = int.Parse(textBox3.Text);
            staff.Gender = textBox4.Text;
            staff.JobID = textBox1.Text;
            try
            {
                if (sm.UpdateStaffPersonally(staff) > 0)
                {
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 查看工资记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_1 form5_1 = new Form5_1(textBox1.Text);
            form5_1.Show();
            this.Hide();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_2 form5_2 = new Form5_2(textBox1.Text);
            form5_2.Show();
            this.Hide();
        }
    }
}
