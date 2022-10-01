using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileToFolder
{
    internal class LogHandler
    {
        private string logName;
        private string logFullPath;
        public StreamWriter log;
        private OptionsArg arg;

        public LogHandler(OptionsArg arg)
        {
            this.arg = arg;
            string pathNow = Directory.GetCurrentDirectory();
            string now = DateTime.Now.ToString("yyyyMMdd_HHmm");
            logName = now + ".log";   //以當時為名的log
            bool isExists = System.IO.Directory.Exists("FileToFolder_log");
            if (!isExists)
                System.IO.Directory.CreateDirectory("FileToFolder_log");  //沒有資料夾就產生
            logFullPath = Path.Combine("FileToFolder_log", logName);
            if (!File.Exists(logFullPath))   //沒有log就產生一log
            {
                log = new StreamWriter(logFullPath);
                log.WriteLine("======log開始======");
                log.WriteLine("執行時間:" + now);
                log.WriteLine("從::" + arg.FromPath);
                log.WriteLine("到=>" + arg.ToPath);
                if (arg.ModifiedTime)
                    log.WriteLine("依據檔案修改時間");
                else
                    log.WriteLine("依據檔案存取時間");
                log.WriteLine("處理時間區間大於等於" + arg.StartDate.ToString("yyyyMMdd"));
                log.WriteLine("處理時間區間小於" + arg.EndDate.ToString("yyyyMMdd"));
                if (arg.SubFolder)
                    log.WriteLine("並在目的產生yyyyMM的資料夾");
            }
        }

        public void LogEnd()
        {
            log.WriteLine("======log結束======");
            log.Flush();
            log.Close();
            log.Dispose();
        }
    }
}