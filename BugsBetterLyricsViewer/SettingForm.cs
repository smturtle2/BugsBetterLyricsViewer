using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugsBetterLyricsViewer
{
    public partial class SettingForm : Form
    {
        IniFile ini;
        LyricsForm lyricsForm;
        public SettingForm(LyricsForm lyricsForm)
        {
            InitializeComponent();
            this.lyricsForm = lyricsForm;

            ini = new IniFile("Setting.ini");
            if (ini.Read("BackgroundColor", "Red").Length > 0)
            {
                BackgroundColor.Color = Color.FromArgb(255, int.Parse(ini.Read("BackgroundColor", "Red"))
                , int.Parse(ini.Read("BackgroundColor", "Green"))
                , int.Parse(ini.Read("BackgroundColor", "Blue")));
            }
            BackColorBtn.BackColor = BackgroundColor.Color;
            BackColorBtn.ForeColor = lyricsForm.AutoChooseWB(BackgroundColor.Color);
        }
        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            BackgroundColor.ShowDialog();
            BackColorBtn.BackColor = BackgroundColor.Color;
            BackColorBtn.ForeColor = lyricsForm.AutoChooseWB(BackgroundColor.Color);
            ini.Write("BackgroundColor", "Red", BackgroundColor.Color.R.ToString());
            ini.Write("BackgroundColor", "Green", BackgroundColor.Color.G.ToString());
            ini.Write("BackgroundColor", "Blue", BackgroundColor.Color.B.ToString());
        }

    }
}
