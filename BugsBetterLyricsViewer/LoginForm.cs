using System;
using System.IO;
using System.Windows.Forms;

namespace BugsBetterLyricsViewer
{
    public partial class LoginForm : Form
    {
        bool Logined = false;
        LyricsForm lyricsForm;

        
        public LoginForm(LyricsForm lyricsForm)
        {
            InitializeComponent();
            this.lyricsForm = lyricsForm;

            FileStream fs;
            fs = new FileStream("Info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            IDbox.Text = sr.ReadLine();
            PWbox.Text = sr.ReadLine();
            sr.Close();
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
            FileStream fs;
            fs = new FileStream("Info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(IDbox.Text);
            sw.WriteLine(PWbox.Text);
            sw.Close();
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
    }
}
