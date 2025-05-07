using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySalvarezzaConexionBDD
{
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock mostrar = new frmStock();
            mostrar.ShowDialog();
        }

        private void cargaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarga mostrar = new frmCarga();
            mostrar.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos mostrar = new frmContactos();
            mostrar.ShowDialog();
        }
    }
}
