using System;
using System.Collections.Generic;
using System.Text;

namespace FileToFolder
{
    internal class OptionsArg
    {
        public string FromPath { get; set; }

        public string ToPath { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool ModifiedTime { get; set; }

        public bool Move { get; set; }

        public bool SubFolder { get; set; }
    }
}