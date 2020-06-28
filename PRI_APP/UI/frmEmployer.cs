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
    public partial class frmEmployer : Form
    {
        public frmEmployer()
        {
            InitializeComponent();
        }
        employerBLL u = new employerBLL();
         employerDAL Dal = new employerDAL();

   

		
	
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnAjouter_Click(object sender, EventArgs e)
        {
          
            u.Nom = txtNom.Text;
            u.Prenom = txtPrenom.Text;
            u.Matricule = txtMatricule.Text;
            u.Cfi = cbxCfi.Text;
            u.Fonction = txtFonction.Text;
            u.Batiment = cbxBatiment.Text;
         
            bool success = Dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("is good ");
                clear();
            }
            else
            {
                MessageBox.Show("notgood");
            }
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void frmEmployer_Load(object sender, EventArgs e)
        {
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }
        private void clear()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            cbxCfi.Text = "";
            txtMatricule.Text = "";
            txtFonction.Text = "";
            cbxBatiment.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { int rowIndex = e.RowIndex;
            txtNom.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtPrenom.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cbxCfi.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtMatricule.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtFonction.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            cbxBatiment.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            txtMatricule.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            u.Matricule = txtMatricule.Text;
            u.Nom = txtNom.Text;
            u.Prenom = txtPrenom.Text;
            u.Cfi = cbxCfi.Text;
            u.Fonction = txtFonction.Text;
            u.Batiment = cbxBatiment.Text;
            bool success = Dal.Modifier(u);
            if (success == true)
            {
                MessageBox.Show(" update is good ");
                clear();
            }
            else
            {
                MessageBox.Show("update notgood");
            }
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            u.Matricule = txtMatricule.Text;
            bool success = Dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show(" update is good ");
                clear();
            }
            else
            {
                MessageBox.Show("update notgood");
            }
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;

        }

        private void txtCherche_TextChanged(object sender, EventArgs e)
        {
            string sherche = txtCherche.Text;
            if (txtCherche !=null)
            {
                DataTable dt = Dal.Cherche(sherche);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = Dal.Select();
                dataGridView1.DataSource = dt;

            }
        }
    }
}
