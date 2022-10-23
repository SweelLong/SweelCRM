
namespace 客户管理系统
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.MainFormOpacity = new System.Windows.Forms.Label();
            this.MainFormOpacity_Box = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataSaveDirectory = new System.Windows.Forms.Label();
            this.DataSaveDirectory_Box = new System.Windows.Forms.TextBox();
            this.DefaultDataFileName = new System.Windows.Forms.Label();
            this.DefaultDataFileName_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormOpacity_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormOpacity
            // 
            this.MainFormOpacity.AutoSize = true;
            this.MainFormOpacity.Font = new System.Drawing.Font("华文中宋", 9F);
            this.MainFormOpacity.Location = new System.Drawing.Point(12, 57);
            this.MainFormOpacity.Name = "MainFormOpacity";
            this.MainFormOpacity.Size = new System.Drawing.Size(134, 17);
            this.MainFormOpacity.TabIndex = 2;
            this.MainFormOpacity.Text = "主窗体透明度(%)：";
            // 
            // MainFormOpacity_Box
            // 
            this.MainFormOpacity_Box.Location = new System.Drawing.Point(154, 54);
            this.MainFormOpacity_Box.Name = "MainFormOpacity_Box";
            this.MainFormOpacity_Box.Size = new System.Drawing.Size(95, 25);
            this.MainFormOpacity_Box.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Snow;
            this.SaveButton.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 33);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataSaveDirectory
            // 
            this.DataSaveDirectory.AutoSize = true;
            this.DataSaveDirectory.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSaveDirectory.Location = new System.Drawing.Point(11, 88);
            this.DataSaveDirectory.Name = "DataSaveDirectory";
            this.DataSaveDirectory.Size = new System.Drawing.Size(173, 17);
            this.DataSaveDirectory.TabIndex = 10;
            this.DataSaveDirectory.Text = "保存数据的文件夹名称：";
            // 
            // DataSaveDirectory_Box
            // 
            this.DataSaveDirectory_Box.Location = new System.Drawing.Point(12, 115);
            this.DataSaveDirectory_Box.Name = "DataSaveDirectory_Box";
            this.DataSaveDirectory_Box.Size = new System.Drawing.Size(237, 25);
            this.DataSaveDirectory_Box.TabIndex = 11;
            // 
            // DefaultDataFileName
            // 
            this.DefaultDataFileName.AutoSize = true;
            this.DefaultDataFileName.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DefaultDataFileName.Location = new System.Drawing.Point(12, 151);
            this.DefaultDataFileName.Name = "DefaultDataFileName";
            this.DefaultDataFileName.Size = new System.Drawing.Size(143, 17);
            this.DefaultDataFileName.TabIndex = 12;
            this.DefaultDataFileName.Text = "默认数据文件名称：";
            // 
            // DefaultDataFileName_Box
            // 
            this.DefaultDataFileName_Box.Location = new System.Drawing.Point(12, 180);
            this.DefaultDataFileName_Box.Name = "DefaultDataFileName_Box";
            this.DefaultDataFileName_Box.Size = new System.Drawing.Size(237, 25);
            this.DefaultDataFileName_Box.TabIndex = 13;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(270, 218);
            this.Controls.Add(this.DefaultDataFileName_Box);
            this.Controls.Add(this.DefaultDataFileName);
            this.Controls.Add(this.DataSaveDirectory_Box);
            this.Controls.Add(this.DataSaveDirectory);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MainFormOpacity_Box);
            this.Controls.Add(this.MainFormOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.MainFormOpacity_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainFormOpacity;
        private System.Windows.Forms.NumericUpDown MainFormOpacity_Box;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DataSaveDirectory;
        private System.Windows.Forms.TextBox DataSaveDirectory_Box;
        private System.Windows.Forms.Label DefaultDataFileName;
        private System.Windows.Forms.TextBox DefaultDataFileName_Box;
    }
}