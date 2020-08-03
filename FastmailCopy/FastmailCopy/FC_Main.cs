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
            FastmailTool copy = new FastmailTool();

            copy.copiaFiles(@"\\nas2\Fastmail\",0,txt_target.Text,txt_fmcode.Text);
            copy.copiaFiles(@"\\nas2\Fastmail\",1,txt_target.Text,txt_fmcode.Text);
            copy.copiaFiles(@"\\nas2\Fastmail\",2,txt_target.Text,txt_fmcode.Text);
            copy.copiaFiles(@"\\nas2\Fastmail\",3,txt_target.Text,txt_fmcode.Text);
            copy.copiaFiles(@"\\nas2\Fastmail\",4,txt_target.Text, txt_fmcode.Text);


        }
    }
}
