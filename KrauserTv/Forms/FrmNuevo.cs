using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrauserTv.Forms
{
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void BtnNewSerie_Click(object sender, EventArgs e)
        {
            FrmSerieNuevo n = new FrmSerieNuevo();
            n.MdiParent = this.MdiParent;
            n.Show();
            this.Close();
        }

        private void BtnNewCapitulo_Click(object sender, EventArgs e)
        {
            FrmCapituloNuevo n = new FrmCapituloNuevo();
            n.MdiParent = this.MdiParent;
            n.Show();
            this.Close();
        }

        private void BtnNewServidor_Click(object sender, EventArgs e)
        {
            FrmServidorNuevo n = new FrmServidorNuevo();
            n.MdiParent = this.MdiParent;
            n.Show();
            this.Close();
        }

        private void BtnNewUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario n = new FrmUsuario();
            n.MdiParent = this.MdiParent;
            n.Show();
            this.Close();
        }
    }
}
