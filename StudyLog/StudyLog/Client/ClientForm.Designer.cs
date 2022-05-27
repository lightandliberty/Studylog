
namespace StudyLog.Client
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.접속Ip설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundPanel = new CustomControls_dll.ShadowPanel();
            this.changeIPBtn = new CustomControls_dll.ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.connectPN = new CustomControls_dll.ShadowPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.backGroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.접속Ip설정ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // 접속Ip설정ToolStripMenuItem
            // 
            this.접속Ip설정ToolStripMenuItem.Name = "접속Ip설정ToolStripMenuItem";
            this.접속Ip설정ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.접속Ip설정ToolStripMenuItem.Text = "접속 ip설정";
            this.접속Ip설정ToolStripMenuItem.Click += new System.EventHandler(this.접속Ip설정ToolStripMenuItem_Click);
            // 
            // backGroundPanel
            // 
            this.backGroundPanel.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.backGroundPanel.Controls.Add(this.changeIPBtn);
            this.backGroundPanel.Controls.Add(this.label2);
            this.backGroundPanel.Controls.Add(this.label1);
            this.backGroundPanel.Controls.Add(this.closeBtn);
            this.backGroundPanel.Controls.Add(this.connectPN);
            this.backGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGroundPanel.EdgeWidth = 2;
            this.backGroundPanel.EndColor = System.Drawing.Color.Pink;
            this.backGroundPanel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.backGroundPanel.FocusScaleHeight = 0.85F;
            this.backGroundPanel.FocusScaleWidth = 0.95F;
            this.backGroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backGroundPanel.Name = "backGroundPanel";
            this.backGroundPanel.NeonColor = System.Drawing.Color.Pink;
            this.backGroundPanel.RectRadius = 0;
            this.backGroundPanel.ShadowColor = System.Drawing.Color.DimGray;
            this.backGroundPanel.ShadowShift = 0;
            this.backGroundPanel.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.backGroundPanel.Size = new System.Drawing.Size(434, 411);
            this.backGroundPanel.StartColor = System.Drawing.Color.White;
            this.backGroundPanel.Style = CustomControls_dll.BevelStyle.Flat;
            this.backGroundPanel.TabIndex = 5;
            this.backGroundPanel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.backGroundPanel.TextString = "";
            // 
            // changeIPBtn
            // 
            this.changeIPBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeIPBtn.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.changeIPBtn.EdgeWidth = 2;
            this.changeIPBtn.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(179)))), ((int)(((byte)(171)))));
            this.changeIPBtn.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(159)))), ((int)(((byte)(151)))));
            this.changeIPBtn.FocusScaleHeight = 0.85F;
            this.changeIPBtn.FocusScaleWidth = 0.95F;
            this.changeIPBtn.Font = new System.Drawing.Font("굴림", 12F);
            this.changeIPBtn.Location = new System.Drawing.Point(179, 12);
            this.changeIPBtn.Name = "changeIPBtn";
            this.changeIPBtn.NeonColor = System.Drawing.Color.Pink;
            this.changeIPBtn.RectRadius = 10;
            this.changeIPBtn.ShadowColor = System.Drawing.Color.DimGray;
            this.changeIPBtn.ShadowShift = 0;
            this.changeIPBtn.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.changeIPBtn.Size = new System.Drawing.Size(90, 28);
            this.changeIPBtn.StartColor = System.Drawing.Color.White;
            this.changeIPBtn.Style = CustomControls_dll.BevelStyle.Flat;
            this.changeIPBtn.TabIndex = 10;
            this.changeIPBtn.TextColor = System.Drawing.Color.Black;
            this.changeIPBtn.TextString = "IP 변경";
            this.changeIPBtn.Click += new System.EventHandler(this.changeIPBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(39, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(39, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
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
            // connectPN
            // 
            this.connectPN.BackColor = System.Drawing.Color.Transparent;
            this.connectPN.BackgroundGradientMode = CustomControls_dll.PanelGradientMode.Vertical;
            this.connectPN.ContextMenuStrip = this.contextMenuStrip1;
            this.connectPN.EdgeWidth = 5;
            this.connectPN.EndColor = System.Drawing.Color.Transparent;
            this.connectPN.FlatBorderColor = System.Drawing.Color.White;
            this.connectPN.FocusScaleHeight = 0.85F;
            this.connectPN.FocusScaleWidth = 0.95F;
            this.connectPN.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectPN.Location = new System.Drawing.Point(12, 12);
            this.connectPN.Name = "connectPN";
            this.connectPN.NeonColor = System.Drawing.Color.Transparent;
            this.connectPN.RectRadius = 20;
            this.connectPN.ShadowColor = System.Drawing.Color.DimGray;
            this.connectPN.ShadowShift = 20;
            this.connectPN.ShadowStyle = CustomControls_dll.ShadowMode.ForwardDiagonal;
            this.connectPN.Size = new System.Drawing.Size(151, 90);
            this.connectPN.StartColor = System.Drawing.Color.White;
            this.connectPN.Style = CustomControls_dll.BevelStyle.Raised;
            this.connectPN.TabIndex = 0;
            this.connectPN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.connectPN.TextString = "호스트\r\n접속";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.backGroundPanel);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.backGroundPanel.ResumeLayout(false);
            this.backGroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_dll.ShadowPanel backGroundPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private CustomControls_dll.ShadowPanel connectPN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 접속Ip설정ToolStripMenuItem;
        private CustomControls_dll.ShadowPanel changeIPBtn;
    }
}