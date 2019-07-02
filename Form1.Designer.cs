namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("连接");
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.s7协议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusTcpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内部变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.开始连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.varGridView1 = new System.Windows.Forms.DataGridView();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varPLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s7协议ToolStripMenuItem,
            this.modbusTcpToolStripMenuItem,
            this.oPCToolStripMenuItem,
            this.内部变量ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 100);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip1_ItemClicked);
            // 
            // s7协议ToolStripMenuItem
            // 
            this.s7协议ToolStripMenuItem.Name = "s7协议ToolStripMenuItem";
            this.s7协议ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.s7协议ToolStripMenuItem.Text = "S7协议";
            this.s7协议ToolStripMenuItem.Click += new System.EventHandler(this.S7协议ToolStripMenuItem_Click);
            // 
            // modbusTcpToolStripMenuItem
            // 
            this.modbusTcpToolStripMenuItem.Name = "modbusTcpToolStripMenuItem";
            this.modbusTcpToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.modbusTcpToolStripMenuItem.Text = "ModbusTcp";
            // 
            // oPCToolStripMenuItem
            // 
            this.oPCToolStripMenuItem.Name = "oPCToolStripMenuItem";
            this.oPCToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.oPCToolStripMenuItem.Text = "OPC";
            // 
            // 内部变量ToolStripMenuItem
            // 
            this.内部变量ToolStripMenuItem.Name = "内部变量ToolStripMenuItem";
            this.内部变量ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.内部变量ToolStripMenuItem.Text = "内部变量";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 23);
            this.treeView1.Name = "treeView1";
            treeNode2.ContextMenuStrip = this.contextMenuStrip1;
            treeNode2.Name = "ConnectRoot";
            treeNode2.Text = "连接";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(167, 565);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.增加设备ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 52);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip2_ItemClicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // 增加设备ToolStripMenuItem
            // 
            this.增加设备ToolStripMenuItem.Name = "增加设备ToolStripMenuItem";
            this.增加设备ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.增加设备ToolStripMenuItem.Text = "增加设备";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.开始连接ToolStripMenuItem,
            this.断开连接ToolStripMenuItem,
            this.增加变量ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip2";
            this.contextMenuStrip3.Size = new System.Drawing.Size(139, 100);
            this.contextMenuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip3_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // 开始连接ToolStripMenuItem
            // 
            this.开始连接ToolStripMenuItem.Name = "开始连接ToolStripMenuItem";
            this.开始连接ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.开始连接ToolStripMenuItem.Text = "开始连接";
            this.开始连接ToolStripMenuItem.Click += new System.EventHandler(this.开始连接ToolStripMenuItem_Click);
            // 
            // 断开连接ToolStripMenuItem
            // 
            this.断开连接ToolStripMenuItem.Name = "断开连接ToolStripMenuItem";
            this.断开连接ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.断开连接ToolStripMenuItem.Text = "断开连接";
            // 
            // 增加变量ToolStripMenuItem
            // 
            this.增加变量ToolStripMenuItem.Name = "增加变量ToolStripMenuItem";
            this.增加变量ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.增加变量ToolStripMenuItem.Text = "增加变量";
            this.增加变量ToolStripMenuItem.Click += new System.EventHandler(this.addPlcVar);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip4.Name = "contextMenuStrip2";
            this.contextMenuStrip4.Size = new System.Drawing.Size(127, 28);
            this.contextMenuStrip4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip4_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // varGridView1
            // 
            this.varGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarName,
            this.varPLC,
            this.varType,
            this.varAddr,
            this.varValue});
            this.varGridView1.Location = new System.Drawing.Point(201, 24);
            this.varGridView1.Name = "varGridView1";
            this.varGridView1.RowTemplate.Height = 27;
            this.varGridView1.Size = new System.Drawing.Size(545, 563);
            this.varGridView1.TabIndex = 4;
            this.varGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // VarName
            // 
            this.VarName.HeaderText = "名称";
            this.VarName.Name = "VarName";
            // 
            // varPLC
            // 
            this.varPLC.HeaderText = "当前PLC";
            this.varPLC.Name = "varPLC";
            // 
            // varType
            // 
            this.varType.HeaderText = "类型";
            this.varType.Name = "varType";
            // 
            // varAddr
            // 
            this.varAddr.HeaderText = "地址";
            this.varAddr.Name = "varAddr";
            // 
            // varValue
            // 
            this.varValue.HeaderText = "当前值";
            this.varValue.Name = "varValue";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 600);
            this.Controls.Add(this.varGridView1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem s7协议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusTcpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加设备ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开始连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加变量ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 内部变量ToolStripMenuItem;
        private System.Windows.Forms.DataGridView varGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn varPLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn varType;
        private System.Windows.Forms.DataGridViewTextBoxColumn varAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn varValue;
    }
}

