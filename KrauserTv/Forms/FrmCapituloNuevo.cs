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


namespace KrauserTv.Forms
{
    public partial class FrmCapituloNuevo : Form
    {
        public FrmCapituloNuevo()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCapituloNuevo_Load(object sender, EventArgs e)
        {
            // Listar capitulos
            Capitulos n = new Capitulos();
            Series n2 = new Series();
            IEnumerable<Series> datos = n2.Listar();

            CmbSerie.DataSource  = datos ;
            CmbSerie.DisplayMember = "nombre";
            CmbSerie.ValueMember = "idserie";

            // Listar temporadas
            Temporadas nt = new Temporadas();
            IEnumerable<Temporadas> datos2 = nt.ListarTemporadas();
            CmbTemporada.DataSource = datos2;
            CmbTemporada.DisplayMember = "descripcion";
            CmbTemporada.ValueMember = "idtemporada";

         
            
        }

        private void BtnLoadPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {


                pictureBox1.ImageLocation = dlg.FileName;

                TxtMiniatura.Text = dlg.FileName;
            }

            dlg.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Capitulos n = new Capitulos();
            n.idserie = Convert.ToInt32( CmbSerie.SelectedValue);
            n.idtemporada = Convert.ToInt32(CmbTemporada.SelectedValue);
            n.miniatura = TxtMiniatura.Text;
            n.consecutivo = Convert.ToInt32( TxtNumero.Text);
            n.titulo = TxtTitulo.Text;
            n.status = Convert.ToBoolean(CmbStatus.SelectedIndex );
           bool resp = n.GuardarCapitulo();
           if (resp)
           {
               MessageBox.Show("Se ha guardado el capitulo con exito", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               TxtMiniatura.Clear();
               TxtNumero.Text = Convert.ToString( n.consecutivo + 1);
               TxtTitulo.Clear();

               LoadGrid();
   
           }
           else
           {
               MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void CmbTemporada_SelectedIndexChanged(object sender, EventArgs e){
            LoadGrid();
        }
        private void LoadGrid() {
            Temporadas TMP = ((Temporadas)CmbTemporada.SelectedItem);

            Capitulos cap = new Capitulos();
            cap.idserie = Convert.ToInt32(CmbSerie.SelectedValue);
            cap.idtemporada = TMP.idtemporada;

            IEnumerable<Capitulos> datos = cap.GetCapitulos();

            DtaCapitulos.AutoGenerateColumns = false;
            DtaCapitulos.DataSource = datos;
            DtaCapitulos.Refresh();  
        }

        private void TxtMiniatura_TextChanged(object sender, EventArgs e)
        {
            try {
                pictureBox1.ImageLocation = TxtMiniatura.Text;
                TxtMiniatura.Text = TxtMiniatura.Text;
            }
            catch { 
            }
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TxtTitulo.Paste();
        }

    }


}
