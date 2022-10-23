using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
//using System.Net;
//using System.Text;
using System.Windows.Forms;

namespace 客户管理系统
{
    internal partial class LoginForm : Form
    {
        internal LoginForm()
        {
            InitializeComponent();
            VersionNow.Text = "v"+Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        internal static string WhichUserNameIs = null;//记录用户名

        internal void LoginPicture_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Start.MyDataPath+"\\user\\user.ini"))
            {
                MessageBox.Show("请先注册成为用户", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!string.IsNullOrEmpty(Account.Text) && !string.IsNullOrEmpty(Password.Text))
                {
                    StreamReader sw = new StreamReader(Start.MyDataPath+"\\user\\user.ini");
                    string account = SweelKey.Decryption(sw.ReadLine());
                    string password = SweelKey.Decryption(sw.ReadLine());
                    sw.Dispose();
                    if (Account.Text == account && Password.Text == password)
                    {
                        WhichUserNameIs = Account.Text;
                        APPNotifyIcon.Visible = true;
                        new MainForm().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("账号和密码均不得为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        internal void RegisterPicture_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
        }

        internal void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        internal void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        //internal void UpdateCheck_Clicked(object sender, EventArgs e)
        //{
        //    MessageBox.Show("请耐心等待，连接服务器中...");
        //    try
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append("当前版本：v");
        //        sb.Append(Assembly.GetExecutingAssembly().GetName().Version.ToString());
        //        sb.Append("\n最新版本：v");
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //        WebRequest wrt = WebRequest.Create(@"https://sweelcrmsystem.netlify.app/update.html");
        //        WebResponse wre = wrt.GetResponse();
        //        StreamReader sr = new StreamReader(wre.GetResponseStream());
        //        string v = sr.ReadLine();
        //        sb.Append(v);
        //        Version nowV = Assembly.GetExecutingAssembly().GetName().Version;
        //        Version lastestV = Version.Parse(v);
        //        if (nowV < lastestV)
        //        {
        //            sb.Append("\n\n是否前往更新？");
        //            DialogResult dr = MessageBox.Show(sb.ToString(), "发现更新", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //            if (dr == DialogResult.Yes)
        //            {
        //                Process.Start(@"https://sweelcrmsystem.netlify.app");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(sb.ToString(), "最新版本", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        sr.Dispose();
        //        wre.Dispose();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("网络连接失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        //    }
        //}

        //internal void OfficialWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Process.Start(@"https://sweelcrmsystem.netlify.app");
        //}

        internal void LoginDirectly_Click(object sender, EventArgs e)
        {
            if (File.Exists(Start.MyDataPath+"\\user\\SuperUser.ini") && File.ReadAllText(Start.MyDataPath+"\\user\\SuperUser.ini") == "不需要密码的超级用户")
            {
                WhichUserNameIs = "SuperUser";
                APPNotifyIcon.Visible = true;
                new MainForm().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("您不是超级用户没有这种权力", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void PathStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Start.MyDataPath);
        }

        internal void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new MainForm().Show();
        }
    }
}

