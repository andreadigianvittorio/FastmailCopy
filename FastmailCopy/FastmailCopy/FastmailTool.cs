using System;
using System.IO;
using System.Windows.Forms;

namespace FastmailCopy
{
    class FastmailTool
    {
        enum FileType { verbali, images, buste, cad, pec}

        public void copiaFiles(String source, int type, String target, String codCli)
        { 
            FileType fileType = (FileType)type;
            String rTarget = Path.Combine(target, codCli,fileType.ToString());
            DirectoryInfo dPath = new DirectoryInfo(rTarget);

            DirectoryInfo Dirs = new DirectoryInfo(@"\\nas2\fastmail\verbali\2020");


            DirectoryInfo[] dirs = Dirs.GetDirectories();

            foreach ( DirectoryInfo subdir in dirs)
            {
                MessageBox.Show(subdir.ToString());
            }
            
            

            



            

            
        }
    }
}
