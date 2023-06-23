using System;
using System.Windows.Forms;



namespace FastmailCopy
{
    public partial class FC_Main : Form
    {
        public FC_Main()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Uscire dall'applicazione?","Message",MessageBoxButtons.YesNo) == DialogResult.No )
            {
                this.Show();
            }
            else {
                Application.Exit();
             }
          }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            fbd_fmbrowsefile.ShowDialog();
            txt_target.Text = fbd_fmbrowsefile.SelectedPath;
        }

        private void btn_startcopy_Click(object sender, EventArgs e)
        {   
            FastmailTool copy = new FastmailTool( );
            int year = 2000;
            /* Devo generare la source e la dest */
            while (year <= DateTime.Now.Year)
            {
                if (chkVerbali.Checked == true)
                {
                    string Vsource = @"\\nas3\Fastmail\verbali\" + year + @"\" + txt_fmcode.Text;
                    string Vdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Verbali" + @"\" + year;
                    copy.getFMFiles(Vsource, Vdest, true);
                }
                else
                {
                    MessageBox.Show("Copia verbali non selezionata");
                    break;
                }
                year++;
            }
            MessageBox.Show("Copia verbali terminata");
            /*___________________________________________________________________________________________**/
            year = 2000;
            while (year <= DateTime.Now.Year)
            {
                if (chkImage.Checked == true)
                {
                    string Rsource = @"\\nas3\Fastmail\images\" + year + @"\" + txt_fmcode.Text;
                    string Rdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Rendicontazioni" + @"\" + year;
                    copy.getFMFiles(Rsource, Rdest, true);
                }
                else
                {
                    MessageBox.Show("Copia rendicontazioni non selezionata");
                    break;
                }
                year++;   
            }
            MessageBox.Show("Copia rendicontazioni terminata");
            /*___________________________________________________________________________________________**/
            year = 2000;
            while (year <= DateTime.Now.Year)
            {
                if (chkCad.Checked == true)
                {
                    string Rsource = @"\\nas3\Fastmail\Cad\" + year + @"\" + txt_fmcode.Text;
                    string Rdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Cad" + @"\" + year;
                    copy.getFMFiles(Rsource, Rdest, true);
                }
                else
                {
                    MessageBox.Show("Copia cad non selezionata");
                    break;
                }
                year++;
            }
            MessageBox.Show("Copia cad terminata");
            /*___________________________________________________________________________________________**/
            year = 2000;
            while (year <= DateTime.Now.Year)
            {
                if (chkBuste.Checked == true)
                {
                    string Rsource = @"\\nas3\Fastmail\Buste\" + year + @"\" + txt_fmcode.Text;
                    string Rdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Buste" + @"\" + year;
                    copy.getFMFiles(Rsource, Rdest, true);
                }
                else
                {
                    MessageBox.Show("Copia buste non selezionata");
                    break;
                }
                year++;
            }
            MessageBox.Show("Copia buste terminata");
            /*___________________________________________________________________________________________**/
            year = 2000;
            while (year <= DateTime.Now.Year)
            {
                if (chkPec.Checked == true)
                {
                    string Rsource = @"\\nas3\Fastmail\Pec\" + year + @"\" + txt_fmcode.Text;
                    string Rdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Pec" + @"\" + year;
                    copy.getFMFiles(Rsource, Rdest, true);
                }
                else
                {
                    MessageBox.Show("Copia pec non selezionata");
                    break;
                }
                year++;
            }
            MessageBox.Show("Copia pec terminata");
            /*___________________________________________________________________________________________**/
            MessageBox.Show("Dump completato");

        }
    }
}
