using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BugsBetterLyricsViewer
{
    public partial class LyricsForm : Form
    {
        private bool isMove;
        private Point fPt;

        public static string ID;
        public static string PW;

        protected ChromeDriverService DriverService = null;
        protected ChromeOptions Options = null;
        protected ChromeDriver Driver = null;

        bool Ready = false;
        public LyricsForm()
        {
            InitializeComponent();
            Opacity = .75;

            DriverService = ChromeDriverService.CreateDefaultService();
            DriverService.HideCommandPromptWindow = true;

            Options = new ChromeOptions();
            Options.AddArgument("disable-gpu");
            Options.AddArgument("--window-size=1920,1080");
            Options.AddArgument("--disable-extensions");
            Options.AddArgument("--proxy-server='direct://'");
            Options.AddArgument("--proxy-bypass-list=*");
            Options.AddArgument("--start-maximized");
            Options.AddArgument("--headless");
            Options.AddArgument("--disable-gpu");
            Options.AddArgument("--disable-dev-shm-usage");
            Options.AddArgument("--no-sandbox");
            Options.AddArgument("--ignore-certificate-errors");
        }
        private void SongNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void SongNameLabel_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void SongNameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Driver.Quit();
            Close();
        }

        private void LyricsForm_Shown(object sender, EventArgs e)
        {
            new Thread(EnterBugs).Start();
        }

        void EnterBugs()
        {
            try
            {
                Driver = new ChromeDriver(DriverService, Options);

                Driver.Navigate().GoToUrl("https://music.bugs.co.kr/");

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                var element = Driver.FindElementByXPath("//*[@id='loginHeader']/a");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='to_bugs_login']");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='user_id']");
                element.SendKeys(ID);

                element = Driver.FindElementByXPath("//*[@id='passwd']");
                element.SendKeys(PW);

                element = Driver.FindElementByXPath("//*[@id='frmLoginLayer']/div/div[1]/button");
                element.Click();

                ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
                Driver.SwitchTo().Window(Driver.WindowHandles.Last());

                Driver.Navigate().GoToUrl("https://music.bugs.co.kr/newPlayer?autoplay=false");

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[3]/button");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='checkQuality']");
                element.Click();

                ((IJavaScriptExecutor)Driver).ExecuteScript("document.getElementById('checkQuality').options[2].selected=true;");

                element = Driver.FindElementByXPath("//*[@id='holdBackTrackPlayOption']/section/p/button");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[2]/span[1]/span/button");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[2]/span[2]/span/button");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[3]/ul/li[4]/a");
                element.Click();

                element = Driver.FindElementByXPath("//*[@title='ForViewer']/../../div[2]/button");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[3]/ul/li[2]/a");
                element.Click();

                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[3]/button");
                element.Click();

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);

                Ready = true;
            }
            catch (Exception)
            {
                Driver.Quit();
            }
        }

        private void GetLyrics_Tick(object sender, EventArgs e)
        {
            if (!Ready) { }
            else if (Driver.FindElementsByXPath("/html/body/div[1]/div[3]/div/div[5]/div[3]/div[2]/div/div[1]/div/div[2]/strong").Count > 0)
            {
                try
                {
                    string[] Lyrics = Driver.FindElementByXPath("//*[@id='lyricsContent']").Text.Split('\n');
                    var element = Driver.FindElementByXPath("/html/body/div[1]/div[3]/div/div[5]/div[3]/div[2]/div/div[1]/div/div[2]/strong");
                    LyricsLabel1.Text = element.Text;
                    for (int i = 0; i < Lyrics.Length - 1; i++)
                    {
                        if (Lyrics[i].Contains(LyricsLabel1.Text))
                        {
                            LyricsLabel1.Text = Lyrics[i];
                            LyricsLabel2.Text = Lyrics[i + 1];
                            break;
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        void GetSongName()
        {
            var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/dl/dt/span[2]/a");
            SongNameLabel.Text = element.Text;
            element = Driver.FindElementByXPath("//*[@id='newPlayerArtistName']");
            SongNameLabel.Text += " - " + element.Text;
        }

        private void PlayPauseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[2]/button");
                element.Click();
            }
            catch (Exception) { }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            LyricsLabel1.Text = "가사를 불러오는 중...";
            LyricsLabel2.Text = "...";
            try
            {
                var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[1]/button");
                element.Click();
            }
            catch (Exception) { }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            LyricsLabel1.Text = "가사를 불러오는 중...";
            LyricsLabel2.Text = "...";
            try
            {
                var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[3]/button");
                element.Click();
            }
            catch (Exception) { }
        }

        private void GetOtherInfo_Tick(object sender, EventArgs e)
        {
            if (Ready)
            {
                try
                {
                    var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[2]/button");
                    if (element.Text.Equals("재생"))
                    {
                        PlayPauseBtn.Text = " ▶";
                    }
                    else
                    {
                        PlayPauseBtn.Text = "||";
                    }
                    GetSongName();
                }
                catch (Exception) { }
            }
        }

        private void TransparentSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Opacity = Math.Max(decimal.ToInt32(TransparentSlider.Value), 25) / 100F;
        }
    }
}
