using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastmailCopy
{
    class FastmailTool
    {
        private String verSource = @"\\nas2\Fastmail\verbali";
        private String renSource = @"\\nas2\Fastmail\rendicontazioni";
        private String busSource = @"\\nas2\Fastmail\buste";
        private String cadSource = @"\\nas2\Fastmail\cad";
        private String pecSource = @"\\nas2\Fastmail\pec";

        public void copiaVerbali(String source, String target, String codCli)
        {
            int anno = 2013; /*  necessario calcolare di volta in volta l'anno in quanto i pdf sono divisi per annualità */

           
            while ( anno <= System.DateTime.Today.Year)
            {
                MessageBox.Show(anno.ToString());
                anno++;
            }
        }
    }
}
