using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FastmailCopy
{
    class CopiaVerbali
    {
        public void copy(String SPath, String TPath)
        {
            DirectoryInfo SDir = new DirectoryInfo(SPath);
            DirectoryInfo TDir = new DirectoryInfo(Path.Combine(TPath, "TEST"));
            TDir.Create();

            TPath = Path.Combine(TPath, TDir.Name);
            FileInfo[] files = SDir.GetFiles();
            foreach(FileInfo file in files)
            {
                string TempPath = Path.Combine(TPath, file.Name);
                file.CopyTo(TempPath,false);
            }
            
        }
    }
}
