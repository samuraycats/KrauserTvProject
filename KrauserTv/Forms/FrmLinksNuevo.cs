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
    public partial class FrmLinksNuevo : Form
    {
        public FrmLinksNuevo()
        {
            InitializeComponent();
        }

        private void FrmLinksNuevo_Load(object sender, EventArgs e)
        {
            Series n = new Series();
            IEnumerable < Series > datos = n.Listar();

            CmbSerie.DataSource = datos;
            CmbSerie.DisplayMember = "nombre";
            CmbSerie.ValueMember = "idserie";

            Servidores lista = new Servidores();
            CmbServidor.DataSource = lista.Listar();
            CmbServidor.DisplayMember = "nombre";
            CmbServidor.ValueMember = "idservidor";

        }

        private void CmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void CmbSerie_SelectedValueChanged(object sender, EventArgs e)
        {
           
            
            Capitulos n = new Capitulos();
            string index = CmbSerie.ValueMember.ToString();
            if (index != "") {
                n.idserie = Convert.ToInt32( CmbSerie.SelectedValue );
                CmbTemporada.DataSource = n.ListarTemporadasFiltro();
                CmbTemporada.DisplayMember = "descripcion";
                CmbTemporada.ValueMember = "idtemporada";
            }

        }

        private void CmbTemporada_SelectedValueChanged(object sender, EventArgs e)
        {
            Capitulos n = new Capitulos();

            string index = CmbTemporada.ValueMember.ToString();
            if (index != "")
            {
                n.idtemporada = Convert.ToInt32(CmbTemporada.SelectedValue);
                n.idserie = Convert.ToInt32(CmbSerie.SelectedValue);

                CmbCapitulo.DataSource = n.ListarCapitulosFiltro();
                CmbCapitulo.DisplayMember = "consecutivo";
                CmbCapitulo.ValueMember = "idcapitulo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Links n = new Links();
            
            n.idcapitulo = Convert.ToInt32(CmbCapitulo.SelectedValue);
            n.idservidor = Convert.ToInt32(CmbServidor.SelectedValue);
            n.link = TxtLink.Text;
            n.status = Convert.ToBoolean(CmbStatus.SelectedIndex);
          bool resp=  n.GuardarLink();

          if (resp)
          {
              MessageBox.Show("Se ha guardado el link del capitulo con exito", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              TxtLink.Clear();


              LoadGrid();

          }
          else
          {
              MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        private void LoadGrid()
        {
            Links n = new Links();
            string index = CmbCapitulo.ValueMember.ToString();
            if (index != "") {
                n.idcapitulo = Convert.ToInt32(CmbCapitulo.SelectedValue);
                IEnumerable<Links> datos = n.ListarLinks();

                DtaDetalles.AutoGenerateColumns = false;
                DtaDetalles.DataSource = datos;
                DtaDetalles.Refresh();
            }


        }



        private void CmbCapitulo_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
