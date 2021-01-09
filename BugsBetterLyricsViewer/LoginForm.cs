using System;
using System.IO;
using System.Windows.Forms;

namespace BugsBetterLyricsViewer
{
    public partial class LoginForm : Form
    {
        bool Logined = false;
        LyricsForm lyricsForm;
        IniFile ini;
        public LoginForm(LyricsForm lyricsForm)
        {
            InitializeComponent();
            this.lyricsForm = lyricsForm;
            ini = new IniFile("Setting.ini");
            IDbox.Text = ini.Read("Login", "ID");
            PWbox.Text = ini.Read("Login", "PW");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Logined)
            {
                LyricsForm.ID = IDbox.Text;
                LyricsForm.PW = PWbox.Text;
            }
            else
            {
                lyricsForm.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        void login()
        {
            ini.Write("Login", "ID", IDbox.Text);
            ini.Write("Login", "PW", PWbox.Text);
            if(AutoLoginBox.Checked == true)
            {
                ini.Write("Login", "Auto", "True");
            }
            Logined = true;
            Close();
        }

        private void PWbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (ini.Read("Login", "Auto").Equals("True"))
            {
                login();
            }
        }
    }
}
