namespace window0930
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.f文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拷贝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.o格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.段落格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左对齐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右对齐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.居中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f文件ToolStripMenuItem,
            this.e编辑ToolStripMenuItem,
            this.o格式ToolStripMenuItem,
            this.v查看ToolStripMenuItem,
            this.c关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // f文件ToolStripMenuItem
            // 
            this.f文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.f文件ToolStripMenuItem.Name = "f文件ToolStripMenuItem";
            this.f文件ToolStripMenuItem.Size = new System.Drawing.Size(95, 35);
            this.f文件ToolStripMenuItem.Text = "F文件";
            this.f文件ToolStripMenuItem.Click += new System.EventHandler(this.f文件ToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.openFileToolStripMenuItem.Text = "打开";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.newToolStripMenuItem.Text = "新建";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // e编辑ToolStripMenuItem
            // 
            this.e编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem,
            this.拷贝ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.全选StripMenuItem});
            this.e编辑ToolStripMenuItem.Name = "e编辑ToolStripMenuItem";
            this.e编辑ToolStripMenuItem.Size = new System.Drawing.Size(95, 35);
            this.e编辑ToolStripMenuItem.Text = "E编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.重做ToolStripMenuItem.Text = "重做";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // 拷贝ToolStripMenuItem
            // 
            this.拷贝ToolStripMenuItem.Name = "拷贝ToolStripMenuItem";
            this.拷贝ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.拷贝ToolStripMenuItem.Text = "拷贝";
            this.拷贝ToolStripMenuItem.Click += new System.EventHandler(this.拷贝ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 全选StripMenuItem
            // 
            this.全选StripMenuItem.Name = "全选StripMenuItem";
            this.全选StripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.全选StripMenuItem.Text = "全选";
            this.全选StripMenuItem.Click += new System.EventHandler(this.全选StripMenuItem_Click);
            // 
            // o格式ToolStripMenuItem
            // 
            this.o格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.颜色ToolStripMenuItem,
            this.文字样式ToolStripMenuItem,
            this.段落格式ToolStripMenuItem});
            this.o格式ToolStripMenuItem.Name = "o格式ToolStripMenuItem";
            this.o格式ToolStripMenuItem.Size = new System.Drawing.Size(102, 35);
            this.o格式ToolStripMenuItem.Text = "O格式";
            this.o格式ToolStripMenuItem.Click += new System.EventHandler(this.o格式ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.颜色ToolStripMenuItem.Text = "文字颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 文字样式ToolStripMenuItem
            // 
            this.文字样式ToolStripMenuItem.Name = "文字样式ToolStripMenuItem";
            this.文字样式ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.文字样式ToolStripMenuItem.Text = "文字样式";
            this.文字样式ToolStripMenuItem.Click += new System.EventHandler(this.文字样式ToolStripMenuItem_Click);
            // 
            // 段落格式ToolStripMenuItem
            // 
            this.段落格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左对齐ToolStripMenuItem,
            this.右对齐ToolStripMenuItem,
            this.居中ToolStripMenuItem});
            this.段落格式ToolStripMenuItem.Name = "段落格式ToolStripMenuItem";
            this.段落格式ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.段落格式ToolStripMenuItem.Text = "段落格式";
            // 
            // 左对齐ToolStripMenuItem
            // 
            this.左对齐ToolStripMenuItem.Name = "左对齐ToolStripMenuItem";
            this.左对齐ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.左对齐ToolStripMenuItem.Text = "左对齐";
            this.左对齐ToolStripMenuItem.Click += new System.EventHandler(this.左对齐ToolStripMenuItem_Click);
            // 
            // 右对齐ToolStripMenuItem
            // 
            this.右对齐ToolStripMenuItem.Name = "右对齐ToolStripMenuItem";
            this.右对齐ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.右对齐ToolStripMenuItem.Text = "右对齐";
            this.右对齐ToolStripMenuItem.Click += new System.EventHandler(this.右对齐ToolStripMenuItem_Click);
            // 
            // 居中ToolStripMenuItem
            // 
            this.居中ToolStripMenuItem.Name = "居中ToolStripMenuItem";
            this.居中ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.居中ToolStripMenuItem.Text = "居中";
            this.居中ToolStripMenuItem.Click += new System.EventHandler(this.居中ToolStripMenuItem_Click);
            // 
            // v查看ToolStripMenuItem
            // 
            this.v查看ToolStripMenuItem.Name = "v查看ToolStripMenuItem";
            this.v查看ToolStripMenuItem.Size = new System.Drawing.Size(98, 35);
            this.v查看ToolStripMenuItem.Text = "V查看";
            // 
            // c关于ToolStripMenuItem
            // 
            this.c关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本ToolStripMenuItem});
            this.c关于ToolStripMenuItem.Name = "c关于ToolStripMenuItem";
            this.c关于ToolStripMenuItem.Size = new System.Drawing.Size(98, 35);
            this.c关于ToolStripMenuItem.Text = "C关于";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(480, 44);
            this.版本ToolStripMenuItem.Text = "版本：林之韵 2019211910020";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripComboBox2,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 33);
            this.toolStripLabel1.Text = "工具箱";
            this.toolStripLabel1.ToolTipText = "选择后需再次点击选项框确认";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 39);
            this.toolStripComboBox2.Text = "宋体";
            this.toolStripComboBox2.ToolTipText = "字体选择后请再次点击选项框确认";
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 39);
            this.toolStripComboBox1.Text = "9";
            this.toolStripComboBox1.ToolTipText = "字体大小选择后请再次点击选项框确认";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(770, 350);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Notepad（关闭界面进入下一题）";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem f文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem o格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拷贝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem 全选StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 段落格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左对齐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右对齐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 居中ToolStripMenuItem;
    }
}