
namespace 客户管理系统
{
    partial class DataForm
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
            System.Windows.Forms.ToolStripMenuItem 提示每一个按回车后才能被保存ToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.年龄 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.护照 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通行证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.微信 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.维护记录 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.附件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStrip_Box = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用方法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRowsNumItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.DataSaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearRowsNumItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearItem = new System.Windows.Forms.ToolStripMenuItem();
            提示每一个按回车后才能被保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.ContextMenuStrip_Box.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // 提示每一个按回车后才能被保存ToolStripMenuItem
            // 
            提示每一个按回车后才能被保存ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            提示每一个按回车后才能被保存ToolStripMenuItem.AutoSize = false;
            提示每一个按回车后才能被保存ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            提示每一个按回车后才能被保存ToolStripMenuItem.Name = "提示每一个按回车后才能被保存ToolStripMenuItem";
            提示每一个按回车后才能被保存ToolStripMenuItem.ShowShortcutKeys = false;
            提示每一个按回车后才能被保存ToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            提示每一个按回车后才能被保存ToolStripMenuItem.Text = "提示：每格回车后才能被保存";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名,
            this.性别,
            this.年龄,
            this.出生日期,
            this.身份证,
            this.护照,
            this.通行证,
            this.电话,
            this.微信,
            this.地址,
            this.维护记录,
            this.附件});
            this.DataGridView.ContextMenuStrip = this.ContextMenuStrip_Box;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 30);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(965, 450);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // 姓名
            // 
            this.姓名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 3;
            this.姓名.Name = "姓名";
            this.姓名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.姓名.Width = 66;
            // 
            // 性别
            // 
            this.性别.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.性别.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.性别.HeaderText = "性别";
            this.性别.Items.AddRange(new object[] {
            "男",
            "女",
            "   "});
            this.性别.MinimumWidth = 3;
            this.性别.Name = "性别";
            this.性别.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.性别.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.性别.Width = 66;
            // 
            // 年龄
            // 
            this.年龄.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.年龄.HeaderText = "年龄";
            this.年龄.MinimumWidth = 3;
            this.年龄.Name = "年龄";
            this.年龄.Width = 66;
            // 
            // 出生日期
            // 
            this.出生日期.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.出生日期.HeaderText = "出生日期";
            this.出生日期.MinimumWidth = 3;
            this.出生日期.Name = "出生日期";
            this.出生日期.Width = 96;
            // 
            // 身份证
            // 
            this.身份证.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.身份证.HeaderText = "身份证";
            this.身份证.MinimumWidth = 3;
            this.身份证.Name = "身份证";
            this.身份证.Width = 81;
            // 
            // 护照
            // 
            this.护照.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.护照.HeaderText = "护照";
            this.护照.MinimumWidth = 3;
            this.护照.Name = "护照";
            this.护照.Width = 66;
            // 
            // 通行证
            // 
            this.通行证.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.通行证.HeaderText = "通行证";
            this.通行证.MinimumWidth = 3;
            this.通行证.Name = "通行证";
            this.通行证.Width = 81;
            // 
            // 电话
            // 
            this.电话.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.电话.HeaderText = "电话";
            this.电话.MinimumWidth = 3;
            this.电话.Name = "电话";
            this.电话.Width = 66;
            // 
            // 微信
            // 
            this.微信.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.微信.HeaderText = "微信";
            this.微信.MinimumWidth = 3;
            this.微信.Name = "微信";
            this.微信.Width = 66;
            // 
            // 地址
            // 
            this.地址.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.地址.HeaderText = "地址";
            this.地址.MinimumWidth = 3;
            this.地址.Name = "地址";
            this.地址.Width = 66;
            // 
            // 维护记录
            // 
            this.维护记录.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.维护记录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.维护记录.HeaderText = "维护记录";
            this.维护记录.MinimumWidth = 6;
            this.维护记录.Name = "维护记录";
            this.维护记录.Text = "";
            this.维护记录.Width = 73;
            // 
            // 附件
            // 
            this.附件.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.附件.HeaderText = "附件(右键)";
            this.附件.MinimumWidth = 3;
            this.附件.Name = "附件";
            this.附件.Width = 112;
            // 
            // ContextMenuStrip_Box
            // 
            this.ContextMenuStrip_Box.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip_Box.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开附件ToolStripMenuItem,
            this.添加附件ToolStripMenuItem,
            this.使用方法ToolStripMenuItem});
            this.ContextMenuStrip_Box.Name = "ContextMenuStrip";
            this.ContextMenuStrip_Box.Size = new System.Drawing.Size(139, 76);
            // 
            // 打开附件ToolStripMenuItem
            // 
            this.打开附件ToolStripMenuItem.Name = "打开附件ToolStripMenuItem";
            this.打开附件ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.打开附件ToolStripMenuItem.Text = "打开附件";
            this.打开附件ToolStripMenuItem.Click += new System.EventHandler(this.打开附件ToolStripMenuItem_Click);
            // 
            // 添加附件ToolStripMenuItem
            // 
            this.添加附件ToolStripMenuItem.Name = "添加附件ToolStripMenuItem";
            this.添加附件ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.添加附件ToolStripMenuItem.Text = "添加附件";
            this.添加附件ToolStripMenuItem.Click += new System.EventHandler(this.添加附件ToolStripMenuItem_Click);
            // 
            // 使用方法ToolStripMenuItem
            // 
            this.使用方法ToolStripMenuItem.Name = "使用方法ToolStripMenuItem";
            this.使用方法ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.使用方法ToolStripMenuItem.Text = "使用方法";
            this.使用方法ToolStripMenuItem.Click += new System.EventHandler(this.使用方法ToolStripMenuItem_Click);
            // 
            // AddRowsNumItem
            // 
            this.AddRowsNumItem.Image = ((System.Drawing.Image)(resources.GetObject("AddRowsNumItem.Image")));
            this.AddRowsNumItem.Name = "AddRowsNumItem";
            this.AddRowsNumItem.Size = new System.Drawing.Size(103, 26);
            this.AddRowsNumItem.Text = "添加行数";
            this.AddRowsNumItem.Click += new System.EventHandler(this.AddRowsNumItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataSaveItem,
            this.DataSaveAsItem,
            this.AddRowsNumItem,
            this.ClearRowsNumItem,
            this.ClearItem,
            提示每一个按回车后才能被保存ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(965, 30);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // DataSaveItem
            // 
            this.DataSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("DataSaveItem.Image")));
            this.DataSaveItem.Name = "DataSaveItem";
            this.DataSaveItem.Size = new System.Drawing.Size(103, 26);
            this.DataSaveItem.Text = "保存数据";
            this.DataSaveItem.Click += new System.EventHandler(this.DataSaveItem_Click);
            // 
            // DataSaveAsItem
            // 
            this.DataSaveAsItem.Image = ((System.Drawing.Image)(resources.GetObject("DataSaveAsItem.Image")));
            this.DataSaveAsItem.Name = "DataSaveAsItem";
            this.DataSaveAsItem.Size = new System.Drawing.Size(103, 26);
            this.DataSaveAsItem.Text = "数据另存";
            this.DataSaveAsItem.Click += new System.EventHandler(this.DataSaveAsItem_Click);
            // 
            // ClearRowsNumItem
            // 
            this.ClearRowsNumItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearRowsNumItem.Image")));
            this.ClearRowsNumItem.Name = "ClearRowsNumItem";
            this.ClearRowsNumItem.Size = new System.Drawing.Size(103, 26);
            this.ClearRowsNumItem.Text = "删除此行";
            this.ClearRowsNumItem.Click += new System.EventHandler(this.ClearRowsNumItem_Click);
            // 
            // ClearItem
            // 
            this.ClearItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearItem.Image")));
            this.ClearItem.Name = "ClearItem";
            this.ClearItem.Size = new System.Drawing.Size(103, 26);
            this.ClearItem.Text = "清空此格";
            this.ClearItem.Click += new System.EventHandler(this.ClearItem_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 480);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DataForm";
            this.Text = "数据";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ContextMenuStrip_Box.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ToolStripMenuItem AddRowsNumItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearRowsNumItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Box;
        private System.Windows.Forms.ToolStripMenuItem 打开附件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用方法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加附件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearItem;
        private System.Windows.Forms.ToolStripMenuItem DataSaveItem;
        private System.Windows.Forms.ToolStripMenuItem DataSaveAsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewComboBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证;
        private System.Windows.Forms.DataGridViewTextBoxColumn 护照;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通行证;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 微信;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址;
        private System.Windows.Forms.DataGridViewButtonColumn 维护记录;
        private System.Windows.Forms.DataGridViewTextBoxColumn 附件;
    }
}