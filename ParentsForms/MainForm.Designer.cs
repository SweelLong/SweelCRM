
namespace 客户管理系统
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConfigUpdate = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoadFinishLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WhichUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchDataButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReadDataButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ConfigButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigUpdate
            // 
            this.ConfigUpdate.Enabled = true;
            this.ConfigUpdate.Interval = 1000;
            this.ConfigUpdate.Tick += new System.EventHandler(this.ConfigUpdate_Tick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeLabel,
            this.LoadProgressBar,
            this.LoadFinishLabel,
            this.WhichUserLabel});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 727);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1182, 26);
            this.StatusStrip.TabIndex = 6;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(216, 20);
            this.TimeLabel.Text = "当前时间：正在获取北京时间...";
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.AutoSize = false;
            this.LoadProgressBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.LoadProgressBar.Margin = new System.Windows.Forms.Padding(1, 4, 10, 4);
            this.LoadProgressBar.MarqueeAnimationSpeed = 1000;
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.Size = new System.Drawing.Size(150, 18);
            // 
            // LoadFinishLabel
            // 
            this.LoadFinishLabel.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            this.LoadFinishLabel.Name = "LoadFinishLabel";
            this.LoadFinishLabel.Size = new System.Drawing.Size(66, 20);
            this.LoadFinishLabel.Text = "加载中...";
            // 
            // WhichUserLabel
            // 
            this.WhichUserLabel.Name = "WhichUserLabel";
            this.WhichUserLabel.Size = new System.Drawing.Size(126, 20);
            this.WhichUserLabel.Text = "用户名：读取中...";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchDataButton,
            this.toolStripSeparator1,
            this.ReadDataButton,
            this.toolStripSeparator2,
            this.ConfigButton,
            this.toolStripSeparator3,
            this.ExitButton,
            this.toolStripSeparator4});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(74, 727);
            this.ToolStrip.TabIndex = 7;
            // 
            // SearchDataButton
            // 
            this.SearchDataButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchDataButton.Image")));
            this.SearchDataButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchDataButton.Name = "SearchDataButton";
            this.SearchDataButton.Size = new System.Drawing.Size(71, 72);
            this.SearchDataButton.Text = "查看数据";
            this.SearchDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchDataButton.Click += new System.EventHandler(this.SeeDataButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(71, 6);
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadDataButton.Image")));
            this.ReadDataButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReadDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(71, 72);
            this.ReadDataButton.Tag = "";
            this.ReadDataButton.Text = "读取数据";
            this.ReadDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(71, 6);
            // 
            // ConfigButton
            // 
            this.ConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfigButton.Image")));
            this.ConfigButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConfigButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(71, 72);
            this.ConfigButton.Text = "设置";
            this.ConfigButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(71, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(71, 72);
            this.ExitButton.Text = "退出";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(71, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "客户管理系统";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.ToolStripProgressBar LoadProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel LoadFinishLabel;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel WhichUserLabel;
        private System.Windows.Forms.ToolStripButton ReadDataButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ConfigButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ExitButton;
        internal System.Windows.Forms.Timer ConfigUpdate;
        private System.Windows.Forms.ToolStripButton SearchDataButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

