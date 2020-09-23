using System;
using System.IO;
using System.Windows.Forms;

namespace FastmailCopy
{
    class FastmailTool
    {
        public void getFMFiles(String Dsource,  String Dtarget, bool copySubDirs)
        {
            DirectoryInfo dirTarget = new DirectoryInfo(Dtarget);
            DirectoryInfo dirSource = new DirectoryInfo(Dsource);
            

            if ( dirSource.Exists )
            {
                if (!dirTarget.Exists)
                {
                    Directory.CreateDirectory(Dtarget);
                }
                foreach (FileInfo file in dirSource.GetFiles())
                {
                    file.CopyTo( Path.Combine(dirTarget.FullName, file.Name) );
                }

                if ( copySubDirs)
                {
                    foreach( DirectoryInfo dSourceSubDir in dirSource.GetDirectories() )
                    {
                        DirectoryInfo subDirTarget = dirTarget.CreateSubdirectory(dSourceSubDir.Name);

                        foreach (FileInfo file in dSourceSubDir.GetFiles())
                        {
                            file.CopyTo(Path.Combine(subDirTarget.FullName, file.Name));
                        }
                        getFMFiles(dSourceSubDir.Name, subDirTarget.Name,true);
                    }
                }
            }
        }
    }
}
