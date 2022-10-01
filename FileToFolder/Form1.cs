using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileToFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar.Visible = false;
            progressBar.Step = 1;
        }

        /*
            private int setProcessBarValue;

            public int SetProcessBarValue
            {
                get { return progressBar.Value; }
                set
                {
                    progressBar.Value = value;
                    progressBar.PerformStep();
                }
            }

            public void ProcessBarGo()
            {
                progressBar.PerformStep();
            }

            public void ProcessBarVisable(bool visible)
            {
                progressBar.Visible = visible;
            }

            public void SetProcessBarRange(int max, int min)
            {
                progressBar.Minimum = min;
                progressBar.Maximum = max;
            }
        */

        #region 路徑瀏覽

        private void fromPathButton_Click(object sender, EventArgs e)
        {
            if (fromFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.fromPathTextBox.Text = fromFolderBrowserDialog.SelectedPath;
            }
        }

        private void toPathButton_Click(object sender, EventArgs e)
        {
            if (toFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.toPathTextBox.Text = toFolderBrowserDialog.SelectedPath;
            }
        }

        #endregion 路徑瀏覽

        private OptionsArg optionArg = new OptionsArg();

        private void goButton_Click(object sender, EventArgs e)
        {
            #region 路徑與日期判斷

            if (!(Directory.Exists(fromPathTextBox.Text)) || !(Directory.Exists(toPathTextBox.Text)))
            {
                MessageBox.Show("來源或目的路徑有誤!!");
                return;
            }
            else if (fromPathTextBox.Text == toPathTextBox.Text)
            {
                MessageBox.Show("來源或目的路徑相同!!");
                return;
            }

            if (this.endDatePicker.Value.Date < this.startDatePicker.Value.Date)
            {
                MessageBox.Show("起日不可大於迄日");
                return;
            }

            #endregion 路徑與日期判斷

            optionArg.FromPath = this.fromPathTextBox.Text;
            optionArg.ToPath = this.toPathTextBox.Text;
            optionArg.StartDate = this.startDatePicker.Value.Date;
            optionArg.EndDate = this.endDatePicker.Value.Date.AddDays(1);
            optionArg.ModifiedTime = (this.modifiedRadioButton.Checked) ? true : false;
            optionArg.Move = (this.moveRadioButton.Checked) ? true : false;
            optionArg.SubFolder = (this.subFolderCheckBox.Checked) ? true : false;

            #region 有選子目錄 產生資料夾

            if (optionArg.SubFolder)
            {
                string subFolderPath = string.Empty;
                DateTime startTime = optionArg.StartDate;
                while (startTime < optionArg.EndDate)
                {
                    subFolderPath = Path.Combine(optionArg.ToPath, startTime.ToString("yyyyMM"));
                    if (!Directory.Exists(subFolderPath))
                        Directory.CreateDirectory(subFolderPath);
                    startTime = startTime.AddMonths(1);
                }
            }

            #endregion 有選子目錄 產生資料夾

            //foreach (Control c in this.Controls)
            //    c.Enabled = false;
            WorkOnFiles work = new WorkOnFiles(optionArg);
            work.ProgressBarControl(progressBar);

            //progressBar.Enabled = true;
            //progressBar.Visible = true;

            if (optionArg.Move)
                work.MoveFiles();
            else
                work.CopyFiles();


            foreach (Control c in this.Controls)
                c.Enabled = true;
            //progressBar.Visible = false;

            #region 刪除空資料夾

            if (optionArg.SubFolder)
            {
                string subFolderPath = string.Empty;
                DateTime startTime = optionArg.StartDate;
                while (startTime < optionArg.EndDate)
                {
                    subFolderPath = Path.Combine(optionArg.ToPath, startTime.ToString("yyyyMM"));
                    if (Directory.Exists(subFolderPath))
                        if (Directory.GetFiles(subFolderPath).Length == 0)
                            Directory.Delete(subFolderPath);

                    startTime = startTime.AddMonths(1);
                }
            }

            #endregion 刪除空資料夾
        }
    }
}