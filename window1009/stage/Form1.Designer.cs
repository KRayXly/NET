using System;

namespace Stage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openbt = new System.Windows.Forms.ToolStripButton();
            this.savebt = new System.Windows.Forms.ToolStripButton();
            this.follow = new System.Windows.Forms.ToolStripButton();
            this.next = new System.Windows.Forms.ToolStripButton();
            this.big = new System.Windows.Forms.ToolStripButton();
            this.small = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像处理IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winleft = new System.Windows.Forms.ToolStripMenuItem();
            this.winbo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.winbo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.注相同窗口只能同时打开一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.需要先关闭已有窗口才能打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本2019211910020林之韵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发起人林之韵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成文件窗口相关功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel1.Location = new System.Drawing.Point(0, 79);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1475, 863);
            this.dockPanel1.TabIndex = 3;
            this.dockPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dockPanel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openbt,
            this.savebt,
            this.follow,
            this.next,
            this.big,
            this.small,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1475, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openbt
            // 
            this.openbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openbt.Image = ((System.Drawing.Image)(resources.GetObject("openbt.Image")));
            this.openbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openbt.Name = "openbt";
            this.openbt.Size = new System.Drawing.Size(46, 32);
            this.openbt.Text = "打开";
            this.openbt.ToolTipText = "打开(允许同时打开多个图片)";
            this.openbt.Click += new System.EventHandler(this.openbt_Click);
            // 
            // savebt
            // 
            this.savebt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savebt.Image = ((System.Drawing.Image)(resources.GetObject("savebt.Image")));
            this.savebt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(46, 32);
            this.savebt.Text = "保存";
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // follow
            // 
            this.follow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.follow.Image = ((System.Drawing.Image)(resources.GetObject("follow.Image")));
            this.follow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.follow.Name = "follow";
            this.follow.Size = new System.Drawing.Size(46, 32);
            this.follow.Text = "toolStripButton3";
            this.follow.Click += new System.EventHandler(this.follow_Click);
            // 
            // next
            // 
            this.next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(46, 32);
            this.next.Text = "toolStripButton4";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // big
            // 
            this.big.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.big.Image = ((System.Drawing.Image)(resources.GetObject("big.Image")));
            this.big.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(46, 32);
            this.big.Text = "toolStripButton5";
            // 
            // small
            // 
            this.small.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.small.Image = ((System.Drawing.Image)(resources.GetObject("small.Image")));
            this.small.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(46, 32);
            this.small.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(46, 32);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.图像处理IToolStripMenuItem,
            this.窗口WToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1475, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.文件ToolStripMenuItem.Text = "文件（F）";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.ToolTipText = "允许同时打开多个文件";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 图像处理IToolStripMenuItem
            // 
            this.图像处理IToolStripMenuItem.Name = "图像处理IToolStripMenuItem";
            this.图像处理IToolStripMenuItem.Size = new System.Drawing.Size(185, 35);
            this.图像处理IToolStripMenuItem.Text = "图像处理（I）";
            // 
            // 窗口WToolStripMenuItem
            // 
            this.窗口WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winleft,
            this.winbo1,
            this.winbo2,
            this.注相同窗口只能同时打开一个ToolStripMenuItem,
            this.需要先关闭已有窗口才能打开ToolStripMenuItem});
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            this.窗口WToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.窗口WToolStripMenuItem.Text = "窗口（W）";
            // 
            // winleft
            // 
            this.winleft.Name = "winleft";
            this.winleft.Size = new System.Drawing.Size(483, 44);
            this.winleft.Text = "图像处理工具";
            this.winleft.Click += new System.EventHandler(this.winleft_Click);
            // 
            // winbo1
            // 
            this.winbo1.Name = "winbo1";
            this.winbo1.Size = new System.Drawing.Size(483, 44);
            this.winbo1.Text = "输出窗口";
            this.winbo1.Click += new System.EventHandler(this.winbo1_Click);
            // 
            // winbo2
            // 
            this.winbo2.Name = "winbo2";
            this.winbo2.Size = new System.Drawing.Size(483, 44);
            this.winbo2.Text = "统计窗口";
            this.winbo2.Click += new System.EventHandler(this.winbo2_Click);
            // 
            // 注相同窗口只能同时打开一个ToolStripMenuItem
            // 
            this.注相同窗口只能同时打开一个ToolStripMenuItem.Name = "注相同窗口只能同时打开一个ToolStripMenuItem";
            this.注相同窗口只能同时打开一个ToolStripMenuItem.Size = new System.Drawing.Size(483, 44);
            this.注相同窗口只能同时打开一个ToolStripMenuItem.Text = "注：相同窗口只能同时打开一个";
            // 
            // 需要先关闭已有窗口才能打开ToolStripMenuItem
            // 
            this.需要先关闭已有窗口才能打开ToolStripMenuItem.Name = "需要先关闭已有窗口才能打开ToolStripMenuItem";
            this.需要先关闭已有窗口才能打开ToolStripMenuItem.Size = new System.Drawing.Size(483, 44);
            this.需要先关闭已有窗口才能打开ToolStripMenuItem.Text = "需要先关闭已有窗口才能打开";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本2019211910020林之韵ToolStripMenuItem,
            this.发起人林之韵ToolStripMenuItem,
            this.完成文件窗口相关功能ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(149, 35);
            this.帮助HToolStripMenuItem.Text = "帮助（H）";
            // 
            // 版本2019211910020林之韵ToolStripMenuItem
            // 
            this.版本2019211910020林之韵ToolStripMenuItem.Name = "版本2019211910020林之韵ToolStripMenuItem";
            this.版本2019211910020林之韵ToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.版本2019211910020林之韵ToolStripMenuItem.Text = "版本：2019211910020";
            // 
            // 发起人林之韵ToolStripMenuItem
            // 
            this.发起人林之韵ToolStripMenuItem.Name = "发起人林之韵ToolStripMenuItem";
            this.发起人林之韵ToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.发起人林之韵ToolStripMenuItem.Text = "发起人：林之韵";
            // 
            // 完成文件窗口相关功能ToolStripMenuItem
            // 
            this.完成文件窗口相关功能ToolStripMenuItem.Name = "完成文件窗口相关功能ToolStripMenuItem";
            this.完成文件窗口相关功能ToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.完成文件窗口相关功能ToolStripMenuItem.Text = "实现功能：文件、窗口";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 942);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WeifenLuo.WinFormsUI.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripButton openbt;
        private System.Windows.Forms.ToolStripButton savebt;
        private System.Windows.Forms.ToolStripButton follow;
        private System.Windows.Forms.ToolStripButton next;
        private System.Windows.Forms.ToolStripButton big;
        private System.Windows.Forms.ToolStripButton small;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像处理IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winleft;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本2019211910020林之韵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发起人林之韵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winbo1;
        private System.Windows.Forms.ToolStripMenuItem winbo2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 注相同窗口只能同时打开一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 需要先关闭已有窗口才能打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成文件窗口相关功能ToolStripMenuItem;
    }
}

