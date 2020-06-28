namespace PRI_APP
{
    partial class frmAdministrateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cfiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réalisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbllogedinuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlfooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.Teal;
            this.pnlfooter.Controls.Add(this.lblfooter);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 567);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1145, 31);
            this.pnlfooter.TabIndex = 0;
            // 
            // lblfooter
            // 
            this.lblfooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.ForeColor = System.Drawing.Color.White;
            this.lblfooter.Location = new System.Drawing.Point(963, 4);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(152, 23);
            this.lblfooter.TabIndex = 0;
            this.lblfooter.Text = "Tracter votre récote";
            // 
            // menuStripTop
            // 
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.employerToolStripMenuItem,
            this.pieceToolStripMenuItem,
            this.cfiToolStripMenuItem,
            this.machineToolStripMenuItem,
            this.réalisationToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1145, 28);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // employerToolStripMenuItem
            // 
            this.employerToolStripMenuItem.Name = "employerToolStripMenuItem";
            this.employerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.employerToolStripMenuItem.Text = "Employer";
            this.employerToolStripMenuItem.Click += new System.EventHandler(this.employerToolStripMenuItem_Click);
            // 
            // pieceToolStripMenuItem
            // 
            this.pieceToolStripMenuItem.Name = "pieceToolStripMenuItem";
            this.pieceToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.pieceToolStripMenuItem.Text = "Piece";
            this.pieceToolStripMenuItem.Click += new System.EventHandler(this.pieceToolStripMenuItem_Click);
            // 
            // cfiToolStripMenuItem
            // 
            this.cfiToolStripMenuItem.Name = "cfiToolStripMenuItem";
            this.cfiToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.cfiToolStripMenuItem.Text = "Cfi";
            this.cfiToolStripMenuItem.Click += new System.EventHandler(this.cfiToolStripMenuItem_Click);
            // 
            // machineToolStripMenuItem
            // 
            this.machineToolStripMenuItem.Name = "machineToolStripMenuItem";
            this.machineToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.machineToolStripMenuItem.Text = "Machine";
            // 
            // réalisationToolStripMenuItem
            // 
            this.réalisationToolStripMenuItem.Name = "réalisationToolStripMenuItem";
            this.réalisationToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.réalisationToolStripMenuItem.Text = "Réalisation";
            this.réalisationToolStripMenuItem.Click += new System.EventHandler(this.réalisationToolStripMenuItem_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(6, 39);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(91, 23);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Utilisateur:";
            // 
            // lbllogedinuser
            // 
            this.lbllogedinuser.AutoSize = true;
            this.lbllogedinuser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogedinuser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbllogedinuser.Location = new System.Drawing.Point(98, 39);
            this.lbllogedinuser.Name = "lbllogedinuser";
            this.lbllogedinuser.Size = new System.Drawing.Size(64, 23);
            this.lbllogedinuser.TabIndex = 3;
            this.lbllogedinuser.Text = "ETRAG";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "RELEVE DE PRODUCTION ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "INDIVIDUELLE";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(661, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calcule et Rapport";
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllogedinuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmAdministrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlfooter.ResumeLayout(false);
            this.pnlfooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cfiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réalisationToolStripMenuItem;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbllogedinuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

