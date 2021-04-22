namespace WindowsFormsApp
{
    partial class Form5_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.所有记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按月查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择年月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 6;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.所有记录ToolStripMenuItem,
            this.按月查询ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 所有记录ToolStripMenuItem
            // 
            this.所有记录ToolStripMenuItem.Name = "所有记录ToolStripMenuItem";
            this.所有记录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.所有记录ToolStripMenuItem.Text = "所有记录";
            this.所有记录ToolStripMenuItem.Click += new System.EventHandler(this.所有记录ToolStripMenuItem_Click);
            // 
            // 按月查询ToolStripMenuItem
            // 
            this.按月查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择年月ToolStripMenuItem,
            this.开始查询ToolStripMenuItem});
            this.按月查询ToolStripMenuItem.Name = "按月查询ToolStripMenuItem";
            this.按月查询ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.按月查询ToolStripMenuItem.Text = "按月查询";
            // 
            // 选择年月ToolStripMenuItem
            // 
            this.选择年月ToolStripMenuItem.Name = "选择年月ToolStripMenuItem";
            this.选择年月ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.选择年月ToolStripMenuItem.Text = "选择年月";
            this.选择年月ToolStripMenuItem.Click += new System.EventHandler(this.选择年月ToolStripMenuItem_Click);
            // 
            // 开始查询ToolStripMenuItem
            // 
            this.开始查询ToolStripMenuItem.Name = "开始查询ToolStripMenuItem";
            this.开始查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.开始查询ToolStripMenuItem.Text = "开始查询";
            this.开始查询ToolStripMenuItem.Click += new System.EventHandler(this.开始查询ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // Form5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人工资记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 所有记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按月查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择年月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
    }
}