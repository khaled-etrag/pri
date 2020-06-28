using PRI_APP.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_APP
{
    public partial class frmAdministrateur : Form
    {
        public frmAdministrateur()
        {
            InitializeComponent();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployer EMP = new frmEmployer();
            EMP.Show();
        }

        private void pieceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPiece PIECE = new frmPiece();
            PIECE.Show();
        }

        private void cfiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCfi CFI = new frmCfi();
            CFI.Show();
        }

        private void réalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrc PRC = new frmPrc();
            PRC.Show();
        }
    }
}
