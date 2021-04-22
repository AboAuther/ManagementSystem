namespace WindowsFormsApp
{
    partial class Form3_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffsalaryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataDataSet1 = new WindowsFormsApp.StaffDataDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择其他月份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.生成报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDataDataSet = new WindowsFormsApp.StaffDataDataSet();
            this.staffsalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsalaryTableAdapter = new WindowsFormsApp.StaffDataDataSetTableAdapters.staffsalaryTableAdapter();
            this.staffsalaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffsalaryTableAdapter1 = new WindowsFormsApp.StaffDataDataSet1TableAdapters.staffsalaryTableAdapter();
            this.staffDataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.DataSource = this.staffsalaryBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(843, 422);
            this.dataGridView1.TabIndex = 5;
            // 
            // staffsalaryBindingSource2
            // 
            this.staffsalaryBindingSource2.DataMember = "staffsalary";
            this.staffsalaryBindingSource2.DataSource = this.staffDataDataSet1;
            // 
            // staffDataDataSet1
            // 
            this.staffDataDataSet1.DataSetName = "StaffDataDataSet1";
            this.staffDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem,
            this.选择其他月份ToolStripMenuItem,
            this.生成报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // 选择其他月份ToolStripMenuItem
            // 
            this.选择其他月份ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.选择其他月份ToolStripMenuItem.Name = "选择其他月份ToolStripMenuItem";
            this.选择其他月份ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.选择其他月份ToolStripMenuItem.Text = "选择其他月份";
            this.选择其他月份ToolStripMenuItem.Click += new System.EventHandler(this.选择其他月份ToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // 生成报表ToolStripMenuItem
            // 
            this.生成报表ToolStripMenuItem.Name = "生成报表ToolStripMenuItem";
            this.生成报表ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.生成报表ToolStripMenuItem.Text = "生成报表";
            this.生成报表ToolStripMenuItem.Click += new System.EventHandler(this.生成报表ToolStripMenuItem_Click);
            // 
            // staffDataDataSet
            // 
            this.staffDataDataSet.DataSetName = "StaffDataDataSet";
            this.staffDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffsalaryBindingSource
            // 
            this.staffsalaryBindingSource.DataMember = "staffsalary";
            this.staffsalaryBindingSource.DataSource = this.staffDataDataSet;
            // 
            // staffsalaryTableAdapter
            // 
            this.staffsalaryTableAdapter.ClearBeforeFill = true;
            // 
            // staffsalaryBindingSource1
            // 
            this.staffsalaryBindingSource1.DataMember = "staffsalary";
            this.staffsalaryBindingSource1.DataSource = this.staffDataDataSet1;
            // 
            // staffsalaryTableAdapter1
            // 
            this.staffsalaryTableAdapter1.ClearBeforeFill = true;
            // 
            // staffDataDataSet1BindingSource
            // 
            this.staffDataDataSet1BindingSource.DataSource = this.staffDataDataSet1;
            this.staffDataDataSet1BindingSource.Position = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "jobID";
            this.Column1.FillWeight = 88.4469F;
            this.Column1.HeaderText = "工号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.FillWeight = 95.8364F;
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "year";
            this.Column3.FillWeight = 72.74284F;
            this.Column3.HeaderText = "年份";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "month";
            this.Column4.FillWeight = 68.4492F;
            this.Column4.HeaderText = "月份";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "basic_salary";
            this.Column5.FillWeight = 118.6312F;
            this.Column5.HeaderText = "基本工资";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "job_salary";
            this.Column6.FillWeight = 118.6312F;
            this.Column6.HeaderText = "岗位工资";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "seniorty_salary";
            this.Column7.FillWeight = 118.6312F;
            this.Column7.HeaderText = "工龄工资";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "welfare_salary";
            this.Column8.FillWeight = 118.6312F;
            this.Column8.HeaderText = "福利工资";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "totalsalary";
            this.Column9.HeaderText = "总工资";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Form3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工工资查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsalaryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择其他月份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private StaffDataDataSet staffDataDataSet;
        private System.Windows.Forms.BindingSource staffsalaryBindingSource;
        private StaffDataDataSetTableAdapters.staffsalaryTableAdapter staffsalaryTableAdapter;
        private StaffDataDataSet1 staffDataDataSet1;
        private System.Windows.Forms.BindingSource staffsalaryBindingSource1;
        private StaffDataDataSet1TableAdapters.staffsalaryTableAdapter staffsalaryTableAdapter1;
        private System.Windows.Forms.BindingSource staffsalaryBindingSource2;
        private System.Windows.Forms.BindingSource staffDataDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}