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
            CopiaVerbali copia_verbali = new CopiaVerbali();
            CopiaRendicontazioni copia_rendicontazioni = new CopiaRendicontazioni();
            CopiaPEC copia_pec = new CopiaPEC();
            CopiaCAD copia_cad = new CopiaCAD();
            copia_verbali.copy(@"C:\Users\andre\Downloads", txt_target.Text);
            

        }
    }
}
