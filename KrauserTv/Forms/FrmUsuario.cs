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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            try {
                TiposCuentas n = new TiposCuentas();
                CmbTipoCuenta.DataSource = n.Listar();
                CmbTipoCuenta.ValueMember = "idtipocuenta";
                CmbTipoCuenta.DisplayMember = "descripcion";
            }
            catch { 
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == TxtPassword2.Text )
            {
                if (TxtUsuario.Text != "" || TxtPassword.Text != "" || TxtPassword2.Text != "")
                {
                    Usuarios n = new Usuarios(TxtUsuario.Text, TxtPassword.Text, TxtNombre.Text, TxtEmail.Text, "11", Convert.ToInt32(CmbTipoCuenta.SelectedValue));
                    Boolean resp = n.Guardar();

                    if (resp)
                    {
                        MessageBox.Show("Se ha guardado el usuario con exito", "Guardado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtEmail.Clear();
                        TxtNombre.Clear();
                        TxtPassword.Clear();
                        TxtPassword2.Clear();
                        TxtUsuario.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


    }
}
