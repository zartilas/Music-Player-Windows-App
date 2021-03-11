using FinalErgasia3.Classes;
using FinalErgasia3.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia3
{
    public partial class Main : Form
    {
        private bool shuffle = false;
        private bool repeat = false;
        private bool playButton = false, playingSong = false, favouriteSection = false;
        private int counter = 0;
        private string selectedSongFullPath, selectedSongName;
        private Random random = new Random();
        Favourites favourites = new Favourites();

        public Main()
        {
            InitializeComponent();
        }

        List<string> listSongsFull = new List<string>();
        public void refresh()
        {
            listSongs.Items.Clear();
            listSongsFull.Clear();
            foreach (string line in File.ReadLines("Data\\Songs.txt"))
            {
                string songFile = Path.GetFileName(line);
                if (!listSongs.Items.Contains(songFile.Replace(".mp3", "")))
                {
                        listSongsFull.Add(line);
                        listSongs.Items.Add(songFile.Replace(".mp3", ""));
                }
            }
            buttonShuffleAll.Text = " Shuffle All (" + listSongs.Items.Count + ")";
        }

        public void playingState()
        {
            if (playButton == true && playingSong == true)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                playButton = false;
                buttonPlay_Pause.BackgroundImage = Properties.Resources.Play;
                return;
            }
            if (playButton == false && playingSong == true)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                playButton = true;
                playingSong = true;
                buttonPlay_Pause.BackgroundImage = Properties.Resources.Pause;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Ean o fakelos Data den iparxei tote dimiourgise ton.
            if (!Directory.Exists("Data") || !Directory.Exists("Data\\Favourites") || !File.Exists("Data\\Songs.txt"))
            {
                CreateFiles createFiles = new CreateFiles();
            }

            refresh();
            favourites.Sort();
            labelCurrentSong.Text = "";
            labelCurrentSongInfo.Text = "";
            buttonShuffleAll.Text = " Shuffle All (" + listSongs.Items.Count + ")";
        }

        private void buttonPlay_Pause_Click(object sender, EventArgs e)
        {
            playingState();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                shuffle = true;
                buttonShuffle.BackgroundImage = Properties.Resources.ShuffleSelected;
                return;
            }
            buttonShuffle.BackgroundImage = Properties.Resources.Shuffle;
            shuffle = false;
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                WindowsMediaPlayer.settings.setMode("loop", true);
                repeat = true;
                buttonRepeat.BackgroundImage = Properties.Resources.RepeatSelected;
                return;
            }
            WindowsMediaPlayer.settings.setMode("loop", false);
            buttonRepeat.BackgroundImage = Properties.Resources.Repeat;
            repeat = false;
        }

        private void buttonPreviousSong_Click(object sender, EventArgs e)
        {
            //Ean den yparxei mono 1 antikimeno stin lista tote
            if (listSongs.Items.Count != 1)
            {
                if (listSongs.SelectedIndex - 1 == -1)
                {
                    listSongs.SelectedIndex = listSongs.Items.Count - 1;
                }
                else
                {
                    try
                    {
                        listSongs.SelectedIndex = listSongs.SelectedIndex - 1;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        listSongs.SelectedIndex = 0;
                    }
                }
                songTimer.Stop();
                songTimer.Enabled = false;
                counter = 0;
                labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);

                WindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonNextSong_Click(object sender, EventArgs e)
        {
            //Ean den yparxei mono 1 antikimeno stin lista tote
            if (listSongs.Items.Count != 1)
            {
                //Dokimase na kaneis prosthesi to idi epilegmeno stoixeio tis listas +1
                try
                {
                    listSongs.SelectedIndex = listSongs.SelectedIndex + 1;
                }
                //Ean vgalei auto to exception epidi exoume vgei extos oriwn
                catch (ArgumentOutOfRangeException)
                {
                    listSongs.SelectedIndex = 0;
                }
                songTimer.Stop();
                songTimer.Enabled = false;
                counter = 0;
                labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);

                WindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        //Dimirgoume mia metavliti kai tin arxikopioume me -1, auto einai to epilegmeno index tis listas arxika epidi den exei epilegmeno tragoudi o xristis
        private int currentIndex = -1;
        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elexoume kathe fora pou ginete allagi sto index, ean to kanourgio index einai to idio me to palio
            //i ean o xristis patisei click kapou mesa sto listbox tote den tha ektelestei o kwdikas
            if (listSongs.SelectedIndex == currentIndex) { return; }
            currentIndex = listSongs.SelectedIndex;

            //Ean to epilegmeno item einai akiro epestrepse
            if (listSongs.SelectedItem == null)
            {
                buttonDeleteSong.Visible = false;
                buttonEditInfo.Visible = false;
                return;
            }
            else
            {
                if (favouriteSection == false)
                {
                    buttonDeleteSong.Visible = true;
                    buttonEditInfo.Visible = true;
                }
            }

            
            selectedSongName = listSongs.SelectedItem.ToString();
            //Ean to tragoudi yparxei mesa stin lista pu periexei to full path tote apothikeuse to stin metavliti
            selectedSongFullPath = listSongsFull.FirstOrDefault(stringToCheck => stringToCheck.Contains(listSongs.SelectedItem.ToString()));
            if (selectedSongFullPath == null)
            {
                MessageBox.Show("Song could not be played. Maybe it has been moved from the saved directory.");
                return;
            }
            //Vale sto url tou player to path
            WindowsMediaPlayer.URL = selectedSongFullPath;

            favourites.AddToFavouriteDirectory(listSongs.SelectedItem.ToString(), selectedSongFullPath);
            favourites.Sort();

            songTimer.Stop();
            counter = 0;
            labelSongDuration.Text = "00:00";
            songTimer.Start();

            labelCurrentSong.Text = "Playing: " + listSongs.SelectedItem.ToString();
            SongInfo songInfo = new SongInfo();
            labelCurrentSongInfo.Text = songInfo.LoadSongInfo(listSongs.SelectedItem.ToString());
        }

        private void WindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Ean to tragoudi teliose kai to koumpi repeat einai epilegmeno, gia kapio logo i katastasi
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && repeat == true)
            {
                counter = 0;
                labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);
            }
            //Ean to tragoudi stamatise (Apo ton xristi) i ean to ekane pausi
            if (e.newState == 1)
            {
                songTimer.Stop();
                songTimer.Enabled = false;
                counter = 0;
                labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);
                buttonPlay_Pause.BackgroundImage = Properties.Resources.Play;
            }
            //Ean o xristis to ekane pause
            if (e.newState == 2)
            {
                songTimer.Stop();
                buttonPlay_Pause.BackgroundImage = Properties.Resources.Play;
            }
            //Ean pezei tragoudi
            if (e.newState == 3)
            {
                songTimer.Enabled = true;
                songTimer.Start();
                playingSong = true;
                playButton = false;
                playingState();
                //buttonPlay_Pause.BackgroundImage = Properties.Resources.Pause;
            }
            //Ean to tragoudi teliose na pezei
            if (e.newState == 8)
            {
                if (repeat == true)
                {
                    return;
                }
                if (shuffle == true)
                {
                    listSongs.SelectedIndex = random.Next(0, listSongs.Items.Count);

                    if (selectedSongFullPath != null)
                    {
                        WindowsMediaPlayer.Ctlcontrols.play();
                        return;
                    }
                }
                try
                {
                    listSongs.SelectedIndex = listSongs.SelectedIndex + 1;
                }
                catch (ArgumentOutOfRangeException)
                {
                    listSongs.SelectedIndex = 0;
                }
                songTimer.Stop();
                songTimer.Enabled = false;
                counter = 0;
                labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);

                WindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonAddNewSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Music Files (*.mp3)|*.mp3";
            //Me auton ton tropo tha deiksoume to palio XP style file dialog pou einai pio swsto
            fileDialog.AutoUpgradeEnabled = false;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = true;
            fileDialog.Title = "Please select file(s) to add";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SongInfo songInfo = new SongInfo();
                foreach (String file in fileDialog.FileNames)
                {
                        string song = Path.GetFileName(file).Replace(".mp3", "");
                        if (!listSongs.Items.Contains(song))
                        {
                            WriteSongsFile writeNewSong = new WriteSongsFile(file);
                            listSongsFull.Add(file);
                            listSongs.Items.Add(song);
                            songInfo.CreateSongInfoFile(song, file);
                        }
                        else
                        {
                            MessageBox.Show(song + Environment.NewLine + "already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                buttonShuffleAll.Text = " Shuffle All (" + listSongs.Items.Count + ")";
            }
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            labelSongDuration.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            playingSong = false;
            listSongs.SelectedIndex = -1;
            WindowsMediaPlayer.URL = "";
            labelCurrentSong.Text = "";
            labelCurrentSongInfo.Text = "";
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            favouriteSection = false;
            //Dinoume pisw tin oratotita tous dioti mporei na patithike prin to koumpi Favourites
            buttonRefresh.Visible = true;
            buttonClearFavourites.Visible = false;
            buttonAddNewSong.Visible = true;
            buttonDeleteSong.Visible = true;
            listSongs.Visible = true;
            labelNoFavouritesFound.Visible = false;
            //Kanume Refresh gia na valoume pisw ola ta tragoudia
            refresh();
        }
        private void buttonMusic_MouseEnter(object sender, EventArgs e)
        {
            buttonMusic.FlatAppearance.BorderSize = 1;
            buttonMusic.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void buttonMusic_MouseLeave(object sender, EventArgs e)
        {
            buttonMusic.FlatAppearance.BorderSize = 0;
        }

        private void buttonShuffleAll_MouseEnter(object sender, EventArgs e)
        {
            buttonShuffleAll.ForeColor = Color.Silver;
        }
        private void buttonShuffleAll_MouseLeave(object sender, EventArgs e)
        {
            buttonShuffleAll.ForeColor = Color.WhiteSmoke;
        }
        private void buttonShuffleAll_Click(object sender, EventArgs e)
        {
            listSongs.SelectedIndex = random.Next(0, listSongs.Items.Count);
            var match = listSongsFull.FirstOrDefault(stringToCheck => stringToCheck.Contains(listSongs.SelectedItem.ToString()));

            if (match != null)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonRefresh_MouseEnter(object sender, EventArgs e)
        {
            buttonRefresh.ForeColor = Color.Silver;
        }
        private void buttonRefresh_MouseLeave(object sender, EventArgs e)
        {
            buttonRefresh.ForeColor = Color.WhiteSmoke;
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void buttonFavourites_MouseEnter(object sender, EventArgs e)
        {
            buttonFavourites.FlatAppearance.BorderSize = 1;
            buttonFavourites.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void buttonFavourites_MouseLeave(object sender, EventArgs e)
        {
            buttonFavourites.FlatAppearance.BorderSize = 0;
        }

        private void buttonFavourites_Click(object sender, EventArgs e)
        {
            favouriteSection = true;
            //Krivoume to koumpi Refresh dioti den xriazete na kanume refresh ta favourites alla i methodos auti tha
            //kanei reload ola ta tragoudia kai oxi ta favourites.
            buttonRefresh.Visible = false;
            buttonAddNewSong.Visible = false;
            buttonDeleteSong.Visible = false;
            //Katharizoume tin kiria lista mas gia na prosthesoume ta agapimena tragoudia
            listSongs.Items.Clear();
            foreach (string i in Favourites.favouritesList)
            {
                listSongs.Items.Add(i);
            }
            //Ean den yparxoun agapimena tote kripse to control tis listas kai emfanise to label pou exei to antistixo minima
            if (listSongs.Items.Count == 0)
            {
                listSongs.Visible = false;
                buttonClearFavourites.Visible = false;
                labelNoFavouritesFound.Visible = true;
            }
            else
            {
                buttonClearFavourites.Visible = true;
            }
            buttonShuffleAll.Text = " Shuffle All (" + listSongs.Items.Count + ")";
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            EditInfo.SelectedSong = listSongs.SelectedItem.ToString();
            EditInfo editInfo = new EditInfo();
            editInfo.ShowDialog();
        }

        private void buttonDeleteSong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this song?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string selectedSong = listSongs.SelectedItem.ToString();

                //Ean yparxei auto to string mesa stin lista listSongsFull tote pare to item epidi auto tha einai to full path tou tragoudiou
                var match = listSongsFull.FirstOrDefault(stringToCheck => stringToCheck.Contains(selectedSong));

                //Diagrafi apo oles tis listes, afou to diagrafei, tha diagrafei kai apo ta favourites
                listSongsFull.Remove(match);
                listSongs.Items.Remove(selectedSong);
                Favourites.favouritesList.Remove(selectedSong);

                //Ksana grapse to arxeio xwris to song pou diagraftike
                string file = "Data" + "\\" + "Songs.txt";
                var temp = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(file).Where(l => l != match);
                File.WriteAllLines(temp, linesToKeep);
                File.Delete(file);
                File.Move(temp, file);
                
                File.Delete("Data\\Favourites\\" + selectedSong + ".txt");
                File.Delete("Data\\Info\\" + selectedSong + ".txt");

                //Ean to tragoudi pou pezei twra einai to tragoudi pou diagraftike
                if (selectedSongName == selectedSong)
                {
                    labelCurrentSong.Text = "";
                    labelCurrentSongInfo.Text = "";
                    WindowsMediaPlayer.Ctlcontrols.stop();
                }
                //Ean den yparxoun tragoudia mesa stin lista kai eimaiste stin perioxi gia ta favourites
                if (listSongs.Items.Count == 0 && favouriteSection == true)
                {
                    listSongs.Visible = false;
                    labelNoFavouritesFound.Visible = true;
                }
                //Grapse ton swsto arithmo tragoudiwn sto koumpi
                buttonShuffleAll.Text = "Shuffle All (" + listSongs.Items.Count + ")"; 
            }
        }
        
        private void buttonClearFavourites_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear your favourites?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Katharise oles tis listes epidi kanume reset
                listSongs.Items.Clear();
                listSongsFull.Clear();
                Favourites.favouritesList.Clear();

                //Diagrapse ola ta files apo to fakelo Favourites
                foreach (FileInfo file in new DirectoryInfo("Data\\Favourites").GetFiles())
                {
                    file.Delete();
                }
                //Kripse to koumpi clear favourites afou adiasame tin lista
                buttonClearFavourites.Visible = false;
                //Kripse tin lista
                listSongs.Visible = false;
                //Emfanise to label pou leei oti den yparxoun favourites
                labelNoFavouritesFound.Visible = true;
                //Kane to text tou koumpiou sto parakatw afou den tha yparxoun favourites
                buttonShuffleAll.Text = "Shuffle All (0)";
            }
        }
    }
}
