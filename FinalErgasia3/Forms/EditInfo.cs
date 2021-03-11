using FinalErgasia3.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace FinalErgasia3.Forms
{
    public partial class EditInfo : Form
    {
        private bool changes = false;
        public static string SelectedSong;
        SongInfo songInfo = new SongInfo();

        public EditInfo()
        {
            InitializeComponent();
        }

        public void save()
        {
            string path = "Data\\Info\\" + SelectedSong + ".txt";
            File.Delete(path);
            FileStream file = File.Create(path);
            file.Close();
            songInfo.WriteSongInfo(path, textBoxArtist.Text, textBoxAlbum.Text, textBoxYear.Text, textBoxGenre.Text, textBoxLanguage.Text);
            //Allazoume ta changes se false afou ta kaname save
            changes = false;
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            
            songInfo.LoadSongInfoToEdit(SelectedSong);
            textBoxArtist.Text = SongInfo.editArtist;
            textBoxAlbum.Text = SongInfo.editAlbum;
            textBoxYear.Text = SongInfo.editYear;
            textBoxGenre.Text = SongInfo.editGenre;
            textBoxLanguage.Text = SongInfo.editLanguage;
            //Allazoume ta changes se false epidi otan kanei load i forma allazei ta stoixeia tou textbox ara extelite to event
            changes = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void textBoxYear_KeyDown(object sender, KeyEventArgs e)
        {
            //Apenergopioisi tou paste (Ctrl + V).
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Auto tha apotrepsei ton xristi na xrisimopisi space & allous xaraktires.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes == true)
            {
                DialogResult result = MessageBox.Show("Your changes have not been saved! Do you want to save them?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    save();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            changes = true;
        }
    }
}
