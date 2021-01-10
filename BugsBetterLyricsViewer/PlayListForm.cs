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
    public partial class PlayListForm : Form
    {
        LyricsForm lyricsForm;
        IniFile ini;
        bool New;
        public PlayListForm(LyricsForm lyricsForm, bool New = false)
        {
            InitializeComponent();
            this.lyricsForm = lyricsForm;
            ini = new IniFile("Setting.ini");
            this.New = New;
            lyricsForm.ReloadList = false;
        }
        private void PlayListForm_Shown(object sender, EventArgs e)
        {
            if(ini.Read("PlayList", "AutoLoad").Equals(true.ToString()) && New)
            {
                AutoLoadBox.Checked = true;
                Check(ini.Read("PlayList", "List"));
            }
            else
            {
                if(lyricsForm.AlbumList == null)
                {
                    lyricsForm.GetAlbumList();
                }
                if(ini.Read("PlayList", "AutoLoad").Length > 0)
                {
                    AutoLoadBox.Checked = bool.Parse(ini.Read("PlayList", "AutoLoad"));
                }
                foreach (string album in lyricsForm.AlbumList)
                {
                    PlayListBox.Items.Add(album);
                }
                foreach (string album in ini.Read("PlayList", "List").Split(','))
                {
                    for (int i = 0; i < PlayListBox.Items.Count; i++)
                    {
                        if (PlayListBox.GetItemText(PlayListBox.Items[i]).Equals(album))
                        {
                            PlayListBox.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }
        private void CheckBtn_Click(object sender, EventArgs e)
        {
            string PlayList = "";
            foreach (object item in PlayListBox.CheckedItems)
            {
                if (PlayList.Length > 0) { PlayList += ","; }
                PlayList += item.ToString();
            }
            Check(PlayList);
        }
        void Check(string playList)
        {
            lyricsForm.ReloadList = true;
            lyricsForm.PlayList = playList.Split(',');

            ini.Write("PlayList", "List", playList);
            ini.Write("PlayList", "AutoLoad", AutoLoadBox.Checked.ToString());

            Close();
        }
    }
}
