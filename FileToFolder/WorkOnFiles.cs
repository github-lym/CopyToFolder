using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileToFolder
{
    internal class WorkOnFiles
    {
        private FileInfo[] allFiles;
        private DateTime fileTime;
        private int flag;
        private OptionsArg arg;
        private ProgressBar progressBar;
        private LogHandler logHandler;
        private string destinationFile;

        public WorkOnFiles(OptionsArg arg)
        {
            this.arg = arg;
            if (arg.ModifiedTime && arg.SubFolder)
                flag = 0;
            else if (!arg.ModifiedTime && arg.SubFolder)
                flag = 1;
            else if (arg.ModifiedTime && !arg.SubFolder)
                flag = 2;
            else if (!arg.ModifiedTime && !arg.SubFolder)
                flag = 3;
            logHandler = new LogHandler(arg);
        }

        public void ProgressBarControl(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }

        #region 移動檔案

        public void MoveFiles()
        {
            DirectoryInfo fromFolder = new DirectoryInfo(arg.FromPath);
            allFiles = fromFolder.GetFiles("*");  //抓取來源資料夾底下所有檔案

            int num = 0;
            int total = 0;
            progressBar.Minimum = num;
            progressBar.Maximum = allFiles.Length;
            progressBar.Enabled = true;
            progressBar.Visible = true;
            logHandler.log.WriteLine("以移動的方式處理");
            try
            {
                switch (flag)
                {
                    case 0:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastWriteTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                                if (!File.Exists(destinationFile))
                                {
                                    File.Move(file.FullName, destinationFile);
                                    num++;
                                }
                                else
                                    logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            }
                            progressBar.Value = ++total;
                        }

                        break;

                    case 1:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastAccessTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                                if (!File.Exists(destinationFile))
                                {
                                    File.Move(file.FullName, destinationFile);
                                    num++;
                                }
                                else
                                    logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    case 2:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastWriteTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                destinationFile = Path.Combine(arg.ToPath, file.Name);
                                if (!File.Exists(destinationFile))
                                {
                                    File.Move(file.FullName, destinationFile);
                                    num++;
                                }
                                else
                                    logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    case 3:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastAccessTime(file.FullName).Date;
                            destinationFile = Path.Combine(arg.ToPath, file.Name);
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                if (!File.Exists(destinationFile))
                                {
                                    File.Move(file.FullName, destinationFile);
                                    num++;
                                }
                                else
                                    logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (IOException ex)
            {
                logHandler.log.WriteLine(DateTime.Now.ToString("yyyyMMdd-HH:mm:ss.fff") + "->");  //寫入時間
                logHandler.log.WriteLine("******" + ex.GetType().Name.ToString());
            }
            finally
            {
                progressBar.Value = progressBar.Maximum;
                logHandler.log.WriteLine("總共移動了" + num + "個檔案");
                logHandler.LogEnd();
            }
        }

        #endregion 移動檔案

        #region 複製檔案

        public void CopyFiles()
        {
            DirectoryInfo fromFolder = new DirectoryInfo(arg.FromPath);
            allFiles = fromFolder.GetFiles("*");  //抓取來源資料夾底下所有檔案

            int num = 0;
            int total = 0;
            progressBar.Minimum = num;
            progressBar.Maximum = allFiles.Length;
            progressBar.Enabled = true;
            progressBar.Visible = true;
            logHandler.log.WriteLine("以移動的方式處理");
            try
            {
                switch (flag)
                {
                    case 0:
                        foreach (FileInfo file in allFiles)
                        {
                            destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                            fileTime = File.GetLastWriteTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                File.Copy(file.FullName, destinationFile, true);
                                num++;
                            }
                            progressBar.Value = ++total;
                        }

                        break;

                    case 1:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastAccessTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                                File.Copy(file.FullName, destinationFile, true);
                                num++;
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    case 2:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastWriteTime(file.FullName).Date;
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                destinationFile = Path.Combine(arg.ToPath, file.Name);
                                File.Copy(file.FullName, destinationFile, true);
                                num++;
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    case 3:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = File.GetLastAccessTime(file.FullName).Date;
                            destinationFile = Path.Combine(arg.ToPath, file.Name);
                            if (fileTime >= arg.StartDate && fileTime < arg.EndDate)
                            {
                                File.Copy(file.FullName, destinationFile, true);
                                num++;
                            }
                            progressBar.Value = ++total;
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (IOException ex)
            {
                logHandler.log.WriteLine(DateTime.Now.ToString("yyyyMMdd-HH:mm:ss.fff") + "->");  //寫入時間
                logHandler.log.WriteLine("******" + ex.GetType().Name.ToString());
            }
            finally
            {
                progressBar.Value = progressBar.Maximum;
                logHandler.log.WriteLine("總共複製了" + num + "個檔案");
                logHandler.LogEnd();
            }
        }

        #endregion 複製檔案
    }
}