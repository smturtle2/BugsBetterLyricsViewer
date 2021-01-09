
namespace BugsBetterLyricsViewer
{
    partial class LyricsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyricsForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ListBtn = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.LyricsLabel1 = new System.Windows.Forms.Label();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.LyricsLabel2 = new System.Windows.Forms.Label();
            this.TransparentSlider = new ColorSlider.ColorSlider();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.GetLyrics = new System.Windows.Forms.Timer(this.components);
            this.GetOtherInfo = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SettingLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.ListBtn);
            this.pnlTop.Controls.Add(this.btn_close);
            this.pnlTop.Controls.Add(this.SettingBtn);
            this.pnlTop.Controls.Add(this.LyricsLabel1);
            this.pnlTop.Controls.Add(this.SongNameLabel);
            this.pnlTop.Controls.Add(this.LyricsLabel2);
            this.pnlTop.Controls.Add(this.TransparentSlider);
            this.pnlTop.Controls.Add(this.PlayPauseBtn);
            this.pnlTop.Controls.Add(this.NextBtn);
            this.pnlTop.Controls.Add(this.PrevBtn);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 108);
            this.pnlTop.TabIndex = 0;
            // 
            // ListBtn
            // 
            this.ListBtn.BackColor = System.Drawing.Color.Transparent;
            this.ListBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ListBtn.FlatAppearance.BorderSize = 0;
            this.ListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListBtn.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ListBtn.Image = global::BugsBetterLyricsViewer.Properties.Resources.icons8_add_list_16;
            this.ListBtn.Location = new System.Drawing.Point(41, 88);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(23, 23);
            this.ListBtn.TabIndex = 9;
            this.ListBtn.UseVisualStyleBackColor = false;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::BugsBetterLyricsViewer.Properties.Resources.icons8_close_window_24;
            this.btn_close.Location = new System.Drawing.Point(771, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SettingBtn.Image = global::BugsBetterLyricsViewer.Properties.Resources.icons8_settings_16;
            this.SettingBtn.Location = new System.Drawing.Point(12, 88);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(23, 23);
            this.SettingBtn.TabIndex = 8;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // LyricsLabel1
            // 
            this.LyricsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LyricsLabel1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LyricsLabel1.Location = new System.Drawing.Point(0, 29);
            this.LyricsLabel1.Name = "LyricsLabel1";
            this.LyricsLabel1.Size = new System.Drawing.Size(800, 23);
            this.LyricsLabel1.TabIndex = 1;
            this.LyricsLabel1.Text = "가사를 불러오는 중...";
            this.LyricsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SongNameLabel.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SongNameLabel.Location = new System.Drawing.Point(3, 6);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(765, 20);
            this.SongNameLabel.TabIndex = 6;
            this.SongNameLabel.Text = "노래를 불러오는 중...";
            this.SongNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SongNameLabel_MouseDown);
            this.SongNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SongNameLabel_MouseMove);
            this.SongNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SongNameLabel_MouseUp);
            // 
            // LyricsLabel2
            // 
            this.LyricsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LyricsLabel2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LyricsLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LyricsLabel2.Location = new System.Drawing.Point(0, 52);
            this.LyricsLabel2.Name = "LyricsLabel2";
            this.LyricsLabel2.Size = new System.Drawing.Size(800, 23);
            this.LyricsLabel2.TabIndex = 2;
            this.LyricsLabel2.Text = "...";
            this.LyricsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransparentSlider
            // 
            this.TransparentSlider.BackColor = System.Drawing.Color.Transparent;
            this.TransparentSlider.BarInnerColor = System.Drawing.Color.Silver;
            this.TransparentSlider.BarPenColorBottom = System.Drawing.Color.Silver;
            this.TransparentSlider.BarPenColorTop = System.Drawing.Color.Silver;
            this.TransparentSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TransparentSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.TransparentSlider.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.TransparentSlider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.TransparentSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TransparentSlider.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TransparentSlider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TransparentSlider.Location = new System.Drawing.Point(682, 83);
            this.TransparentSlider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TransparentSlider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TransparentSlider.Name = "TransparentSlider";
            this.TransparentSlider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TransparentSlider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TransparentSlider.ShowDivisionsText = true;
            this.TransparentSlider.ShowSmallScale = false;
            this.TransparentSlider.Size = new System.Drawing.Size(106, 25);
            this.TransparentSlider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TransparentSlider.TabIndex = 7;
            this.TransparentSlider.Text = "colorSlider1";
            this.TransparentSlider.ThumbInnerColor = System.Drawing.SystemColors.ButtonFace;
            this.TransparentSlider.ThumbOuterColor = System.Drawing.SystemColors.Control;
            this.TransparentSlider.ThumbPenColor = System.Drawing.SystemColors.ButtonFace;
            this.TransparentSlider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TransparentSlider.ThumbSize = new System.Drawing.Size(16, 16);
            this.TransparentSlider.TickAdd = 0F;
            this.TransparentSlider.TickColor = System.Drawing.SystemColors.ActiveCaption;
            this.TransparentSlider.TickDivide = 0F;
            this.TransparentSlider.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.TransparentSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TransparentSlider_Scroll);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayPauseBtn.FlatAppearance.BorderSize = 0;
            this.PlayPauseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayPauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayPauseBtn.Font = new System.Drawing.Font("나눔바른고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayPauseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayPauseBtn.Location = new System.Drawing.Point(370, 76);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(61, 41);
            this.PlayPauseBtn.TabIndex = 5;
            this.PlayPauseBtn.Text = "||";
            this.PlayPauseBtn.UseVisualStyleBackColor = false;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBtn.Font = new System.Drawing.Font("나눔바른고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextBtn.Location = new System.Drawing.Point(430, 76);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(77, 41);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "▶▶";
            this.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.BackColor = System.Drawing.Color.Transparent;
            this.PrevBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrevBtn.FlatAppearance.BorderSize = 0;
            this.PrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrevBtn.Font = new System.Drawing.Font("나눔바른고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PrevBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrevBtn.Location = new System.Drawing.Point(296, 76);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(77, 41);
            this.PrevBtn.TabIndex = 3;
            this.PrevBtn.Text = "◀◀";
            this.PrevBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrevBtn.UseVisualStyleBackColor = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // GetLyrics
            // 
            this.GetLyrics.Tick += new System.EventHandler(this.GetLyrics_Tick);
            // 
            // GetOtherInfo
            // 
            this.GetOtherInfo.Interval = 500;
            this.GetOtherInfo.Tick += new System.EventHandler(this.GetOtherInfo_Tick);
            // 
            // SettingLoad
            // 
            this.SettingLoad.Interval = 500;
            this.SettingLoad.Tick += new System.EventHandler(this.SettingLoad_Tick);
            // 
            // LyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::BugsBetterLyricsViewer.Properties.Resources.TransparentBackground;
            this.ClientSize = new System.Drawing.Size(800, 120);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LyricsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "벅스 더 나은 가사 뷰어";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LyricsForm_FormClosed);
            this.Shown += new System.EventHandler(this.LyricsForm_Shown);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label LyricsLabel1;
        private System.Windows.Forms.Timer GetLyrics;
        private System.Windows.Forms.Label LyricsLabel2;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.Timer GetOtherInfo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ColorSlider.ColorSlider TransparentSlider;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Timer SettingLoad;
        private System.Windows.Forms.Button ListBtn;
    }
}

