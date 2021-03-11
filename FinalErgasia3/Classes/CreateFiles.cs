using System.IO;

namespace FinalErgasia3.Classes
{
    class CreateFiles
    {
        public CreateFiles()
        {
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Data\\Favourites");

            string soloFilesPath = "Data" + "\\" + "Songs.txt";
            FileStream fileStream = File.Create(soloFilesPath);
            fileStream.Close();
        }
    }
}
