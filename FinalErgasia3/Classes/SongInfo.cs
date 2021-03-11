using FinalErgasia3.Forms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia3.Classes
{
    class SongInfo
    {
        public SongInfo()
        {
        }

        //I monadiki xrisi tou TagLib ginete se auto to function, otan o xristis prosthesi to tragoudi gia prwti fora
        //tha prospathisei to programma na kanei load ta stoixeia tou arxiou san default stoixeia.
        public void CreateSongInfoFile(string song, string songFullPath)
        {
            if (!Directory.Exists("Data\\Info"))
            {
                Directory.CreateDirectory("Data\\Info");
            }
            string path = "Data\\Info\\" + song + ".txt";
            if (!File.Exists(path))
            {
                FileStream file = File.Create(path);
                file.Close();

                //Pernoume ta stoixeia tou arxeiou
                var tagFile = TagLib.File.Create(songFullPath);

                string[] tagArtist = tagFile.Tag.AlbumArtists;
                string finalArtist = "", finalGenre = "";
                //Ta vazoume ksexwrista se ena string gia na mporesoume na ta apothikeusoume
                for (int i = 0; i < tagArtist.Length; i++) { finalArtist += tagArtist[i]; }
                var tagAlbum = tagFile.Tag.Album;
                string tagYear = tagFile.Tag.Year.ToString();
                if (tagYear == "0")
                {
                    tagYear = "";
                }
                var tagGenre = tagFile.Tag.Genres;
                for (int i = 0; i < tagGenre.Length; i++) { finalGenre += tagGenre[i]; }

                WriteSongInfo(path, finalArtist, tagAlbum.ToString(), tagYear.ToString(), finalGenre, "Unknown Language");
            }
        }

        public void WriteSongInfo(string path, string artist, string album, string year, string genre, string language)
        {
            using (System.IO.StreamWriter file2 =
                new System.IO.StreamWriter(path, true))
            {
                file2.Write("[Artist]" + artist 
                    + Environment.NewLine
                    + "[Album]" + album
                    + Environment.NewLine
                    + "[Year]" + year
                    + Environment.NewLine
                    + "[Genre]" + genre
                    + Environment.NewLine
                    + "[Language]" + language);
                file2.Close();
            }
        }

        public string LoadSongInfo(string song)
        {
            Main main = new Main();
            
            foreach (var file in new DirectoryInfo("Data\\Info").GetFiles("*.txt"))
            {
                //Ean to tragoudi yparxei mesa sto directory
                if (song + ".txt" == file.ToString())
                {
                    string artist = "Artist: " + File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(0).Replace("[Artist]", "");
                    string album = "Album: " + File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(1).Replace("[Album]", "");
                    string year = "Year: " + File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(2).Replace("[Year]", "") + " / ";
                    //Ean to year den einai kataxwrimeno, diladi kaino "" tote min to emfaniseis kan
                    if (File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(2).Replace("[Year]", "") == "")
                    {
                        year = "";
                    }
                    string genre = "Genre: " + File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(3).Replace("[Genre]", "");
                    string language = "Language: " + File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(4).Replace("[Language]", "");
                    return artist + " / " + album + " / " + year + genre + " / " + language;
                }
            }
            return "";
        }

        public static string editArtist, editAlbum, editYear, editGenre, editLanguage;
        public void LoadSongInfoToEdit(string song)
        {
            EditInfo editInfo = new EditInfo();

            string artist = "", album = "", year = "", genre = "", language = "";
            foreach (var file in new DirectoryInfo("Data\\Info").GetFiles("*.txt"))
            {
                //Ean to tragoudi yparxei sto directory
                if (song + ".txt" == file.ToString())
                {
                    artist = File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(0).Replace("[Artist]", "");
                    album = File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(1).Replace("[Album]", "");
                    year = File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(2).Replace("[Year]", "");
                    genre = File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(3).Replace("[Genre]", "");
                    language = File.ReadLines("Data\\Info\\" + song + ".txt").ElementAtOrDefault(4).Replace("[Language]", "");
                    break;
                }
            }
            //Apothikevoume ta stoixeia stis static metavlites gia na tis perasoume sta textboxes tis EditInfo formas.
            editArtist = artist;
            editAlbum = album;
            editYear = year;
            editGenre = genre;
            editLanguage = language;
        }
    }
}
