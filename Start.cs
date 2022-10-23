using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace 客户管理系统
{
    internal static class Start
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();//启用可视化样式
            Application.SetCompatibleTextRenderingDefault(false);//取消设置兼容文本呈现默认值
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("程序已经运行了，请查看系统托盘！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                if (!Directory.Exists(MyDataPath))
                {
                    Directory.CreateDirectory(MyDataPath);
                }

                if (!Directory.Exists(MyDataPath+"\\user"))
                {
                    Directory.CreateDirectory(MyDataPath+"\\user");
                }
                if (!Directory.Exists(MyDataPath+"\\data"))
                {
                    Directory.CreateDirectory(MyDataPath+"\\data");
                }
                if (!Directory.Exists(MyDataPath+"\\data\\MaintenanceRecord"))
                {
                    Directory.CreateDirectory(MyDataPath+"\\data\\MaintenanceRecord");
                }
                if (!Directory.Exists(MyDataPath+"\\enclosure"))
                {
                    Directory.CreateDirectory(MyDataPath+"\\enclosure");
                }
                if (!File.Exists(MyDataPath+"\\config.json"))
                {
                    SweelExtract.Extract("客户管理系统.Resources.config.json", MyDataPath+"\\config.json");
                }
                if (!File.Exists(MyDataPath + "\\data\\Default.crmdata"))
                {
                    StreamWriter sw = new StreamWriter(MyDataPath + "\\data\\Default.crmdata");
                    sw.Dispose();
                }
                //string path = MyDataPath + "\\UpdateLog_v" +Assembly.GetExecutingAssembly().GetName().Version.ToString()+".txt";
                //string content = "更新日志：\nv3.0.0.0\n\n1.将客户性别列从文本更改为组合框\n2.添加超级用户可以直接登录系统\n3.修改登录UI\n4.更改设置按钮的图标\n5.添加软件更新系统\n6.托盘菜单添加官网超链接\n7.混淆代码进行加密\n8.将数据文件进行加密处理\n9.添加查看数据时自动打开Default.crmdata的功能\n10.更改客户维护记录\n11.内嵌调用部分类库\n12.将数据文件夹转移到我的文档\n13.更改检查更新的位置\n14.修复一系列错误\n\n下次是否提醒？";
                //if (!File.Exists(path))
                //{
                //    File.WriteAllText(path, content);
                //    DialogResult sr = MessageBox.Show(content, "日志",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                //    if (sr == DialogResult.Yes)
                //    {
                //        File.Delete(path);
                //    }
                //}
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string resource = "客户管理系统.Resources.Newtonsoft.Json.dll";
                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                    {
                        byte[] assData = new byte[stream.Length];
                        stream.Read(assData, 0, assData.Length);
                        return Assembly.Load(assData);
                    }
                };//内嵌类库
                Application.Run(new LoginForm());//运行登录窗体
            }
        }
        internal static string MyDataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\SweelCRM";
    }
}