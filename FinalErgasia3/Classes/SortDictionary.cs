using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalErgasia3.Classes
{
    class SortDictionary
    {
        public static Dictionary<string, int> favouritesDirectory = new Dictionary<string, int>();

        LoadFavourites fav = new LoadFavourites();
        public SortDictionary()
        {
            foreach (KeyValuePair<string, int> song in favouritesDirectory.OrderByDescending(key => key.Value))
            {
                MessageBox.Show(song.Key + " " + song.Value);
                fav.AddFavourites(song.Key);
            }
        }
    }
}
