
namespace BugsBetterLyricsViewer
{
    partial class PlayListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.PlayListBox = new System.Windows.Forms.CheckedListBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.AutoLoadBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PlayListBox
            // 
            this.PlayListBox.FormattingEnabled = true;
            this.PlayListBox.Location = new System.Drawing.Point(12, 12);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.Size = new System.Drawing.Size(211, 164);
            this.PlayListBox.TabIndex = 0;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(148, 183);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "확인";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // AutoLoadBox
            // 
            this.AutoLoadBox.AutoSize = true;
            this.AutoLoadBox.Location = new System.Drawing.Point(12, 187);
            this.AutoLoadBox.Name = "AutoLoadBox";
            this.AutoLoadBox.Size = new System.Drawing.Size(124, 16);
            this.AutoLoadBox.TabIndex = 2;
            this.AutoLoadBox.Text = "자동으로 불러오기";
            this.AutoLoadBox.UseVisualStyleBackColor = true;
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 218);
            this.Controls.Add(this.AutoLoadBox);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.PlayListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "재생목록 설정";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.PlayListForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PlayListBox;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.CheckBox AutoLoadBox;
    }
}