using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioPrimeUI
{
    public partial class frmPrime_MDI : Form
    {
        private int childFormNumber = 0;

        public frmPrime_MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUser = new frmUsuario();
            frmUser.MdiParent = this;
            if (frmUser.Visible)
                frmUser.Focus();
            else
                frmUser.Show();

        }
    }
}
