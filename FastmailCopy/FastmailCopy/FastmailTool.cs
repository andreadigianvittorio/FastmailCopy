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
            
            



            int anno = 2013; /*  necessario calcolare di volta in volta l'anno in quanto i pdf sono divisi per annualità */

            FileType fileType = (FileType)type;
            source = Path.Combine(source, fileType.ToString(), codCli);
            MessageBox.Show(source);
        }
    }
}
