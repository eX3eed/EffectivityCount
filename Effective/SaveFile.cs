using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Effective
{
    class SaveFile
    {
        public void FileSave(string ResultWrite)
        {

            if (File.Exists("effectivnost.txt"))
            {
                File.AppendAllText("effectivnost.txt", ResultWrite);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("effectivnost.txt"))
                {
                    sw.WriteLine(ResultWrite);
                    sw.Close();
                }
            }
        }
    }
}
