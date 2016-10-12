using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader
{
    class SelectFolder
    {
        public static void GetFilesFromFolder(string _path, string type="pdf")
        {
            for (int i = 0; i < _path.Count(); i++)
            {
                if ((_path[i] == (char)92) & (_path[i] == (char)92))
                {
                    _path = _path.Remove(i, 1);
                }
            }
            Directory.GetFiles(_path, "*."+type);
        }


        string[] filePaths = Directory.GetFiles(@"c:\MyDir\", "*.bmp");
    }
}
