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
    public partial class frmPiece : Form
    {

        public frmPiece()
        {
            InitializeComponent();
        }
        BLL.pieceBLL u = new BLL.pieceBLL();
       DAl.pieceDAL Dal =new DAl.pieceDAL();
        private void brnAjouter_Click(object sender, EventArgs e)
        {
            u.Referance = txtreferance.Text;
            u.Designation =txtdesignation.Text;
            u.Operation = Convert.ToInt16(cbxnum.Text);
            u.TempOp = Convert.ToDecimal(txttempop.Text);
           

            bool success = Dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("is good ");
               // clear();
            }
            else
            {
                MessageBox.Show("not good");
            }
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPiece_Load(object sender, EventArgs e)
        {
            DataTable dt = Dal.Select();
            dataGridView1.DataSource = dt;
        }
        private void clear()
        {
            txtreferance.Text = "";
            txtdesignation.Text = "";
            cbxnum.Text = "";
            txttempop.Text = "";
            txtId.Text = "";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            u.Referance = txtreferance.Text;
            u.Designation = txtdesignation.Text;
            u.Operation = Convert.ToInt16(cbxnum.Text);
            u.TempOp = Convert.ToDecimal(txttempop.Text);
            u.Id = Convert.ToInt16(txtId.Text);
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
            u.Id = Convert.ToInt16(txtId.Text);
           
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtreferance.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtdesignation.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cbxnum.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txttempop.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtId.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();


        }
    }
}
