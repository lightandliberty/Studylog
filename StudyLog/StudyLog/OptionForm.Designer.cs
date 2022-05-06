
namespace StudyLog
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shadowPanel1 = new CustomControls_dll.ShadowPanel();
            this.shadowPanel7 = new CustomControls_dll.ShadowPanel();
            this.folderSelectBtn = new CustomControls_dll.ShadowPanel();
            this.selectFolderLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.currentFilePathLbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.shadowPanel1.SuspendLayout();
            this.shadowPanel7.SuspendLayout();
            this.folderSelectBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowPanel1.Controls.Add(this.shadowPanel7);
            this.shadowPanel1.Controls.Add(this.closeBtn);
            this.shadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel1.EdgeWidth = 2;
            this.shadowPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
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
            this.shadowPanel1.Size = new System.Drawing.Size(520, 261);
            this.shadowPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.shadowPanel1.Style = CustomControls_dll.BevelStyle.Flat;
            this.shadowPanel1.TabIndex = 2;
            this.shadowPanel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowPanel1.TextString = "";
            // 
            // shadowPanel7
            // 
            this.shadowPanel7.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel7.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.shadowPanel7.Controls.Add(this.folderSelectBtn);
            this.shadowPanel7.Controls.Add(this.label18);
            this.shadowPanel7.Controls.Add(this.currentFilePathLbl);
            this.shadowPanel7.Controls.Add(this.label20);
            this.shadowPanel7.EdgeWidth = 2;
            this.shadowPanel7.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.shadowPanel7.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.shadowPanel7.FocusScaleHeight = 0.85F;
            this.shadowPanel7.FocusScaleWidth = 0.95F;
            this.shadowPanel7.Location = new System.Drawing.Point(12, 12);
            this.shadowPanel7.Name = "shadowPanel7";
            this.shadowPanel7.NeonColor = System.Drawing.Color.Pink;
            this.shadowPanel7.RectRadius = 20;
            this.shadowPanel7.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.shadowPanel7.ShadowShift = 10;
            this.shadowPanel7.ShadowStyle = CustomControls_dll.ShadowMode.Surrounded;
            this.shadowPanel7.Size = new System.Drawing.Size(497, 237);
            this.shadowPanel7.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.shadowPanel7.Style = CustomControls_dll.BevelStyle.Flat;
            this.shadowPanel7.TabIndex = 7;
            this.shadowPanel7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.shadowPanel7.TextString = "";
            this.shadowPanel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shadowPanel7_MouseMove);
            // 
            // folderSelectBtn
            // 
            this.folderSelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.folderSelectBtn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.folderSelectBtn.Controls.Add(this.selectFolderLbl);
            this.folderSelectBtn.EdgeWidth = 2;
            this.folderSelectBtn.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(100)))), ((int)(((byte)(253)))));
            this.folderSelectBtn.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(100)))), ((int)(((byte)(253)))));
            this.folderSelectBtn.FocusScaleHeight = 0.85F;
            this.folderSelectBtn.FocusScaleWidth = 0.95F;
            this.folderSelectBtn.Font = new System.Drawing.Font("굴림", 12F);
            this.folderSelectBtn.Location = new System.Drawing.Point(29, 181);
            this.folderSelectBtn.Name = "folderSelectBtn";
            this.folderSelectBtn.NeonColor = System.Drawing.Color.Pink;
            this.folderSelectBtn.RectRadius = 10;
            this.folderSelectBtn.ShadowColor = System.Drawing.Color.DimGray;
            this.folderSelectBtn.ShadowShift = 0;
            this.folderSelectBtn.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.folderSelectBtn.Size = new System.Drawing.Size(84, 35);
            this.folderSelectBtn.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(100)))), ((int)(((byte)(253)))));
            this.folderSelectBtn.Style = CustomControls_dll.BevelStyle.Flat;
            this.folderSelectBtn.TabIndex = 9;
            this.folderSelectBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.folderSelectBtn.TextString = "";
            this.folderSelectBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.folderSelectBtn_MouseDown);
            this.folderSelectBtn.MouseEnter += new System.EventHandler(this.folderSelectBtn_MouseEnter);
            this.folderSelectBtn.MouseLeave += new System.EventHandler(this.folderSelectBtn_MouseLeave);
            this.folderSelectBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectFolderLblOrSelectBtn_MouseUp);
            // 
            // selectFolderLbl
            // 
            this.selectFolderLbl.AutoSize = true;
            this.selectFolderLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectFolderLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.selectFolderLbl.Location = new System.Drawing.Point(3, 6);
            this.selectFolderLbl.Name = "selectFolderLbl";
            this.selectFolderLbl.Size = new System.Drawing.Size(79, 22);
            this.selectFolderLbl.TabIndex = 10;
            this.selectFolderLbl.Text = "폴더 선택";
            this.selectFolderLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectFolderLbl_MouseDown);
            this.selectFolderLbl.MouseEnter += new System.EventHandler(this.selectFolderLbl_MouseEnter);
            this.selectFolderLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectFolderLblOrSelectBtn_MouseUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.75F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(147)))), ((int)(((byte)(184)))));
            this.label18.Location = new System.Drawing.Point(26, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "새 파일경로를 선택해 주세요.";
            // 
            // currentFilePathLbl
            // 
            this.currentFilePathLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentFilePathLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.currentFilePathLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(119)))), ((int)(((byte)(249)))));
            this.currentFilePathLbl.Location = new System.Drawing.Point(24, 50);
            this.currentFilePathLbl.Name = "currentFilePathLbl";
            this.currentFilePathLbl.Size = new System.Drawing.Size(447, 111);
            this.currentFilePathLbl.TabIndex = 7;
            this.currentFilePathLbl.Text = "currentFilePath";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.label20.Location = new System.Drawing.Point(25, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 22);
            this.label20.TabIndex = 6;
            this.label20.Text = "파일 경로";
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
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(520, 261);
            this.Controls.Add(this.shadowPanel1);
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OptionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.shadowPanel1.ResumeLayout(false);
            this.shadowPanel7.ResumeLayout(false);
            this.shadowPanel7.PerformLayout();
            this.folderSelectBtn.ResumeLayout(false);
            this.folderSelectBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls_dll.ShadowPanel shadowPanel1;
        private CustomControls_dll.ShadowPanel shadowPanel7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label currentFilePathLbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button closeBtn;
        private CustomControls_dll.ShadowPanel folderSelectBtn;
        private System.Windows.Forms.Label selectFolderLbl;
    }
}