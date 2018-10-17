using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrauserTv.Models ;
using System.Data.SqlClient;


namespace KrauserTv.Forms
{
    public partial class FrmConexion : Form
    {
        public SqlConnectionStringBuilder mainBuilder;

        public FrmConexion()
        {
            InitializeComponent();
        }

        private void FrmConexion_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            mainBuilder = ObtenerInformacionDeConexion();

            using (SqlConnection CN = new SqlConnection(mainBuilder.ConnectionString))
            {
                try
                {
                    CN.Open();
                    label3.Text = "Conexión realizada\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible realizar la conexión con el servidor" + " " + ex.Message);
                }
            }

        }
        public SqlConnectionStringBuilder  ObtenerInformacionDeConexion()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "localhost";
            builder.InitialCatalog = "krausertv";
            builder.UserID = "root";
            builder.Password = "gato50410640";
            return builder;

        }



    }
}
