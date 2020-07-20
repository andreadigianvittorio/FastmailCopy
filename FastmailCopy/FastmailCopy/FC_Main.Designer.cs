namespace FastmailCopy
{
    partial class FC_Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.lblFMCode = new System.Windows.Forms.Label();
            this.txt_fmcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.fbd_fmbrowsefile = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_startcopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(453, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lblFMCode
            // 
            this.lblFMCode.AutoSize = true;
            this.lblFMCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFMCode.Location = new System.Drawing.Point(28, 37);
            this.lblFMCode.Name = "lblFMCode";
            this.lblFMCode.Size = new System.Drawing.Size(99, 16);
            this.lblFMCode.TabIndex = 1;
            this.lblFMCode.Text = "Codice Fastmail";
            // 
            // txt_fmcode
            // 
            this.txt_fmcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_fmcode.Location = new System.Drawing.Point(150, 34);
            this.txt_fmcode.MaxLength = 4;
            this.txt_fmcode.Name = "txt_fmcode";
            this.txt_fmcode.Size = new System.Drawing.Size(82, 23);
            this.txt_fmcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destinazione files";
            // 
            // txt_target
            // 
            this.txt_target.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_target.Location = new System.Drawing.Point(150, 92);
            this.txt_target.Name = "txt_target";
            this.txt_target.ReadOnly = true;
            this.txt_target.Size = new System.Drawing.Size(257, 23);
            this.txt_target.TabIndex = 4;
            // 
            // btn_browse
            // 
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Location = new System.Drawing.Point(413, 92);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_startcopy
            // 
            this.btn_startcopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_startcopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startcopy.Location = new System.Drawing.Point(413, 137);
            this.btn_startcopy.Name = "btn_startcopy";
            this.btn_startcopy.Size = new System.Drawing.Size(75, 23);
            this.btn_startcopy.TabIndex = 6;
            this.btn_startcopy.Text = "Avvia";
            this.btn_startcopy.UseVisualStyleBackColor = true;
            this.btn_startcopy.Click += new System.EventHandler(this.btn_startcopy_Click);
            // 
            // FC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 172);
            this.Controls.Add(this.btn_startcopy);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fmcode);
            this.Controls.Add(this.lblFMCode);
            this.Controls.Add(this.btn_exit);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FC_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lblFMCode;
        private System.Windows.Forms.TextBox txt_fmcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.FolderBrowserDialog fbd_fmbrowsefile;
        private System.Windows.Forms.Button btn_startcopy;
    }
}

