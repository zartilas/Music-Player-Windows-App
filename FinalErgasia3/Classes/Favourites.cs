using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia3.Classes
{
    class Favourites
    {
        public static List<String> favouritesList = new List<string>();
        

        public Favourites()
        {
        }

        public void AddToFavouriteDirectory(string song, string fullpath)
        {
            string path = "Data\\Favourites\\" + song + ".txt";
            if (!File.Exists(path))
            {
                FileStream file = File.Create(path);
                file.Close();
            }
            if (new FileInfo(path).Length == 0)
            {
                using (StreamWriter file =
                    new StreamWriter("Data\\Favourites\\" + song + ".txt", true))
                {
                    file.Write(1 + Environment.NewLine + fullpath);
                    file.Close();
                }
            }
            else
            {
                int songFrequency = Int32.Parse(File.ReadLines("Data\\Favourites\\" + song + ".txt").First());
                songFrequency++;
                File.Delete("Data\\Favourites\\" + song + ".txt");
                FileStream file = File.Create("Data\\Favourites\\" + song + ".txt");
                file.Close();
                using (StreamWriter file2 =
                    new StreamWriter("Data\\Favourites\\" + song + ".txt", true))
                {
                    file2.Write(songFrequency.ToString() + Environment.NewLine + fullpath);
                    file2.Close();
                }
            }
        }

        public void AddToFavouriteList(string song)
        {
            if (!favouritesList.Contains(song))
            {
                favouritesList.Add(song);
            }
        }

        public void Sort()
        {
            Favourites.favouritesList.Clear();
            if (new DirectoryInfo("Data\\Favourites").GetFileSystemInfos().Length == 0)
            {
                return;
            }
            
            DirectoryInfo d = new DirectoryInfo("Data\\Favourites");
            FileInfo[] Files = d.GetFiles("*.txt");

            string[,] array = new string[Directory.GetFiles("Data\\Favourites", "*.txt", SearchOption.TopDirectoryOnly).Length, 2];
            int i = 0, j = 0;
            foreach (FileInfo file in Files)
            {
                //MessageBox.Show(File.ReadLines(file.FullName).First());

                array[i, j] = file.Name.Replace(".txt", "");
                array[i, j + 1] = File.ReadLines(file.FullName).First();
                i++;
                j = 0;
            }

            ArraySort comparer = new ArraySort(array, 1);
            string[,] sortedData = comparer.ToSortedArray();
            for (i = 0; i < sortedData.GetLength(0); i++)
            {
                AddToFavouriteList(sortedData[i,0]);
            }
            Main main = new Main();
            main.buttonShuffleAll.Text = "Shuffle All (" + favouritesList.Count + ")";
        }
    }
}
