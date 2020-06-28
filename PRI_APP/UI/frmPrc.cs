using PRI_APP.BLL;
using PRI_APP.DAl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_APP.UI
{
    public partial class frmPrc : Form
    {
        public frmPrc()
        {
            InitializeComponent();
        }
        cfiBLL u = new cfiBLL();
        cfiDAL Dal = new cfiDAL();
        employerBLL a = new employerBLL();
        employerDAL aze = new employerDAL();
        private void frmPrc_Load(object sender, EventArgs e)
        {
            
          
           
            DataTable dt = new DataTable();
            dt = Dal.SelectCfi();
            cbxCfi.DataSource = dt;
            cbxMatricule.DataSource = dt;
            cbxCfi.DisplayMember = "Cfi";
           // cbxMatricule.DisplayMember = "Designation";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCfi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cfi = cbxCfi.Text;
            if (cbxCfi.Text != null)
            {
                DataTable dt = aze.ChercheMatricuel(cbxCfi.Text);
                cbxMatricule.DataSource = dt;
                cbxMatricule.DisplayMember = "Matricule";
            }
            else
            {
                DataTable dt = aze.ChercheMatricuel(cbxCfi.Text);
                cbxMatricule.DataSource = null;
                cbxMatricule.DataSource = dt;
                cbxMatricule.DisplayMember = "Matricule";
            }
            
        }
    }
}
