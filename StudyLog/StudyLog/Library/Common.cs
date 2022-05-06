﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLog.Library
{
    public class OptionFormArgs
    {
        public string filepath;
        public string filename;

        public OptionFormArgs()
        {
            filepath = Directory.GetCurrentDirectory();
            filename = DateTime.Now.ToString("D") + ".txt";
        }
    }

    public class Common
    {
    }
}
