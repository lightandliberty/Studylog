
namespace StudyLog
{
    partial class StudyLogMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.시작끝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일경로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최소화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.Button();
            this.shadowPanel1 = new CustomControls_dll.ShadowPanel();
            this.studyBtn = new CustomControls_dll.ShadowPanel();
            this.기록후종료여부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.shadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작끝ToolStripMenuItem,
            this.파일경로ToolStripMenuItem,
            this.최소화ToolStripMenuItem,
            this.종료ToolStripMenuItem,
            this.기록후종료여부ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 136);
            // 
            // 시작끝ToolStripMenuItem
            // 
            this.시작끝ToolStripMenuItem.Name = "시작끝ToolStripMenuItem";
            this.시작끝ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.시작끝ToolStripMenuItem.Text = "시작 <-> 끝";
            this.시작끝ToolStripMenuItem.Click += new System.EventHandler(this.시작끝ToolStripMenuItem_Click);
            // 
            // 파일경로ToolStripMenuItem
            // 
            this.파일경로ToolStripMenuItem.Name = "파일경로ToolStripMenuItem";
            this.파일경로ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.파일경로ToolStripMenuItem.Text = "파일 경로";
            this.파일경로ToolStripMenuItem.Click += new System.EventHandler(this.파일경로ToolStripMenuItem_Click);
            // 
            // 최소화ToolStripMenuItem
            // 
            this.최소화ToolStripMenuItem.Name = "최소화ToolStripMenuItem";
            this.최소화ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.최소화ToolStripMenuItem.Text = "최소화";
            this.최소화ToolStripMenuItem.Click += new System.EventHandler(this.최소화ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.종료ToolStripMenuItem.Text = "종료 (Esc)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(26, 108);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(0, 0);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowPanel1.Controls.Add(this.closeBtn);
            this.shadowPanel1.Controls.Add(this.studyBtn);
            this.shadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel1.EdgeWidth = 2;
            this.shadowPanel1.EndColor = System.Drawing.Color.Pink;
            this.shadowPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.shadowPanel1.FocusScaleHeight = 0.85F;
            this.shadowPanel1.FocusScaleWidth = 0.95F;
            this.shadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.NeonColor = System.Drawing.Color.Pink;
            this.shadowPanel1.RectRadius = 0;
            this.shadowPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.shadowPanel1.ShadowShift = 0;
            this.shadowPanel1.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.shadowPanel1.Size = new System.Drawing.Size(172, 107);
            this.shadowPanel1.StartColor = System.Drawing.Color.White;
            this.shadowPanel1.Style = CustomControls_dll.BevelStyle.Flat;
            this.shadowPanel1.TabIndex = 0;
            this.shadowPanel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowPanel1.TextString = "";
            this.shadowPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.studyBtnAndPanel_MouseDown);
            this.shadowPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studyBtnAndPanel_MouseMove);
            this.shadowPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // studyBtn
            // 
            this.studyBtn.BackColor = System.Drawing.Color.Transparent;
            this.studyBtn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.studyBtn.ContextMenuStrip = this.contextMenuStrip1;
            this.studyBtn.EdgeWidth = 5;
            this.studyBtn.EndColor = System.Drawing.Color.Transparent;
            this.studyBtn.FlatBorderColor = System.Drawing.Color.White;
            this.studyBtn.FocusScaleHeight = 0.85F;
            this.studyBtn.FocusScaleWidth = 0.95F;
            this.studyBtn.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studyBtn.Location = new System.Drawing.Point(12, 12);
            this.studyBtn.Name = "studyBtn";
            this.studyBtn.NeonColor = System.Drawing.Color.Transparent;
            this.studyBtn.RectRadius = 20;
            this.studyBtn.ShadowColor = System.Drawing.Color.DimGray;
            this.studyBtn.ShadowShift = 20;
            this.studyBtn.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.studyBtn.Size = new System.Drawing.Size(151, 90);
            this.studyBtn.StartColor = System.Drawing.Color.White;
            this.studyBtn.Style = CustomControls_dll.BevelStyle.Raised;
            this.studyBtn.TabIndex = 0;
            this.studyBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.studyBtn.TextString = "공부 시작";
            this.studyBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.studyBtnAndPanel_MouseDown);
            this.studyBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studyBtnAndPanel_MouseMove);
            this.studyBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.studyBtn_MouseUp);
            // 
            // 기록후종료여부ToolStripMenuItem
            // 
            this.기록후종료여부ToolStripMenuItem.Name = "기록후종료여부ToolStripMenuItem";
            this.기록후종료여부ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.기록후종료여부ToolStripMenuItem.Text = "기록 후 종료 여부 설정";
            this.기록후종료여부ToolStripMenuItem.Click += new System.EventHandler(this.기록후종료여부ToolStripMenuItem_Click);
            // 
            // StudyLogMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(172, 107);
            this.ControlBox = false;
            this.Controls.Add(this.shadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyLogMainForm";
            this.Text = "StudyLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudyLogMainForm_FormClosing);
            this.Load += new System.EventHandler(this.StudyLogMainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.shadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.ShadowPanel shadowPanel1;
        private CustomControls_dll.ShadowPanel studyBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일경로ToolStripMenuItem;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ToolStripMenuItem 최소화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작끝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기록후종료여부ToolStripMenuItem;
    }
}

