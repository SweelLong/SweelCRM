using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 客户管理系统
{
    internal partial class RegisterForm : Form
    {
        internal RegisterForm()
        {
            InitializeComponent();
        }

        internal void ColorfulTimer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            Color C = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            LoginAccount_Box.ForeColor = C;
            LoginPassword_Box.ForeColor = C;
            UseKey_Box.ForeColor = C;
        }

        internal void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UseKey_Box.Text == "1214294089")
            {
                StreamWriter sw = new StreamWriter(Start.MyDataPath+"\\user\\user.ini");
                if (LoginAccount_Box.Text == "")
                    MessageBox.Show("账号不得为空");
                else
                    sw.WriteLine(SweelKey.Encryption(LoginAccount_Box.Text));
                if (LoginPassword_Box.Text == "")
                    MessageBox.Show("密码不得为空");
                else
                    sw.WriteLine(SweelKey.Encryption(LoginPassword_Box.Text));
                sw.Flush();
                sw.Dispose();
                MessageBox.Show("注册完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("使用码错误");
            }
            Dispose();
        }
    }
}
