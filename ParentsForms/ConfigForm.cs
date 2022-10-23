using System.Windows.Forms;

namespace 客户管理系统
{
    internal partial class ConfigForm : Form
    {
        internal ConfigForm()
        {
            InitializeComponent();
            MainFormOpacity_Box.Value = SweelConfig.Read("MainFormOpacity") * 100;
            DataSaveDirectory_Box.Text = SweelConfig.Read("DataSaveDirectory");
            DefaultDataFileName_Box.Text = SweelConfig.Read("DefaultDataFileName");
        }

        internal void SaveButton_Click(object sender, System.EventArgs e)
        {
            SweelConfig.Write("MainFormOpacity", MainFormOpacity_Box.Value/100);
            SweelConfig.Write("DataSaveDirectory", DataSaveDirectory_Box.Text);
            SweelConfig.Write("DefaultDataFileName", DefaultDataFileName_Box.Text);
            MessageBox.Show("部分设置重启程序后生效");
        }
    }
}