namespace Stage
{
    partial class Dockleft
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("图像差值");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("图像滤波");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("二值化");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("形态学");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("灰度变换");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("边界抽取");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("预处理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("宋体", 9F);
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(10);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "图像差值";
            treeNode2.Name = "节点4";
            treeNode2.Text = "图像滤波";
            treeNode3.Name = "节点5";
            treeNode3.Text = "二值化";
            treeNode4.Name = "节点6";
            treeNode4.Text = "形态学";
            treeNode5.Name = "节点7";
            treeNode5.Text = "灰度变换";
            treeNode6.Name = "节点8";
            treeNode6.Text = "边界抽取";
            treeNode7.Name = "节点0";
            treeNode7.Text = "预处理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(254, 609);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Dockleft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dockleft";
            this.TabText = "图像处理工具";
            this.Text = "图像处理工具";
            this.ToolTipText = "图像处理工具";
            this.Load += new System.EventHandler(this.Dockpanel1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}