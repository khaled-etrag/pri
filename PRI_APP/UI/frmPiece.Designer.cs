namespace PRI_APP.UI
{
    partial class frmPiece
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
            this.lblReferance = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblOpperation = new System.Windows.Forms.Label();
            this.lblTempsOpperation = new System.Windows.Forms.Label();
            this.txtreferance = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txttempop = new System.Windows.Forms.TextBox();
            this.cbxnum = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCherche = new System.Windows.Forms.TextBox();
            this.lblCherche = new System.Windows.Forms.Label();
            this.brnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pieces";
            // 
            // lblReferance
            // 
            this.lblReferance.AutoSize = true;
            this.lblReferance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferance.Location = new System.Drawing.Point(35, 128);
            this.lblReferance.Name = "lblReferance";
            this.lblReferance.Size = new System.Drawing.Size(85, 23);
            this.lblReferance.TabIndex = 1;
            this.lblReferance.Text = "Referance";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(35, 169);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(101, 23);
            this.lblDesignation.TabIndex = 2;
            this.lblDesignation.Text = "Designation";
            // 
            // lblOpperation
            // 
            this.lblOpperation.AutoSize = true;
            this.lblOpperation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpperation.Location = new System.Drawing.Point(35, 218);
            this.lblOpperation.Name = "lblOpperation";
            this.lblOpperation.Size = new System.Drawing.Size(130, 23);
            this.lblOpperation.TabIndex = 3;
            this.lblOpperation.Text = "Num Operation";
            // 
            // lblTempsOpperation
            // 
            this.lblTempsOpperation.AutoSize = true;
            this.lblTempsOpperation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsOpperation.Location = new System.Drawing.Point(35, 267);
            this.lblTempsOpperation.Name = "lblTempsOpperation";
            this.lblTempsOpperation.Size = new System.Drawing.Size(139, 23);
            this.lblTempsOpperation.TabIndex = 4;
            this.lblTempsOpperation.Text = "Temps operation";
            // 
            // txtreferance
            // 
            this.txtreferance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferance.Location = new System.Drawing.Point(183, 122);
            this.txtreferance.Name = "txtreferance";
            this.txtreferance.Size = new System.Drawing.Size(191, 30);
            this.txtreferance.TabIndex = 7;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignation.Location = new System.Drawing.Point(183, 165);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(191, 30);
            this.txtdesignation.TabIndex = 8;
            // 
            // txttempop
            // 
            this.txttempop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttempop.Location = new System.Drawing.Point(183, 261);
            this.txttempop.Name = "txttempop";
            this.txttempop.Size = new System.Drawing.Size(191, 30);
            this.txttempop.TabIndex = 9;
            // 
            // cbxnum
            // 
            this.cbxnum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxnum.FormattingEnabled = true;
            this.cbxnum.Location = new System.Drawing.Point(183, 209);
            this.cbxnum.Name = "cbxnum";
            this.cbxnum.Size = new System.Drawing.Size(191, 31);
            this.cbxnum.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 222);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            this.btnSuprimer.Location = new System.Drawing.Point(718, 378);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(221, 45);
            this.btnSuprimer.TabIndex = 18;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = false;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(183, 314);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 30);
            this.txtId.TabIndex = 19;
            // 
            // frmPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(951, 444);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.brnAjouter);
            this.Controls.Add(this.txtCherche);
            this.Controls.Add(this.lblCherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxnum);
            this.Controls.Add(this.txttempop);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtreferance);
            this.Controls.Add(this.lblTempsOpperation);
            this.Controls.Add(this.lblOpperation);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblReferance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPiece_Load);
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
        private System.Windows.Forms.Label lblReferance;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblOpperation;
        private System.Windows.Forms.Label lblTempsOpperation;
        private System.Windows.Forms.TextBox txtreferance;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.TextBox txttempop;
        private System.Windows.Forms.ComboBox cbxnum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCherche;
        private System.Windows.Forms.Label lblCherche;
        private System.Windows.Forms.Button brnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.TextBox txtId;
    }
}