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

namespace StudyLog
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        public delegate void GetArgs(OptionFormArgs s);
        public GetArgs GetOptionFormArgs;  // 대리자 객체 생성

        public OptionFormArgs optionFormArgs;

        // 객체 초기화
        private void OptionForm_Load(object sender, EventArgs e)
        {
            if (optionFormArgs == null)
                optionFormArgs = new Library.OptionFormArgs();
            else
                currentFilePathLbl.Text = optionFormArgs.filepath;  // 생성할 때, 전달받은 객체가 있으면,
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // delegate 파일 문자열 리턴.
            }
        }


        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 폼을 닫을 때, 객체에 정보를 반영
            if (GetOptionFormArgs != null)
                GetOptionFormArgs(optionFormArgs);
        }


        public Color originalPurple = Color.FromArgb(120, 102, 254);
        public Color darkPurple = ControlPaint.Dark(Color.FromArgb(120, 102, 254));
        public Color lightPurple = ControlPaint.Light(Color.FromArgb(120, 102, 254));
        private void selectFolderLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.folderSelectBtn.StartColor = darkPurple;
                this.folderSelectBtn.EndColor   = lightPurple;
            }
        }


        private void folderSelectBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.folderSelectBtn.StartColor = darkPurple;
                this.folderSelectBtn.EndColor   = lightPurple;
            }
        }

        #region 폴더 설정 이벤트
        private void selectFolderLblOrSelectBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (DialogResult.OK == fbd.ShowDialog())
                {
                    optionFormArgs.filepath = currentFilePathLbl.Text = StudyLog.Properties.Settings.Default.saveFolder = fbd.SelectedPath;
                    currentFilePathLbl.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    this.Close();
                }
                this.folderSelectBtn.EndColor = this.folderSelectBtn.StartColor = originalPurple;
            }
        }

        #endregion 폴더 설정 이벤트. 끝.

        public bool isBorderDarkPurple = false;
        private void folderSelectBtn_MouseEnter(object sender, EventArgs e)
        {
            this.folderSelectBtn.FlatBorderColor = ControlPaint.Dark(Color.FromArgb(119, 100, 253));
            isBorderDarkPurple = true;
        }
        private void selectFolderLbl_MouseEnter(object sender, EventArgs e)
        {
            this.folderSelectBtn.FlatBorderColor = ControlPaint.Dark(Color.FromArgb(119, 100, 253));
            isBorderDarkPurple = true;
        }

        private void folderSelectBtn_MouseLeave(object sender, EventArgs e)
        {
            this.folderSelectBtn.FlatBorderColor = this.folderSelectBtn.EndColor = this.folderSelectBtn.StartColor = originalPurple;
        }

        private void shadowPanel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBorderDarkPurple)
            {
                this.folderSelectBtn.FlatBorderColor = originalPurple;
                isBorderDarkPurple = false;
            }


        }

        private void selectFolderLbl_MouseLeave(object sender, EventArgs e)
        {

        }

        private void selectFolderLbl_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void folderSelectBtn_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
