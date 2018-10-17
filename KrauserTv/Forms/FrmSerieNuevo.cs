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
    public partial class FrmSerieNuevo : Form
    {
        public FrmSerieNuevo()
        {
            InitializeComponent();
        }

        private void BtnLoadPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {


                pictureBox1.ImageLocation = dlg.FileName;

                TxtPoster.Text = dlg.FileName;
            }

            dlg.Dispose();
        }

        private void FrmSerieNuevo_Load(object sender, EventArgs e)
        {
            for (int i=1920; i <= 2020; i++){
                CmbAnio.Items.Add(i);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Series n = new Series();
          int resp=  n.guardar(TxtNombre.Text, Convert.ToInt32(CmbAnio.SelectedItem.ToString() ), TxtDescripcion.Text, TxtPoster.Text);
          if (resp == 1)
          {
              MessageBox.Show("Se ha guardado la serie con exito", "Guardado con exito",MessageBoxButtons.OK ,  MessageBoxIcon.Information);
              this.Close();
          } else {
              MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
    }
}
