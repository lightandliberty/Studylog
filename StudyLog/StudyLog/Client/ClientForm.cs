using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyLog.Library;

namespace StudyLog.Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public SettingFormArgs settingFormArgs;

        private void ClientForm_Load(object sender, EventArgs e)
        {
            settingFormArgs = new SettingFormArgs();
            this.connectPN.TextString = settingFormArgs.hostIP + "\r\n접속";
        }

        private void 접속Ip설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenIPSettingForm();

        }

        private void GetArgs(SettingFormArgs e)
        {
            this.settingFormArgs = e;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void changeIPBtn_Click(object sender, EventArgs e)
        {
            OpenIPSettingForm();
        }

        private void OpenIPSettingForm()
        {
            SettingForm settingForm = new SettingForm();
            settingForm.GetSettingFormArgs += GetArgs;
            settingForm.ShowDialog();

            this.connectPN.TextString = settingFormArgs.hostIP + "\r\n접속";


            // (new SettingForm()).ShowDialog(); 어차피 appsetting.config에 저장하여 로드하므로, 이렇게 해도 된다.
            //  settingFormArgs.hostIP = StudyLog.Properties.Settings.Default.hostIP; // 어차피 appsetting.config에 저장하여 로드하므로, 이렇게 해도 된다.

        }

    }
}
