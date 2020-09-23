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
            while ( year <= DateTime.Now.Year )
            {
                
                string Vsource = @"\\nas2\Fastmail\verbali\" + year + @"\" + txt_fmcode.Text;
                string Vdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Verbali" + @"\" + year;
                copy.getFMFiles(Vsource, Vdest, true);
                
                string Rsource = @"\\nas2\Fastmail\images\" + year + @"\" + txt_fmcode.Text;
                string Rdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Rendicontazioni" + @"\" + year;
                copy.getFMFiles(Rsource, Rdest, true);
                
                string Csource = @"\\nas2\Fastmail\Cad\" + year + @"\" + txt_fmcode.Text;
                string Cdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Cad" + @"\" + year;
                copy.getFMFiles(Csource, Cdest, true);

                string Bsource = @"\\nas2\Fastmail\buste\" + year + @"\" + txt_fmcode.Text;
                string Bdest = txt_target.Text + @"\" + txt_fmcode.Text + @"\" + "Buste" + @"\" + year;
                copy.getFMFiles(Bsource, Bdest, true);

                year++;
            }
            MessageBox.Show("Operazione terminata");

        }
    }
}
