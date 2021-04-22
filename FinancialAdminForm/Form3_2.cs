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
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp
{

    public partial class Form3_2 : Form
    {
        #region 常量变量的定义
        StaffSalaryManager ssm = new StaffSalaryManager();
        int year, month;
        private const int OLDOFFICEVESION = -4143;
        private const int NEWOFFICEVESION = 56;
        #endregion

        #region 窗体登录、关闭
        public Form3_2()
        {
            InitializeComponent();
        }
        public Form3_2(string a, string b)
        {
            InitializeComponent();
            year = int.Parse(a);
            month = int.Parse(b);
            Table();
        }
        private void Form3_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region 返回
        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        } 
        #endregion

        #region 选择其他月份
        private void 选择其他月份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3_2_2 form3_2_2 = new Form3_2_2();
            form3_2_2.Show();
            this.Hide();
        } 
        #endregion

        #region 显示数据
        public void Table()
        {
            dataGridView1.DataSource = ssm.GetStaffsalariesByYearandMonth(year, month);
        } 
        #endregion

        #region 生成报表
        private void 生成报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            int ret = ExportExcel("工资报表", dataGridView1, dialog);
            if (ret == 0)
            {
                MessageBox.Show("导出工资报表成功");
            }
            else if (ret != 100)
            {
                MessageBox.Show("导出工资报表失败");
            }

        } 
        #endregion

        #region 导出报表
        public int ExportExcel(string strCaption, DataGridView myDGV, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            //saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName == "")
                {
                    MessageBox.Show("请输入保存文件名！");
                    saveFileDialog.ShowDialog();
                }
                // 列索引，行索引，总列数，总行数
                int ColIndex = 0, RowIndex = 0;
                int ColCount = myDGV.ColumnCount, RowCount = myDGV.RowCount;

                if (myDGV.RowCount == 0)
                {
                    return 1;
                }
                // 创建Excel对象
                Microsoft.Office.Interop.Excel.Application xlApp = new ApplicationClass();
                if (xlApp == null)
                {
                    return 2;
                }
                try
                {
                    // 创建Excel工作薄
                    Workbook xlBook = xlApp.Workbooks.Add(true);
                    Worksheet xlSheet = (Worksheet)xlBook.Worksheets[1];
                    ////Get excel Version
                    string Version = xlApp.Version;
                    //保存excel文件的格式
                    int FormatNum;
                    if (Convert.ToDouble(Version) < 12)
                    {
                        //使用Excel 97-2003
                        FormatNum = OLDOFFICEVESION;
                    }
                    else
                    {
                        //使用 excel 2007或更新
                        FormatNum = NEWOFFICEVESION;
                    }
                    // 设置标题
                    //标题所占的单元格数与DataGridView中的列数相同
                    Range range = xlSheet.get_Range(xlApp.Cells[1, 1], xlApp.Cells[1, ColCount]);
                    range.MergeCells = true;
                    xlApp.ActiveCell.FormulaR1C1 = strCaption;
                    xlApp.ActiveCell.Font.Size = 20;
                    xlApp.ActiveCell.Font.Bold = true;
                    xlApp.ActiveCell.HorizontalAlignment = Constants.xlCenter;
                    // 创建缓存数据
                    object[,] objData = new object[RowCount + 1, ColCount];
                    //获取列标题
                    foreach (DataGridViewColumn col in myDGV.Columns)
                    {
                        objData[RowIndex, ColIndex++] = col.HeaderText;
                    }
                    // 获取数据
                    for (RowIndex = 1; RowIndex < RowCount + 1; RowIndex++)
                    {
                        for (ColIndex = 0; ColIndex < ColCount; ColIndex++)
                        {
                            //这里就是验证DataGridView单元格中的类型,如果是string或是DataTime类型,则在放入缓存时在该内容前加入" ";
                            if (myDGV[ColIndex, RowIndex - 1].ValueType == typeof(string)
                                || myDGV[ColIndex, RowIndex - 1].ValueType == typeof(DateTime))
                            {
                                objData[RowIndex, ColIndex] = "";
                                if (myDGV[ColIndex, RowIndex - 1].Value != null)
                                {
                                    objData[RowIndex, ColIndex] = "" + myDGV[ColIndex, RowIndex - 1].Value.ToString();
                                }
                            }
                            else
                            {
                                objData[RowIndex, ColIndex] = myDGV[ColIndex, RowIndex - 1].Value;
                            }
                        }
                        System.Windows.Forms.Application.DoEvents();
                    }
                    // 写入Excel
                    range = xlSheet.get_Range(xlApp.Cells[2, 1], xlApp.Cells[RowCount + 2, ColCount]);
                    range.Value2 = objData;

                    xlBook.Saved = true;
                    xlBook.SaveAs(saveFileDialog.FileName, FormatNum);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Err:" + err.Message);
                    return 9999;
                }
                finally
                {
                    xlApp.Quit();
                    GC.Collect(); //强制回收
                }
                return 0;
            }
            return 100;
        } 
        #endregion
    }
}
