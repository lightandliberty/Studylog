using System;
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
            // filepath = Directory.GetCurrentDirectory();
            // 기존 코드 주석 처리
            //            filepath = StudyLog.Properties.Settings.Default.saveFolder == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\StudyLog";
            filepath = StudyLog.Properties.Settings.Default.saveFolder;
            filename = DateTime.Now.ToString("D") + ".txt";
        }
    }

    public class Common
    {
    }

    public class SettingFormArgs
    {
        public string hostIP;

        public SettingFormArgs()
        {
            hostIP = StudyLog.Properties.Settings.Default.hostIP;
        }
    }

}
