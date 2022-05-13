using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyLog.Library;
using System.Runtime.InteropServices; // DllImport를 위해 추가


namespace StudyLog
{
    public partial class StudyLogMainForm : Form
    {
        OptionFormArgs optionFormArgs;
        public Point downPoint = Point.Empty;       // 누른 마우스의 좌표
        
        public StudyLogMainForm()
        {
            InitializeComponent();
        }


        private void StudyLogMainForm_Load(object sender, EventArgs e)
        {
            this.studyBtn.Location = new Point(this.ClientSize.Width / 2 - studyBtn.Size.Width / 2, this.ClientSize.Height / 2 - studyBtn.Size.Height / 2);
            // 폼이 로드될 때 구역(region)을 다시 설정.
            SetClientRegion();
            optionFormArgs = new OptionFormArgs();
        }


        public bool isStudying = false;
        public bool isMoving = false;
        // 버튼의 클릭 이벤트를 처리.
        private void studyBtn_MouseUp(object sender, MouseEventArgs e)
        {
            downPoint = Point.Empty;
            if (isMoving)   // 이동 명령중일 땐, 클릭 처리를 하지 않음.
            {
                isMoving = false;
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                ChangeTxtCondition(true);   // isStudying을 바꾸고, AddLog를 기록한다.
            }
        }

        public void AddLog(MessageType type, string message)
        {
            //string logDir = Path.Combine(optionFormArgs.filepath);
            //string logFile = Path.Combine(logDir, optionFormArgs.filename);
            
            string fullpath = optionFormArgs.filepath + "\\" + optionFormArgs.filename;

            try
            {
                using (StreamWriter sw = new StreamWriter(fullpath,true))   // TextWriter tw = new StreamWriter(fullpath, true); 후 tw.WriteLine("some text"); tw.Close()로도 사용 가능.
                {
                    if (type == MessageType.start)
                        sw.WriteLine(string.Format("공부 시작 {0} {1}", DateTime.Now.ToString("t"), message));
                    else
                        sw.WriteLine(string.Format("공부   끝 {0} {1}", DateTime.Now.ToString("t"), message));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public enum MessageType : int
        {
            start =  0,
            finish
        }



        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            downPoint = Point.Empty;
            if (isMoving)   // 이동 명령중일 땐, 클릭 처리를 하지 않음.
            {
                isMoving = false;
                return;
            }
        }

        private void studyBtnAndPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (downPoint == Point.Empty) return;
                isMoving = true;
                // 마우스의 현재 좌표e.X - 이전 좌표downPoint.X = 이동한 X좌표
                // 이동한 좌표위치를 반영한 후엔, 현재 좌표의 위치가 이전 좌표의 위치가 되고, 현재 좌표의 위치가 다시 현재 좌표의 위치가 되서, 전체 위치는 변하지 않음.
                // 이동한 후의 위치 = 이동한 포인터의 위치 + 폼의 왼쪽 경계선 위치.(이동한 거리 + 폼의 왼쪽 위 좌표)
                Point location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);
                this.Location = location;
            }
            else
                isMoving = false;
        }


        void SetClientRegion()
        {
            // FormBorderStyle속성이 None으로 설정되어 있다고 가정한다.
            Rectangle rect = this.ClientRectangle;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddRectangle(rect);  // 현재 경로에 타원을 추가합니다.
                this.Region = new Region(path);     // 타원 영역을 구역으로 직접 설정
            }
        }

        private void studyBtnAndPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return; // 왼쪽 버튼을 누른 게 아니면, 종료
            downPoint = new Point(e.X, e.Y); // 현재 마우스의 X, Y좌표를 downPoint에 설정함.
        }


        // OptionForm에서 설정한 폴더 정보를 가져오는 대리자에 등록할 메서드
        public void GetOptionFormArg(OptionFormArgs e)
        {
            optionFormArgs = e;
        }

        private void 파일경로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new OptionForm()
            {
                optionFormArgs = optionFormArgs,
                GetOptionFormArgs = new OptionForm.GetArgs(GetOptionFormArg),   // 대리자 개체를 연결해서, 폼을 닫을 때 개체를 얻어 옴.
                
            }).ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 최소화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 시작끝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTxtCondition(false);
        }

        private void ChangeTxtCondition(bool writeLog = false)
        {
            isStudying = !isStudying;
            if (isStudying)
            {
                this.studyBtn.TextString = "공부 끝";
                this.studyBtn.EndColor = Color.SkyBlue;
                this.studyBtn.TextColor = Color.Black;
                this.studyBtn.Refresh();
                if(writeLog) AddLog(MessageType.start, DateTime.Now.ToString("D"));
            }
            else
            {
                this.studyBtn.TextString = "공부 시작";
                this.studyBtn.EndColor = Color.Transparent;
                this.studyBtn.TextColor = Color.Black;
                this.studyBtn.Refresh();
                if(writeLog) AddLog(MessageType.finish, DateTime.Now.ToString("D"));
            }
        }
    }
}
