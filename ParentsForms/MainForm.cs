using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 客户管理系统
{
    internal partial class MainForm : Form
    {
        internal MainForm()
        {
            InitializeComponent();
            Width = SweelConfig.Read("MainFormWidth");
            Height = SweelConfig.Read("MainFormHeight");
            Opacity = SweelConfig.Read("MainFormOpacity");
            if (SweelConfig.Read("MainFormMaximized") == true)
                WindowState = FormWindowState.Maximized;
            WhichUserLabel.Alignment = ToolStripItemAlignment.Right;
            LoadProgressBar.Value = LoadProgressBar.Maximum;
        }

        internal void ConfigUpdate_Tick(object sender, EventArgs e)
        {
            SweelConfig.Write("MainFormWidth", Width);
            SweelConfig.Write("MainFormHeight", Height);
            if (WindowState == FormWindowState.Maximized)
            {
                SweelConfig.Write("MainFormMaximized", true);
            }
            else
            {
                SweelConfig.Write("MainFormMaximized", false);
            }
            if (LoadProgressBar.Value == LoadProgressBar.Maximum)
            {
                WhichUserLabel.Text = "用户名：" + LoginForm.WhichUserNameIs;
                TimeLabel.Text = "当前时间：" + DateTime.Now.ToString();
                LoadFinishLabel.Text = "加载完成";
            }
        }

        internal void ReadDataButton_Click(object sender, EventArgs e)
        {
            //姓名 性别 年龄 出生日期 身份证 护照 通行证 电话 微信 地址 附件
            //Name Gender Age BirthDate IDCard Passport PassCheck Telephone WeChat Address Attachment
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "数据文件|*.crmdata",//指定文件类型
                Title = "客户管理系统"
            };//打开选择文件对话框
            if (ofd.ShowDialog() == DialogResult.OK) { }//添加确认选择按钮
            if (ofd.FileName != "")
            {
                int totalLength = File.ReadAllLines(ofd.FileName).Length;
                if (MdiChildren.Length > 0)
                {
                    foreach (Form myForm in this.MdiChildren)
                        myForm.Close();
                }
                DataForm df = new DataForm
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                df.AddRowsNum(totalLength);
                df.Show();
                StreamReader sr = new StreamReader(ofd.FileName);
                for (int num = 1; num <= totalLength; num++)
                {
                    string[] textGroup = sr.ReadLine().Split(new string[] { "%&*%#%*&%" }, StringSplitOptions.None);
                    df.ReadDataToItem(num - 1, "姓名", textGroup[0].ToString());
                    if (textGroup.Length > 0)
                    {
                        df.ReadDataToItem(num - 1, "性别", textGroup[1].ToString());
                    }
                    if (textGroup.Length > 1)
                    {
                        df.ReadDataToItem(num - 1, "年龄", textGroup[2].ToString());
                    }
                    if (textGroup.Length > 2)
                    {
                        df.ReadDataToItem(num - 1, "出生日期", textGroup[3].ToString());
                    }
                    if (textGroup.Length > 3)
                    {
                        df.ReadDataToItem(num - 1, "身份证", textGroup[4].ToString());
                    }
                    if (textGroup.Length > 4)
                    {
                        df.ReadDataToItem(num - 1, "护照", textGroup[5].ToString());
                    }
                    if (textGroup.Length > 5)
                    {
                        df.ReadDataToItem(num - 1, "通行证", textGroup[6].ToString());
                    }
                    if (textGroup.Length > 6)
                    {
                        df.ReadDataToItem(num - 1, "电话", textGroup[7].ToString());
                    }
                    if (textGroup.Length > 7)
                    {
                        df.ReadDataToItem(num - 1, "微信", textGroup[8].ToString());
                    }
                    if (textGroup.Length > 8)
                    {
                        df.ReadDataToItem(num - 1, "地址", textGroup[9].ToString());
                    }
                    if (textGroup.Length > 9)
                    {
                        df.ReadDataToItem(num - 1, "附件", textGroup[10].ToString());
                    }
                }
            }
        }

        internal ConfigForm cf = null;
        internal void ConfigButton_Click(object sender, EventArgs e)
        {
            if (cf == null || cf.IsDisposed)
            {
                cf = new ConfigForm
                {
                    MdiParent = this
                };
                cf.Show();
            }
            else
            {
                cf.Dispose();
            }
        }

        internal void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        internal void SeeDataButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Start.MyDataPath);
            sb.Append("\\");
            sb.Append(SweelConfig.Read("DataSaveDirectory"));
            sb.Append("\\");
            sb.Append(SweelConfig.Read("DefaultDataFileName"));
            if (File.Exists(sb.ToString()))
            {
                int totalLength = File.ReadAllLines(sb.ToString()).Length;
                if (MdiChildren.Length > 0)
                {
                    foreach (Form myForm in this.MdiChildren)
                        myForm.Close();
                }
                DataForm df = new DataForm
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                df.AddRowsNum(totalLength);
                df.Show();
                StreamReader sr = new StreamReader(sb.ToString());
                for (int num = 1; num <= totalLength; num++)
                {
                    string[] textGroup = sr.ReadLine().Split(new string[] { "%&*%#%*&%" }, StringSplitOptions.None);
                    df.ReadDataToItem(num - 1, "姓名", textGroup[0].ToString());
                    if (textGroup.Length > 0)
                    {
                        df.ReadDataToItem(num - 1, "性别", textGroup[1].ToString());
                    }
                    if (textGroup.Length > 1)
                    {
                        df.ReadDataToItem(num - 1, "年龄", textGroup[2].ToString());
                    }
                    if (textGroup.Length > 2)
                    {
                        df.ReadDataToItem(num - 1, "出生日期", textGroup[3].ToString());
                    }
                    if (textGroup.Length > 3)
                    {
                        df.ReadDataToItem(num - 1, "身份证", textGroup[4].ToString());
                    }
                    if (textGroup.Length > 4)
                    {
                        df.ReadDataToItem(num - 1, "护照", textGroup[5].ToString());
                    }
                    if (textGroup.Length > 5)
                    {
                        df.ReadDataToItem(num - 1, "通行证", textGroup[6].ToString());
                    }
                    if (textGroup.Length > 6)
                    {
                        df.ReadDataToItem(num - 1, "电话", textGroup[7].ToString());
                    }
                    if (textGroup.Length > 7)
                    {
                        df.ReadDataToItem(num - 1, "微信", textGroup[8].ToString());
                    }
                    if (textGroup.Length > 8)
                    {
                        df.ReadDataToItem(num - 1, "地址", textGroup[9].ToString());
                    }
                    if (textGroup.Length > 9)
                    {
                        df.ReadDataToItem(num - 1, "附件", textGroup[10].ToString());
                    }
                }
            }
        }
    }
}