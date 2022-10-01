using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace FileToFolder
{
    internal class WorkOnFiles
    {
        private FileInfo[] allFiles;
        private DateTime fileTime;
        private int flag;
        private OptionsArg arg;
        private ProgressBar numProgressBar;
        private ProgressBar sizeProgressBar;
        private LogHandler logHandler;
        private string destinationFile;

        public delegate void ProgressChangeDelegate(double Percentage, ref bool Cancel);
        public delegate void Completedelegate();

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
        }

        public void NumProgressBarControl(ProgressBar nprogressBar)
        {
            this.numProgressBar = nprogressBar;
        }
        public void SizeProgressBarControl(ProgressBar sprogressBar)
        {
            this.sizeProgressBar = sprogressBar;
        }

        class CustomFileCopier
        {
            public CustomFileCopier(string Source, string Dest, ProgressBar PBar)
            {
                this.SourceFilePath = Source;
                this.DestFilePath = Dest;
                this.PBar = PBar;

                OnProgressChanged += delegate { };
                OnComplete += delegate { };
            }

            public void Copy()
            {
                byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
                bool cancelFlag = false;
                PBar.Visible = true;
                using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read))
                {
                    long fileLength = source.Length;
                    using (FileStream dest = new FileStream(DestFilePath, FileMode.Create, FileAccess.Write))
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;
                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            double percentage = (double)totalBytes * 100.0 / fileLength;

                            dest.Write(buffer, 0, currentBlockSize);
                            cancelFlag = false;
                            OnProgressChanged(percentage, ref cancelFlag);
                            PBar.Value = (int)percentage;
                            if (cancelFlag == true)
                            {
                                // Delete dest file here
                                break;
                            }
                        }
                    }
                }

                OnComplete();
            }

            public string SourceFilePath { get; set; }
            public string DestFilePath { get; set; }
            public ProgressBar PBar { get; set; }


            public event ProgressChangeDelegate OnProgressChanged;
            public event Completedelegate OnComplete;
        }

        #region 前置處理        
        public void Run()
        {
            logHandler = new LogHandler(arg);

            DirectoryInfo fromFolder = new DirectoryInfo(arg.FromPath);
            //抓取來源資料夾底下符合條件所有檔案            
            if (arg.ModifiedTime)
                allFiles = fromFolder.GetFiles("*").Where(w => w.LastWriteTime.Date >= arg.StartDate && w.LastWriteTime.Date <= arg.EndDate).ToArray();
            else
                allFiles = fromFolder.GetFiles("*").Where(w => w.LastAccessTime.Date >= arg.StartDate && w.LastAccessTime.Date <= arg.EndDate).ToArray();

            numProgressBar.Visible = true;
            if (arg.Move)
                MoveFiles();
            else
                CopyFiles();
        }
        #endregion

        #region 移動檔案

        public void MoveFiles()
        {
            int num = 0;
            int total = 0;
            numProgressBar.Minimum = num;
            numProgressBar.Maximum = allFiles.Length;
            numProgressBar.Enabled = true;
            logHandler.log.WriteLine("以移動的方式處理");

            try
            {
                switch (flag)
                {
                    case 0:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = file.LastWriteTime;
                            destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                            if (!File.Exists(destinationFile))
                            {
                                //File.Move(file.FullName, destinationFile);
                                var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                                cfc.Copy();
                                File.Delete(file.FullName);
                                num++;
                            }
                            else
                                logHandler.log.WriteLine("******** " + file.Name + "已經存在");

                            numProgressBar.Value = ++total;
                        }
                        break;

                    case 1:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = file.LastAccessTime;
                            destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                            if (!File.Exists(destinationFile))
                            {
                                //File.Move(file.FullName, destinationFile);
                                var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                                cfc.Copy();
                                File.Delete(file.FullName);
                                num++;
                            }
                            else
                                logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            numProgressBar.Value = ++total;
                        }
                        break;

                    case 2:
                    case 3:
                        foreach (FileInfo file in allFiles)
                        {
                            destinationFile = Path.Combine(arg.ToPath, file.Name);
                            if (!File.Exists(destinationFile))
                            {
                                //File.Move(file.FullName, destinationFile);
                                var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                                cfc.Copy();
                                File.Delete(file.FullName);
                                num++;
                            }
                            else
                                logHandler.log.WriteLine("******** " + file.Name + "已經存在");
                            numProgressBar.Value = ++total;
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
                numProgressBar.Value = numProgressBar.Maximum;
                logHandler.log.WriteLine("總共移動了" + num + "個檔案");
                logHandler.LogEnd();
            }
        }

        #endregion 移動檔案

        #region 複製檔案

        public void CopyFiles()
        {
            int num = 0;
            int total = 0;
            numProgressBar.Minimum = num;
            numProgressBar.Maximum = allFiles.Length;
            numProgressBar.Enabled = true;
            logHandler.log.WriteLine("以移動的方式處理");

            try
            {
                switch (flag)
                {
                    case 0:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = file.LastWriteTime;
                            destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                            var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                            cfc.Copy();
                            //File.Copy(file.FullName, destinationFile, true);
                            num++;
                            numProgressBar.Value = ++total;
                        }
                        break;

                    case 1:
                        foreach (FileInfo file in allFiles)
                        {
                            fileTime = file.LastAccessTime;
                            destinationFile = Path.Combine(Path.Combine(arg.ToPath, fileTime.ToString("yyyyMM")), file.Name);
                            var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                            cfc.Copy();
                            //File.Copy(file.FullName, destinationFile, true);
                            num++;
                            numProgressBar.Value = ++total;
                        }
                        break;

                    case 2:
                    case 3:
                        foreach (FileInfo file in allFiles)
                        {
                            destinationFile = Path.Combine(arg.ToPath, file.Name);
                            var cfc = new CustomFileCopier(file.FullName, destinationFile, sizeProgressBar);
                            cfc.Copy();
                            //File.Copy(file.FullName, destinationFile, true);                            
                            num++;
                            numProgressBar.Value = ++total;
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
                numProgressBar.Value = numProgressBar.Maximum;
                logHandler.log.WriteLine("總共複製了" + num + "個檔案");
                logHandler.LogEnd();
            }
        }

        #endregion 複製檔案
    }
}