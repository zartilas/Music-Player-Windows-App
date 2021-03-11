using System;

namespace FinalErgasia3.Classes
{
    class WriteSongsFile
    {
        public WriteSongsFile(string newLine)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Data" + "\\" + "Songs.txt", true))
            {
                file.Write(newLine + Environment.NewLine);
                file.Close();
            }
        }
    }
}
