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

        public string[] PlayList;
        public string[] AlbumList;

        protected ChromeDriverService DriverService = null;
        protected ChromeOptions Options = null;
        protected ChromeDriver Driver = null;

        bool Ready = false;

        IniFile ini;

        string Song;
        string Lyrics1;
        string Lyrics2;

        LyricsForm lyricsForm;

        Thread GetSongNameThread;
        Thread GetLyricsThread;
        public LyricsForm()
        {
            InitializeComponent();
            lyricsForm = this;

            GetSongNameThread = new Thread(GetSongName);
            GetLyricsThread = new Thread(GetTheLyrics);

            Song = SongNameLabel.Text;
            Lyrics1 = LyricsLabel1.Text;
            Lyrics2 = LyricsLabel2.Text;

            ini = new IniFile("Setting.ini");
            if(ini.Read("Setting", "Opacity").Length > 0)
            {
                Opacity = double.Parse(ini.Read("Setting", "Opacity"));
                TransparentSlider.Value = (decimal)(Opacity * 100);
            }
            else
            {
                Opacity = .75;
            }

            DriverService = ChromeDriverService.CreateDefaultService();
            DriverService.HideCommandPromptWindow = true;

            Options = new ChromeOptions();
            Options.AddArgument("disable-gpu");
            Options.AddArgument("--window-size=1280,800");
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

            GetLyrics.Start();
            GetOtherInfo.Start();
            SettingLoad.Start();
        }

        void EnterBugs()
        {
            try
            {
                Driver = new ChromeDriver(DriverService, Options);

                Driver.Navigate().GoToUrl("https://music.bugs.co.kr/");

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                //Bugs 로그인
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

                Thread.Sleep(50);
                if (Driver.FindElementsByXPath("//*[@id='loginDesc']").Count > 0)
                {
                    element = Driver.FindElementByXPath("//*[@id='loginDesc']");
                    if(element.Text.Length > 0)
                    {
                        ini.Write("Login", "Auto", "False");
                        throw new Exception("아이디 또는 비밀번호가 잘못되었습니다.");
                    }
                }

                //웹 플레이어 열기
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
                Driver.SwitchTo().Window(Driver.WindowHandles.Last());

                Driver.Navigate().GoToUrl("https://music.bugs.co.kr/newPlayer?autoplay=false");

                SetQuality(); //퀄리티 설정

                //전체 반복
                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[2]/span[1]/span/button");
                element.Click();

                //랜덤
                element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[2]/span[2]/span/button");
                element.Click();

                //재생 목록 설정
                new PlayListForm(lyricsForm, true).ShowDialog();
                SetPlayList();

                Ready = true;
            }
            catch (Exception E)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    new ErrorForm(E.Message).ShowDialog();
                }));
                Driver.Quit();
                this.Invoke(new MethodInvoker(delegate ()
                {
                    Close();
                }));
            }
        }
        public void GetAlbumList()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());

            Driver.Navigate().GoToUrl("https://music.bugs.co.kr/user/library/myalbum/list");
            Driver.FindElementByXPath("//*[@id='container']/header/div/h1");
            int i = 1;
            string AlbumList = "";
            while(Driver.FindElementsByXPath("//*[@id='myAlbumListAjax']/li[" + i + "]/figure/figcaption/a[1]").Count > 0)
            {
                if(i > 1) { AlbumList += "\n"; }
                AlbumList += Driver.FindElementByXPath("//*[@id='myAlbumListAjax']/li[" + i + "]/figure/figcaption/a[1]").Text;
                i++;
            }
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            this.AlbumList = AlbumList.Split('\n');
        }
        void SetQuality(int option = 2)
        {
            var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[3]/button");
            element.Click();

            element = Driver.FindElementByXPath("//*[@id='checkQuality']");
            element.Click();

            ((IJavaScriptExecutor)Driver).ExecuteScript("document.getElementById('checkQuality').options["+option+"].selected=true;");

            element = Driver.FindElementByXPath("//*[@id='holdBackTrackPlayOption']/section/p/button");
            element.Click();
        }
        void AddPlayList(string AlbumName = "")
        {
            Ready = false;

            var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[3]/ul/li[4]/a");
            element.Click();
            if(Driver.FindElementsByXPath("//*[@title='" + AlbumName + "']/../../div[2]/button").Count > 0)
            {
                element = Driver.FindElementByXPath("//*[@title='" + AlbumName + "']/../../div[2]/button");
                element.Click();
            }
            else
            {
                throw new Exception("해당하는 앨범이 존재하지 않습니다.");
            }

            element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[3]/ul/li[2]/a");
            element.Click();

            element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/div[2]/div[1]/span[3]/button");
            element.Click();

            Ready = true;
        }
        void SetPlayList()
        {
            var element = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[3]/ul/li[1]/a");
            element.Click();

            element = Driver.FindElementByXPath("//*[@id='layerPlayList']/div[1]/div[1]/input");
            element.Click();

            element = Driver.FindElementByXPath("//*[@id='layerPlayList']/div[1]/div[2]/span[4]/button");
            element.Click();

            if (PlayList.Length > 0)
            {
                if (!PlayList[0].Equals(""))
                    foreach (string name in PlayList)
                    {
                        Thread.Sleep(200);
                        AddPlayList(name);
                    }
            }
        }
        private void GetLyrics_Tick(object sender, EventArgs e)
        {
            if(Ready && !GetLyricsThread.IsAlive && !GetSongNameThread.IsAlive)
            {
                GetLyricsThread.Start();
            }
            SongNameLabel.Text = Song;
            LyricsLabel1.Text = Lyrics1;
            LyricsLabel2.Text = Lyrics2;
        }
        void GetTheLyrics()
        {
            try
            {
                GetLyrics.Stop();
                if (Driver.FindElementsByXPath("/html/body/div[1]/div[3]/div/div[5]/div[3]/div[2]/div/div[1]/div/div[2]/strong").Count > 0)
                {
                    string[] Lyrics = Driver.FindElementByXPath("//*[@id='lyricsContent']").Text.Split('\n');
                    var element = Driver.FindElementByXPath("/html/body/div[1]/div[3]/div/div[5]/div[3]/div[2]/div/div[1]/div/div[2]/strong");
                    for (int i = 0; i < Lyrics.Length - 1; i++)
                    {
                        if (Lyrics[i].Contains(element.Text))
                        {
                            Lyrics1 = Lyrics[i];
                            Lyrics2 = Lyrics[i + 1];
                            break;
                        }
                    }
                }
                GetLyrics.Start();
            }
            catch (Exception) { }
        }
        void GetSongName()
        {
            try
            {
                var e1 = Driver.FindElementByXPath("//*[@id='pgBasicPlayer']/div[2]/dl/dt/span[2]/a").Text;
                var e2 = Driver.FindElementByXPath("//*[@id='newPlayerArtistName']").Text;
                Song = e1 + " - " + e2;
            }
            catch (Exception) { }
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
                    if (!GetSongNameThread.IsAlive && !GetLyricsThread.IsAlive)
                    {
                        GetSongNameThread.Start();
                    }
                    
                }
                catch (Exception) { }
            }
        }
        private void TransparentSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Opacity = Math.Max(decimal.ToInt32(TransparentSlider.Value), 25) / 100F;
            ini.Write("Setting", "Opacity", Opacity.ToString());
        }
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.ShowDialog();
        }
        private void SettingLoad_Tick(object sender, EventArgs e)
        {
            if (ini.Read("BackgroundColor", "Red").Length > 0)
            {
                BackColor = Color.FromArgb(255, int.Parse(ini.Read("BackgroundColor", "Red"))
                , int.Parse(ini.Read("BackgroundColor", "Green"))
                , int.Parse(ini.Read("BackgroundColor", "Blue")));
            }
            SongNameLabel.ForeColor = AutoChooseWB(BackColor);
            LyricsLabel1.ForeColor = AutoChooseWB(BackColor);
            LyricsLabel2.ForeColor = AutoChooseWB(BackColor, 100);
            btn_close.FlatAppearance.BorderColor = BackColor;
            SettingBtn.FlatAppearance.BorderColor = BackColor;
            ListBtn.FlatAppearance.BorderColor = BackColor;

            if (AutoChooseWB(BackColor).Equals(Color.FromArgb(255, 0, 0, 0)))
            {
                btn_close.Image = Properties.Resources.icons8_close_window_24;
                SettingBtn.Image = Properties.Resources.icons8_settings_16;
                ListBtn.Image = Properties.Resources.icons8_add_list_16;
            }
            else
            {
                btn_close.Image = Properties.Resources.icons8_close_window_24_negative;
                SettingBtn.Image = Properties.Resources.icons8_settings_16_negative;
                ListBtn.Image = Properties.Resources.icons8_add_list_16_negative;
            }
        }
        public Color AutoChooseWB(Color color, int strong = 0)
        {
            return (color.R + color.G + color.B) / 2F > 255 / 2F
                ? Color.FromArgb(255, 0 + strong, 0 + strong, 0 + strong)
                : Color.FromArgb(255, 255 - strong, 255 - strong, 255 - strong);
        }
        private void ListBtn_Click(object sender, EventArgs e)
        {
            new PlayListForm(this).ShowDialog();
            SetPlayList();
        }

        private void LyricsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception) { }
        }
    }
}
