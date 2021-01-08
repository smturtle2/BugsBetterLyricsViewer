
namespace BugsBetterLyricsViewer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.IDbox = new System.Windows.Forms.TextBox();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.PWlabel = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.BugsIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BugsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(192, 165);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(100, 21);
            this.IDbox.TabIndex = 0;
            // 
            // PWbox
            // 
            this.PWbox.Location = new System.Drawing.Point(192, 192);
            this.PWbox.Name = "PWbox";
            this.PWbox.Size = new System.Drawing.Size(100, 21);
            this.PWbox.TabIndex = 1;
            this.PWbox.UseSystemPasswordChar = true;
            this.PWbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PWbox_KeyDown);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Location = new System.Drawing.Point(145, 168);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(41, 12);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = "아이디";
            // 
            // PWlabel
            // 
            this.PWlabel.AutoSize = true;
            this.PWlabel.BackColor = System.Drawing.Color.Transparent;
            this.PWlabel.Location = new System.Drawing.Point(133, 195);
            this.PWlabel.Name = "PWlabel";
            this.PWlabel.Size = new System.Drawing.Size(53, 12);
            this.PWlabel.TabIndex = 3;
            this.PWlabel.Text = "비밀번호";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(217, 219);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 30);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // BugsIcon
            // 
            this.BugsIcon.Image = global::BugsBetterLyricsViewer.Properties.Resources.BugsBackGround;
            this.BugsIcon.Location = new System.Drawing.Point(12, 12);
            this.BugsIcon.Name = "BugsIcon";
            this.BugsIcon.Size = new System.Drawing.Size(280, 147);
            this.BugsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BugsIcon.TabIndex = 5;
            this.BugsIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 260);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.PWlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.BugsIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "벅스 로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BugsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label PWlabel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox BugsIcon;
    }
}