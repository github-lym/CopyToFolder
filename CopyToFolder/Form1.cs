using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MoveToFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pBar.Visible = false;  //進度條  先隱藏
        }

        private void from_btn_Click(object sender, EventArgs e)   //開啟瀏覽視窗選擇資料夾
        {
            if (from_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.from_textBox.Text = from_folderBrowserDialog.SelectedPath;
            }
        }

        private void to_btn_Click(object sender, EventArgs e)
        {
            if (to_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.to_textBox.Text = to_folderBrowserDialog.SelectedPath;
            }
        }

        private void exe_btn_Click(object sender, EventArgs e)
        {
            uint count = 0;  //移動的檔案個數
            String logname = DateTime.Now.ToString("yyyyMMdd") + "log.txt";   //以當日為名的log
            from_textBox.Enabled = false;
            to_textBox.Enabled = false;
            String from_path = from_textBox.Text.ToString();
            String to_path = to_textBox.Text.ToString();
            StreamWriter log;

            if (!File.Exists(logname))   //沒有log就產生一log
            {
                log = new StreamWriter(logname);
                log.Close();
            }

            //進度條相關設定
            pBar.Visible = true;
            pBar.Minimum = 1;
            pBar.Value = 1;
            pBar.Step = 1;

            if (dateTime_before.Value.Date < dateTime_after.Value.Date)
            {
                MessageBox.Show("Error:Date!!");
                return;
            }

            log = File.AppendText(logname);  //開始以附加型式寫log

            if (Directory.Exists(from_path) && Directory.Exists(to_path))   //檢查來源跟目的的資料夾都存在
            {
                DirectoryInfo from_folder = new DirectoryInfo(from_path);
                FileInfo[] dfiles = from_folder.GetFiles("*");  //抓取來源資料夾底下所有檔案
                pBar.Maximum = dfiles.Length;  //進度條最大值就是所有檔案數量
                DateTime fileTime = DateTime.Now;
                foreach (FileInfo dfile in dfiles)   //開始分析所有檔案
                {
                    if (this.rb_access.Checked == true)
                        fileTime = File.GetLastAccessTime(dfile.FullName.ToString()).Date;   //查看檔案存取日期
                    if (this.rb_modified.Checked == true)
                        fileTime = File.GetLastWriteTime(dfile.FullName.ToString()).Date;   //查看檔案修改日期

                    if (fileTime <= dateTime_before.Value.Date && fileTime >= dateTime_after.Value.Date)   //日期比選擇時間早的話就執行
                    {
                        //因為Framework2不能用path.combine的指令  所以只好用底下的判斷
                        if (to_path.Substring(to_path.Length - 1, 1) != "\\" && dfile.Name.Substring(0, 1) != "\\")
                        {
                            if (this.rb_move.Checked == true)
                            {
                                try
                                {
                                    if (this.subFolder_checkBox.Checked == true)
                                    {
                                        if (!Directory.Exists(to_path + "\\" + fileTime.ToString("yyyyMM")))
                                            Directory.CreateDirectory(to_path + "\\" + fileTime.ToString("yyyyMM"));
                                        File.Move(dfile.FullName.ToString(), (to_path + "\\" + fileTime.ToString("yyyyMM") + "\\" + dfile.Name).ToString());
                                    }
                                    else
                                        File.Move(dfile.FullName.ToString(), (to_path + "\\" + dfile.Name).ToString());
                                }
                                catch (IOException ex)
                                {
                                    log.WriteLine(DateTime.Now.ToString("yyyyMMdd-H:mm:ss") + "->");  //寫入時間
                                    log.WriteLine((to_path + "\\" + dfile.Name).ToString() + " is already exist!");
                                    log.Close();
                                    MessageBox.Show((to_path + "\\" + dfile.Name).ToString() + " is already exist\n\n\n" + ex.ToString());
                                    return;
                                }
                            }

                            if (this.rb_copy.Checked == true)
                            {
                                if (this.subFolder_checkBox.Checked == true)
                                {
                                    if (!Directory.Exists(to_path + "\\" + fileTime.ToString("yyyyMM")))
                                        Directory.CreateDirectory(to_path + "\\" + fileTime.ToString("yyyyMM"));
                                    File.Copy(dfile.FullName.ToString(), (to_path + "\\" + fileTime.ToString("yyyyMM") + "\\" + dfile.Name).ToString(), true);
                                }
                                else
                                    File.Copy(dfile.FullName.ToString(), (to_path + "\\" + dfile.Name).ToString(), true);
                            }
                        }
                        else
                        {
                            if (this.rb_move.Checked == true)
                            {
                                try
                                {
                                    if (this.subFolder_checkBox.Checked == true)
                                    {
                                        if (!Directory.Exists(to_path + "\\" + fileTime.ToString("yyyyMM")))
                                            Directory.CreateDirectory(to_path + "\\" + fileTime.ToString("yyyyMM"));
                                        File.Move(dfile.FullName.ToString(), (to_path + "\\" + fileTime.ToString("yyyyMM") + "\\" + dfile.Name).ToString());
                                    }
                                    else
                                        File.Move(dfile.FullName.ToString(), (to_path + dfile.Name).ToString());
                                }
                                catch (IOException ex)
                                {
                                    log.WriteLine(DateTime.Now.ToString("yyyyMMdd-H:mm:ss") + "->");  //寫入時間
                                    log.WriteLine((to_path + dfile.Name).ToString() + " is already exist");
                                    log.Close();
                                    MessageBox.Show((to_path + dfile.Name).ToString() + " is already exist\n\n\n" + ex.ToString());
                                    return;
                                }
                            }

                            if (this.rb_copy.Checked == true)
                            {
                                if (this.subFolder_checkBox.Checked == true)
                                {
                                    if (!Directory.Exists(to_path + "\\" + fileTime.ToString("yyyyMM")))
                                        Directory.CreateDirectory(to_path + "\\" + fileTime.ToString("yyyyMM"));
                                    File.Copy(dfile.FullName.ToString(), (to_path + "\\" + fileTime.ToString("yyyyMM") + "\\" + dfile.Name).ToString(), true);
                                }
                                else
                                    File.Copy(dfile.FullName.ToString(), (to_path + dfile.Name).ToString(), true);  //已存在檔案則覆蓋
                            }
                        }

                        count++;  //移動一檔案  數量加一
                    }
                    pBar.PerformStep();  //進度條也前進一步
                }
                from_textBox.Enabled = true;
                to_textBox.Enabled = true;
                pBar.Visible = false;  //移動完進度條隱藏

                log.WriteLine(DateTime.Now.ToString("yyyyMMdd-H:mm:ss") + "->");  //寫入執行完時間

                log.WriteLine("  Total " + dfiles.Length.ToString() + " file(s) ");  //總共讀到的檔案數量
                if (this.rb_move.Checked == true)
                    log.WriteLine("  Move " + count + " file(s) ");   //移動的檔案數量
                if (this.rb_copy.Checked == true)
                    log.WriteLine("  Copy " + count + " file(s) ");   //拷貝的檔案數量
                log.WriteLine("from " + from_path + " to " + to_path); //補來源和目的資料夾
                if (this.rb_access.Checked == true)
                {
                    log.WriteLine("  LastAccessTime after " + dateTime_after.Value.Date.ToString("yyyy-MM-dd"));  //拿來比較的基準時間(最後存取時間)
                    log.WriteLine("  LastAccessTime before " + dateTime_before.Value.Date.ToString("yyyy-MM-dd"));  //拿來比較的基準時間(最後存取時間)
                }

                if (this.rb_modified.Checked == true)
                {
                    log.WriteLine("  LastWriteTime after " + dateTime_after.Value.Date.ToString("yyyy-MM-dd"));  //拿來比較的基準時間(最後修改時間)
                    log.WriteLine("  LastWriteTime before " + dateTime_before.Value.Date.ToString("yyyy-MM-dd"));  //拿來比較的基準時間(最後修改時間)
                }

                log.Close();
                MessageBox.Show("DONE!");
            }
            else
            {
                MessageBox.Show("path is wrong!");
                from_textBox.Enabled = true;
                to_textBox.Enabled = true;
                return;
            }
        }
    }
}