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

namespace P_BrawlStars.Formularios
{
    public partial class frmAtaque : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmAtaque()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtDaño.Clear();
            txtA_Alcance.Clear();
            txtVelocidadDeRecarga.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Ataque").ToString();
            txtId.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Ataque where id ={id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            con.Close();
            return a;
        }
        private void frmAtaque_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Ataque").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Ataque x = new Clases.Ataque();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Descripcion = txtDescripcion.Text;
            x.Daño = txtDaño.Text;
            x.A_Alcance = txtA_Alcance.Text;
            x.VelocidadDeRecarga = txtVelocidadDeRecarga.Text;
            if (encontro() == true)
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                MessageBox.Show(x.guardar());
            }
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.frmBusquedaAtaque x = new Busquedas.frmBusquedaAtaque();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgAtaque.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgAtaque.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDaño.Text = x.dgAtaque.SelectedRows[0].Cells["Daño"].Value.ToString();
                txtDescripcion.Text = x.dgAtaque.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                txtA_Alcance.Text = x.dgAtaque.SelectedRows[0].Cells["A_Alcance"].Value.ToString();
                txtVelocidadDeRecarga.Text = x.dgAtaque.SelectedRows[0].Cells["VelocidadDeRecarga"].Value.ToString();
            }
        }
        void obtener()
        {
            string consulta = $"select * from Ataque where id = {txtId.Text}";

            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtId.Text = reader["id"].ToString();
                txtDescripcion.Text = reader["Descripcion"].ToString();
                txtDaño.Text = reader["Daño"].ToString();
                txtA_Alcance.Text = reader["A_Alcance"].ToString();
                txtVelocidadDeRecarga.Text = reader["VelocidadDeRecarga"].ToString();
            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ningun Ataque");
            }
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "0" || txtId.Text == "")
            {
                MessageBox.Show("ID no valido");
            }
            else
            {
                obtener();
            }
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Ataque x = new Ataque();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
