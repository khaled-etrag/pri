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
    public partial class frmCfi : Form
    {
        public frmCfi()
        {
            InitializeComponent();
        }
         cfiBLL u = new cfiBLL();
        cfiDAL Dal = new cfiDAL();

        private void brnAjouter_Click(object sender, EventArgs e)
        {
            u.Cfi = txtCfi.Text;
            u.Description = txtDescription.Text;
            u.CfiRatach = txtRatachement.Text;
           

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
       
        private void clear()
        {
            txtCfi.Text = "";
            txtDescription.Text = "";
            txtRatachement.Text = "";
      
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCfi.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtRatachement.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtid.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            u.Cfi = txtCfi.Text;
            u.Description = txtDescription.Text;
            u.CfiRatach = txtRatachement.Text;
            u.Id = txtid.Text;
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
            u.Id = txtid.Text;
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

        private void btnSuprimer_Click_1(object sender, EventArgs e)
        {
            u.Id = txtid.Text;
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
            if (txtCherche != null)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCfi.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtRatachement.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtid.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void frmCfi_Load(object sender, EventArgs e)
        {
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}
