using P_BrawlStars.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_BrawlStars.Busquedas
{
    public partial class frmBusquedaFuerza : Form
    {
        Clases.ConexionSQL x = new Clases.ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmBusquedaFuerza()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmBusquedaFuerza_Load(object sender, EventArgs e)
        {
            try
            {
                dgFuerza.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select * from Fuerza where Nivel LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgFuerza.DataSource = dt;
            con.Close();
            try
            {
                dgFuerza.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargardg();
        }

        private void dgFuerza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgFuerza.CurrentRow.Index;
            dgFuerza.Rows[i].Selected = true;
        }

        private void dgFuerza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgFuerza.CurrentRow.Index;
            dgFuerza.Rows[i].Selected = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
