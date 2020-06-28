namespace PRI_APP.UI
{
    partial class frmPrc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPRC = new System.Windows.Forms.Label();
            this.cbxCfi = new System.Windows.Forms.ComboBox();
            this.cbxMatricule = new System.Windows.Forms.ComboBox();
            this.lblCfi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblPRC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblPRC
            // 
            this.lblPRC.AutoSize = true;
            this.lblPRC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRC.Location = new System.Drawing.Point(12, 9);
            this.lblPRC.Name = "lblPRC";
            this.lblPRC.Size = new System.Drawing.Size(94, 23);
            this.lblPRC.TabIndex = 0;
            this.lblPRC.Text = "FICHE PRC";
            // 
            // cbxCfi
            // 
            this.cbxCfi.FormattingEnabled = true;
            this.cbxCfi.Location = new System.Drawing.Point(86, 72);
            this.cbxCfi.Name = "cbxCfi";
            this.cbxCfi.Size = new System.Drawing.Size(143, 24);
            this.cbxCfi.TabIndex = 1;
            this.cbxCfi.SelectedIndexChanged += new System.EventHandler(this.cbxCfi_SelectedIndexChanged);
            // 
            // cbxMatricule
            // 
            this.cbxMatricule.FormattingEnabled = true;
            this.cbxMatricule.Location = new System.Drawing.Point(86, 121);
            this.cbxMatricule.Name = "cbxMatricule";
            this.cbxMatricule.Size = new System.Drawing.Size(143, 24);
            this.cbxMatricule.TabIndex = 2;
            // 
            // lblCfi
            // 
            this.lblCfi.AutoSize = true;
            this.lblCfi.Location = new System.Drawing.Point(13, 79);
            this.lblCfi.Name = "lblCfi";
            this.lblCfi.Size = new System.Drawing.Size(24, 17);
            this.lblCfi.TabIndex = 3;
            this.lblCfi.Text = "Cfi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRI_APP.Properties.Resources.delete_sign_64px;
            this.pictureBox1.Location = new System.Drawing.Point(880, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCfi);
            this.Controls.Add(this.cbxMatricule);
            this.Controls.Add(this.cbxCfi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrc";
            this.Load += new System.EventHandler(this.frmPrc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPRC;
        private System.Windows.Forms.ComboBox cbxCfi;
        private System.Windows.Forms.ComboBox cbxMatricule;
        private System.Windows.Forms.Label lblCfi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}