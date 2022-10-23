
namespace 客户管理系统
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.LoginAccount = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.Label();
            this.LoginPassword_Box = new System.Windows.Forms.TextBox();
            this.LoginAccount_Box = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ColorfulTimer = new System.Windows.Forms.Timer(this.components);
            this.UseKey = new System.Windows.Forms.Label();
            this.UseKey_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginAccount
            // 
            this.LoginAccount.AutoSize = true;
            this.LoginAccount.Font = new System.Drawing.Font("华文中宋", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginAccount.Location = new System.Drawing.Point(15, 48);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(182, 37);
            this.LoginAccount.TabIndex = 0;
            this.LoginAccount.Text = "注册账号：";
            // 
            // LoginPassword
            // 
            this.LoginPassword.AutoSize = true;
            this.LoginPassword.Font = new System.Drawing.Font("华文中宋", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginPassword.Location = new System.Drawing.Point(15, 140);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(182, 37);
            this.LoginPassword.TabIndex = 0;
            this.LoginPassword.Text = "注册密码：";
            // 
            // LoginPassword_Box
            // 
            this.LoginPassword_Box.Location = new System.Drawing.Point(12, 180);
            this.LoginPassword_Box.Name = "LoginPassword_Box";
            this.LoginPassword_Box.Size = new System.Drawing.Size(448, 25);
            this.LoginPassword_Box.TabIndex = 1;
            // 
            // LoginAccount_Box
            // 
            this.LoginAccount_Box.Location = new System.Drawing.Point(12, 88);
            this.LoginAccount_Box.Name = "LoginAccount_Box";
            this.LoginAccount_Box.Size = new System.Drawing.Size(448, 25);
            this.LoginAccount_Box.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("华文中宋", 10F);
            this.RegisterButton.Location = new System.Drawing.Point(203, 12);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(263, 45);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ColorfulTimer
            // 
            this.ColorfulTimer.Enabled = true;
            this.ColorfulTimer.Tick += new System.EventHandler(this.ColorfulTimer_Tick);
            // 
            // UseKey
            // 
            this.UseKey.AutoSize = true;
            this.UseKey.Font = new System.Drawing.Font("华文中宋", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UseKey.Location = new System.Drawing.Point(15, 230);
            this.UseKey.Name = "UseKey";
            this.UseKey.Size = new System.Drawing.Size(149, 37);
            this.UseKey.TabIndex = 0;
            this.UseKey.Text = "使用码：";
            // 
            // UseKey_Box
            // 
            this.UseKey_Box.Location = new System.Drawing.Point(12, 270);
            this.UseKey_Box.Name = "UseKey_Box";
            this.UseKey_Box.Size = new System.Drawing.Size(448, 25);
            this.UseKey_Box.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 349);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginAccount_Box);
            this.Controls.Add(this.UseKey_Box);
            this.Controls.Add(this.LoginPassword_Box);
            this.Controls.Add(this.UseKey);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginAccount;
        private System.Windows.Forms.Label LoginPassword;
        private System.Windows.Forms.TextBox LoginPassword_Box;
        private System.Windows.Forms.TextBox LoginAccount_Box;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Timer ColorfulTimer;
        private System.Windows.Forms.Label UseKey;
        private System.Windows.Forms.TextBox UseKey_Box;
    }
}