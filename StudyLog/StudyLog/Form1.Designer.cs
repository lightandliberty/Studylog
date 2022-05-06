
namespace StudyLog
{
    partial class Form1
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
            this.shadowPanel1 = new CustomControls_dll.ShadowPanel();
            this.studyBtn = new CustomControls_dll.ShadowPanel();
            this.shadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
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
            this.shadowPanel1.Size = new System.Drawing.Size(169, 107);
            this.shadowPanel1.StartColor = System.Drawing.Color.White;
            this.shadowPanel1.Style = CustomControls_dll.BevelStyle.Flat;
            this.shadowPanel1.TabIndex = 0;
            this.shadowPanel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowPanel1.TextString = "";
            // 
            // studyBtn
            // 
            this.studyBtn.BackColor = System.Drawing.Color.Transparent;
            this.studyBtn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
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
            this.studyBtn.Size = new System.Drawing.Size(151, 89);
            this.studyBtn.StartColor = System.Drawing.Color.White;
            this.studyBtn.Style = CustomControls_dll.BevelStyle.Raised;
            this.studyBtn.TabIndex = 0;
            this.studyBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.studyBtn.TextString = "공부 시작";
            this.studyBtn.Click += new System.EventHandler(this.StudyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 107);
            this.Controls.Add(this.shadowPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.shadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.ShadowPanel shadowPanel1;
        private CustomControls_dll.ShadowPanel studyBtn;
    }
}

