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
            string DT = DateTime.Today.Date.ToLongDateString();
            if (File.Exists($"effectivnost {DT}.txt"))
            {
                File.AppendAllText($"effectivnost {DT}.txt", ResultWrite);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter($"effectivnost {DT}.txt"))
                {
                    sw.WriteLine(ResultWrite);
                    sw.Close();
                }
            }
        }
    }
}
