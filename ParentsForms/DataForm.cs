using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 客户管理系统
{
    internal partial class DataForm : Form
    {
        internal DataForm()
        {
            InitializeComponent();
            维护记录.DefaultCellStyle.NullValue = "点击查看";
        }
        /// <summary>
        /// 用于添加行数
        /// </summary>
        /// <param name="num"></param>
        internal void AddRowsNum(int num)
        {
            for (int times = 1; times < num; times++)
            {
                DataGridView.Rows.Add();
            }
        }
        /// <summary>
        /// 用于删除行数
        /// </summary>
        /// <param name="num"></param>
        internal void ClearRowsNum(int num)
        {
            if (num != DataGridView.Rows.Count - 1)
                DataGridView.Rows.RemoveAt(num);
            else
                MessageBox.Show("无法删除此行");
        }
        /// <summary>
        /// 添加行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void AddRowsNumItem_Click(object sender, EventArgs e)
        {
            AddRowsNum(2);
        }
        /// <summary>
        /// 删除行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void ClearRowsNumItem_Click(object sender, EventArgs e)
        {
            ClearRowsNum(DataGridView.CurrentRow.Index);
        }
        /// <summary>
        /// 清空某项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void ClearItem_Click(object sender, EventArgs e)
        {
            DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[DataGridView.CurrentCell.ColumnIndex].Value = "";
        }
        /// <summary>
        /// 用于其他类的传参
        /// </summary>
        internal void ReadDataToItem(int times, string CellName, string finalValue)
        {
            DataGridView.Rows[times].Cells[CellName].Value = SweelKey.Decryption(finalValue);
        }

        internal void 打开附件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object value = DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["附件"].Value;
            if (value != null)
            {
                string path = @value.ToString();
                if (path.Contains("\\") || path.Contains("."))
                {
                    if (File.Exists(path) || Directory.Exists(path) || path.Contains("."))
                    {
                        try
                        {
                            Process.Start(path);
                        }
                        catch (System.ComponentModel.Win32Exception)
                        {
                            DialogResult dr = MessageBox.Show("文件打开时发生了一个错误\n请确保设定了打开方式\n是否帮您打开文件所在的文件夹", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dr == DialogResult.Yes)
                            {
                                try
                                {
                                    Process.Start(Start.MyDataPath + "\\enclosure");
                                }
                                catch (System.ComponentModel.Win32Exception)
                                {
                                    MessageBox.Show("不要乱删文件夹哦");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("附件不存在");
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的路径");
                }
            }
            else
            {
                MessageBox.Show("附件中的路径不得为空");
            }
        }

        internal void 使用方法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打开方法：\n支持存放网站网址和文件路径\n建议不使用网站网址\n若要打开某一行的附件\n先点击某一行的任意一项\n确保附件中含有路径且路径中存在附件\n再右键选择打开附件\n\n添加方法：\n选定的文件将复制到enclosure文件夹", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void 添加附件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "所有文件|*",
                Title = "客户管理系统",
                InitialDirectory = Start.MyDataPath + "\\enclosure"
            };
            if (ofd.ShowDialog() == DialogResult.OK) { }
            if (ofd.FileName != "")
            {
                string PathFinalName = Path.GetFileName(ofd.FileName);//文件名
                StringBuilder sb = new StringBuilder();
                sb.Append(Start.MyDataPath);
                sb.Append("\\enclosure\\");
                //sb就是enclosure的路径
                if (!File.Exists(sb.ToString() + PathFinalName))
                {
                    sb.Append(PathFinalName);
                    File.Copy(ofd.FileName, sb.ToString());
                    DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["附件"].Value = sb.ToString();
                }
                else
                {
                    int number = 0;
                    while (true)
                    {
                        sb.Append("_");
                        if (!File.Exists(sb.ToString() + PathFinalName))
                        {
                            break;
                        }
                        number++;
                    }
                    File.Copy(ofd.FileName, sb.ToString() + PathFinalName);
                    DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["附件"].Value = sb.ToString() + PathFinalName;
                }
            }
        }

        internal void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["出生日期"].Value = "年月日";
            }
            if (e.ColumnIndex == 11)
            {
                MessageBox.Show("鼠标右键查看详情", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void DataSaveItem_Click(object sender, EventArgs e)
        {
            //姓名 性别 年龄 出生日期 身份证 护照 通行证 电话 微信 地址 附件
            //Name Gender Age BirthDate IDCard Passport PassCheck Telephone WeChat Address Attachment
            StringBuilder sb = new StringBuilder();
            sb.Append(Start.MyDataPath);
            sb.Append("\\");
            sb.Append(SweelConfig.Read("DataSaveDirectory"));
            sb.Append("\\");
            sb.Append(SweelConfig.Read("DefaultDataFileName"));
            try
            {
                StreamWriter sw = new StreamWriter(sb.ToString());
                for (int num = 1; num <= DataGridView.RowCount; num++)
                {
                    object NameValue = DataGridView.Rows[num - 1].Cells["姓名"].Value;
                    string Name = "";
                    if (NameValue != null)
                    {
                        Name = SweelKey.Encryption(NameValue.ToString());
                    }
                    object GenderValue = DataGridView.Rows[num - 1].Cells["性别"].Value;
                    string Gender = "";
                    if (GenderValue != null)
                    {
                        Gender = SweelKey.Encryption(GenderValue.ToString());
                    }
                    object AgeValue = DataGridView.Rows[num - 1].Cells["年龄"].Value;
                    string Age = "";
                    if (AgeValue != null)
                    {
                        Age = SweelKey.Encryption(AgeValue.ToString());
                    }
                    object BirthDateValue = DataGridView.Rows[num - 1].Cells["出生日期"].Value;
                    string BirthDate = "";
                    if (BirthDateValue != null)
                    {
                        BirthDate = SweelKey.Encryption(BirthDateValue.ToString());
                    }
                    object IDCardValue = DataGridView.Rows[num - 1].Cells["身份证"].Value;
                    string IDCard = "";
                    if (IDCardValue != null)
                    {
                        IDCard = SweelKey.Encryption(IDCardValue.ToString());
                    }
                    object PassportValue = DataGridView.Rows[num - 1].Cells["护照"].Value;
                    string Passport = "";
                    if (PassportValue != null)
                    {
                        Passport = SweelKey.Encryption(PassportValue.ToString());
                    }
                    object PassCheckValue = DataGridView.Rows[num - 1].Cells["通行证"].Value;
                    string PassCheck = "";
                    if (PassCheckValue != null)
                    {
                        PassCheck = SweelKey.Encryption(PassCheckValue.ToString());
                    }
                    object TelephoneValue = DataGridView.Rows[num - 1].Cells["电话"].Value;
                    string Telephone = "";
                    if (TelephoneValue != null)
                    {
                        Telephone = SweelKey.Encryption(TelephoneValue.ToString());
                    }
                    object WeChatValue = DataGridView.Rows[num - 1].Cells["微信"].Value;
                    string WeChat = "";
                    if (WeChatValue != null)
                    {
                        WeChat = SweelKey.Encryption(WeChatValue.ToString());
                    }
                    object AddressValue = DataGridView.Rows[num - 1].Cells["地址"].Value;
                    string Address = "";
                    if (AddressValue != null)
                    {
                        Address = SweelKey.Encryption(AddressValue.ToString());
                    }
                    object AttachmentValue = DataGridView.Rows[num - 1].Cells["附件"].Value;
                    string Attachment = "";
                    if (AttachmentValue != null)
                    {
                        Attachment = SweelKey.Encryption(AttachmentValue.ToString());
                    }
                    StringBuilder saveText = new StringBuilder();
                    saveText.Append(Name);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Gender);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Age);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(BirthDate);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(IDCard);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Passport);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(PassCheck);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Telephone);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(WeChat);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Address);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Attachment);
                    sw.WriteLine(saveText.ToString());
                }
                sw.Flush();
                sw.Dispose();
                MessageBox.Show("成功保存数据至"+SweelConfig.Read("DefaultDataFileName"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show("发生了一个错误\n原因可能是多次点击查看数据\n暂时无法保存，请等待后重试\n若频繁出现此警告，请多次点击保存按钮\n谢谢！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        internal void DataSaveAsItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog
            {
                Filter = "数据文件|*.crmdata",
                Title = "客户管理系统",
                InitialDirectory = Start.MyDataPath + "\\data"
            };
            if (sdf.ShowDialog() == DialogResult.OK) { }
            if (sdf.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sdf.FileName);
                for (int num = 1; num <= DataGridView.RowCount; num++)
                {
                    object NameValue = DataGridView.Rows[num - 1].Cells["姓名"].Value;
                    string Name = "";
                    if (NameValue != null)
                    {
                        Name = SweelKey.Encryption(NameValue.ToString());
                    }
                    object GenderValue = DataGridView.Rows[num - 1].Cells["性别"].Value;
                    string Gender = "";
                    if (GenderValue != null)
                    {
                        Gender = SweelKey.Encryption(GenderValue.ToString());
                    }
                    object AgeValue = DataGridView.Rows[num - 1].Cells["年龄"].Value;
                    string Age = "";
                    if (AgeValue != null)
                    {
                        Age = SweelKey.Encryption(AgeValue.ToString());
                    }
                    object BirthDateValue = DataGridView.Rows[num - 1].Cells["出生日期"].Value;
                    string BirthDate = "";
                    if (BirthDateValue != null)
                    {
                        BirthDate = SweelKey.Encryption(BirthDateValue.ToString());
                    }
                    object IDCardValue = DataGridView.Rows[num - 1].Cells["身份证"].Value;
                    string IDCard = "";
                    if (IDCardValue != null)
                    {
                        IDCard = SweelKey.Encryption(IDCardValue.ToString());
                    }
                    object PassportValue = DataGridView.Rows[num - 1].Cells["护照"].Value;
                    string Passport = "";
                    if (PassportValue != null)
                    {
                        Passport = SweelKey.Encryption(PassportValue.ToString());
                    }
                    object PassCheckValue = DataGridView.Rows[num - 1].Cells["通行证"].Value;
                    string PassCheck = "";
                    if (PassCheckValue != null)
                    {
                        PassCheck = SweelKey.Encryption(PassCheckValue.ToString());
                    }
                    object TelephoneValue = DataGridView.Rows[num - 1].Cells["电话"].Value;
                    string Telephone = "";
                    if (TelephoneValue != null)
                    {
                        Telephone = SweelKey.Encryption(TelephoneValue.ToString());
                    }
                    object WeChatValue = DataGridView.Rows[num - 1].Cells["微信"].Value;
                    string WeChat = "";
                    if (WeChatValue != null)
                    {
                        WeChat = SweelKey.Encryption(WeChatValue.ToString());
                    }
                    object AddressValue = DataGridView.Rows[num - 1].Cells["地址"].Value;
                    string Address = "";
                    if (AddressValue != null)
                    {
                        Address = SweelKey.Encryption(AddressValue.ToString());
                    }
                    object AttachmentValue = DataGridView.Rows[num - 1].Cells["附件"].Value;
                    string Attachment = "";
                    if (AttachmentValue != null)
                    {
                        Attachment = SweelKey.Encryption(AttachmentValue.ToString());
                    }
                    StringBuilder saveText = new StringBuilder();
                    saveText.Append(Name);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Gender);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Age);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(BirthDate);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(IDCard);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Passport);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(PassCheck);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Telephone);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(WeChat);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Address);
                    saveText.Append("%&*%#%*&%");
                    saveText.Append(Attachment);
                    sw.WriteLine(saveText.ToString());
                }
                sw.Flush();
                sw.Dispose();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.Columns[e.ColumnIndex].Name == "维护记录" && e.RowIndex >= 0)
            {
                object IDNumber = DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["身份证"].Value;
                if (IDNumber == null)
                {
                    MessageBox.Show("请补充客户的身份证");
                }
                else
                {
                    if (IDNumber.ToString() == "")
                    {
                        MessageBox.Show("请补充客户的身份证");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(Start.MyDataPath);
                        sb.Append("\\data\\MaintenanceRecord\\");
                        sb.Append(IDNumber.ToString());
                        sb.Append(".txt");
                        if (!File.Exists(sb.ToString()))
                        {
                            FileStream fs = File.Create(sb.ToString());
                            fs.Dispose();
                        }
                        Process.Start(sb.ToString());
                    }
                }
            }
        }
    }
}
