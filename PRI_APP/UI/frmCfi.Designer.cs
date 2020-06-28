namespace PRI_APP.UI
{
    partial class frmCfi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCfi = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCfiRatachement = new System.Windows.Forms.Label();
            this.txtCfi = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCherche = new System.Windows.Forms.TextBox();
            this.lblCherche = new System.Windows.Forms.Label();
            this.brnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.txtRatachement = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRI_APP.Properties.Resources.delete_sign_64px;
            this.pictureBox1.Location = new System.Drawing.Point(912, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilisateur";
            // 
            // lblCfi
            // 
            this.lblCfi.AutoSize = true;
            this.lblCfi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfi.Location = new System.Drawing.Point(31, 128);
            this.lblCfi.Name = "lblCfi";
            this.lblCfi.Size = new System.Drawing.Size(30, 23);
            this.lblCfi.TabIndex = 1;
            this.lblCfi.Text = "Cfi";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(31, 169);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 23);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCfiRatachement
            // 
            this.lblCfiRatachement.AutoSize = true;
            this.lblCfiRatachement.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfiRatachement.Location = new System.Drawing.Point(31, 218);
            this.lblCfiRatachement.Name = "lblCfiRatachement";
            this.lblCfiRatachement.Size = new System.Drawing.Size(136, 23);
            this.lblCfiRatachement.TabIndex = 3;
            this.lblCfiRatachement.Text = "Cfi Ratachement";
            // 
            // txtCfi
            // 
            this.txtCfi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCfi.Location = new System.Drawing.Point(173, 122);
            this.txtCfi.Name = "txtCfi";
            this.txtCfi.Size = new System.Drawing.Size(197, 30);
            this.txtCfi.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(173, 165);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(197, 30);
            this.txtDescription.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 219);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // txtCherche
            // 
            this.txtCherche.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCherche.Location = new System.Drawing.Point(499, 74);
            this.txtCherche.Name = "txtCherche";
            this.txtCherche.Size = new System.Drawing.Size(440, 30);
            this.txtCherche.TabIndex = 15;
            // 
            // lblCherche
            // 
            this.lblCherche.AutoSize = true;
            this.lblCherche.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCherche.Location = new System.Drawing.Point(414, 80);
            this.lblCherche.Name = "lblCherche";
            this.lblCherche.Size = new System.Drawing.Size(79, 23);
            this.lblCherche.TabIndex = 14;
            this.lblCherche.Text = "Chercher";
            // 
            // brnAjouter
            // 
            this.brnAjouter.BackColor = System.Drawing.Color.ForestGreen;
            this.brnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAjouter.Location = new System.Drawing.Point(131, 378);
            this.brnAjouter.Name = "brnAjouter";
            this.brnAjouter.Size = new System.Drawing.Size(221, 45);
            this.brnAjouter.TabIndex = 16;
            this.brnAjouter.Text = "Ajouter";
            this.brnAjouter.UseVisualStyleBackColor = false;
            this.brnAjouter.Click += new System.EventHandler(this.brnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Chartreuse;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(414, 378);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(221, 45);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuprimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimer.ForeColor = System.Drawing.Color.White;
            this.btnSuprimer.Location = new System.Drawing.Point(718, 379);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(221, 45);
            this.btnSuprimer.TabIndex = 18;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = false;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click_1);
            // 
            // txtRatachement
            // 
            this.txtRatachement.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatachement.Location = new System.Drawing.Point(173, 211);
            this.txtRatachement.Name = "txtRatachement";
            this.txtRatachement.Size = new System.Drawing.Size(197, 30);
            this.txtRatachement.TabIndex = 19;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(173, 263);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(197, 30);
            this.txtid.TabIndex = 20;
            // 
            // frmCfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(951, 444);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtRatachement);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.brnAjouter);
            this.Controls.Add(this.txtCherche);
            this.Controls.Add(this.lblCherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCfi);
            this.Controls.Add(this.lblCfiRatachement);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCfi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCfi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCfi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCfi;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCfiRatachement;
        private System.Windows.Forms.TextBox txtCfi;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCherche;
        private System.Windows.Forms.Label lblCherche;
        private System.Windows.Forms.Button brnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.TextBox txtRatachement;
        private System.Windows.Forms.TextBox txtid;
    }
}