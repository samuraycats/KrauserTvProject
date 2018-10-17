using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrauserTv.Models;
namespace KrauserTv
{
    public partial class FrmServidorNuevo : Form
    {
        public FrmServidorNuevo()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Servidores n = new Servidores ();
            int resp = n.Guardar(TxtNombre.Text,Convert.ToBoolean(CmbStatus.SelectedIndex ) );
            if (resp == 1)
            {
                MessageBox.Show("Se ha guardado el servidor con exito", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
