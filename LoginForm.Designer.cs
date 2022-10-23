
namespace 客户管理系统
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Copyright = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.PictureBox();
            this.LoginDirectly = new System.Windows.Forms.Button();
            this.LoginFormMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.APPNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.VersionNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register)).BeginInit();
            this.LoginFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Copyright.Location = new System.Drawing.Point(12, 329);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(167, 15);
            this.Copyright.TabIndex = 1;
            this.Copyright.Text = "Copyright SweelLong ";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(214, 252);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(237, 18);
            this.Password.TabIndex = 3;
            // 
            // Account
            // 
            this.Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account.ForeColor = System.Drawing.Color.Black;
            this.Account.Location = new System.Drawing.Point(214, 199);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(237, 18);
            this.Account.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Location = new System.Drawing.Point(214, 294);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(108, 39);
            this.Login.TabIndex = 4;
            this.Login.TabStop = false;
            this.Login.Click += new System.EventHandler(this.LoginPicture_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Location = new System.Drawing.Point(341, 294);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(108, 39);
            this.Register.TabIndex = 4;
            this.Register.TabStop = false;
            this.Register.Click += new System.EventHandler(this.RegisterPicture_Click);
            // 
            // LoginDirectly
            // 
            this.LoginDirectly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginDirectly.Location = new System.Drawing.Point(12, 294);
            this.LoginDirectly.Name = "LoginDirectly";
            this.LoginDirectly.Size = new System.Drawing.Size(84, 28);
            this.LoginDirectly.TabIndex = 6;
            this.LoginDirectly.Text = "直接登录";
            this.LoginDirectly.UseVisualStyleBackColor = true;
            this.LoginDirectly.Click += new System.EventHandler(this.LoginDirectly_Click);
            // 
            // LoginFormMenu
            // 
            this.LoginFormMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LoginFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolStripMenuItem,
            this.PathStripMenuItem,
            this.ExitToolStripMenuItem});
            this.LoginFormMenu.Name = "LoginFormMenu";
            this.LoginFormMenu.Size = new System.Drawing.Size(139, 76);
            // 
            // DisplayToolStripMenuItem
            // 
            this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.DisplayToolStripMenuItem.Text = "显示窗体";
            this.DisplayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // PathStripMenuItem
            // 
            this.PathStripMenuItem.Name = "PathStripMenuItem";
            this.PathStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.PathStripMenuItem.Text = "文件目录";
            this.PathStripMenuItem.Click += new System.EventHandler(this.PathStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.ExitToolStripMenuItem.Text = "退出程序";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // APPNotifyIcon
            // 
            this.APPNotifyIcon.ContextMenuStrip = this.LoginFormMenu;
            this.APPNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("APPNotifyIcon.Icon")));
            this.APPNotifyIcon.Text = "客户管理系统";
            // 
            // VersionNow
            // 
            this.VersionNow.AutoSize = true;
            this.VersionNow.Location = new System.Drawing.Point(499, 329);
            this.VersionNow.Name = "VersionNow";
            this.VersionNow.Size = new System.Drawing.Size(71, 15);
            this.VersionNow.TabIndex = 7;
            this.VersionNow.Text = "v0.0.0.0";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.VersionNow);
            this.Controls.Add(this.LoginDirectly);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Copyright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register)).EndInit();
            this.LoginFormMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.PictureBox Register;
        private System.Windows.Forms.Button LoginDirectly;
        private System.Windows.Forms.ContextMenuStrip LoginFormMenu;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PathStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon APPNotifyIcon;
        private System.Windows.Forms.Label VersionNow;
    }
}