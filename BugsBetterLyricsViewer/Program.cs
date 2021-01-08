using System;
using System.Windows.Forms;

namespace BugsBetterLyricsViewer
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LyricsForm lyricsForm = new LyricsForm();
            LoginForm loginForm = new LoginForm(lyricsForm);
            Application.Run(loginForm);
            try
            {
                Application.Run(lyricsForm);
            }
            catch (Exception) { }
        }
    }
}
