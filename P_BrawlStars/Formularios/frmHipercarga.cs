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
    public partial class frmHipercarga : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmHipercarga()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDaño.Clear();
            txtEscudo.Clear();
            txtSuper.Clear();
            txtVelocidad.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Hipercarga").ToString();
            txtId.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Hipercarga where id ={id}";
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
            private void frmHipercarga_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Hipercarga").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases. Hipercarga x = new Clases.Hipercarga();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Daño = txtDaño.Text;
            x.Escudo = txtEscudo.Text;
            x.Velocidad = txtVelocidad.Text;
            x.H_Super = txtSuper.Text;
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
            Busquedas.frmBusquedaHipercarga x = new Busquedas.frmBusquedaHipercarga();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgHipercarga.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgHipercarga.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtSuper.Text = x.dgHipercarga.SelectedRows[0].Cells["H_Super"].Value.ToString();
                txtEscudo.Text = x.dgHipercarga.SelectedRows[0].Cells["Escudo"].Value.ToString();
                txtDaño.Text = x.dgHipercarga.SelectedRows[0].Cells["Daño"].Value.ToString();
                txtVelocidad.Text = x.dgHipercarga.SelectedRows[0].Cells["Velocidad"].Value.ToString();
            }
        }
        void obtener()
        {
            string consulta = $"select * from Hipercarga where id = {txtId.Text}";

            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtId.Text = reader["id"].ToString();
                txtDaño.Text = reader["Daño"].ToString();
                txtVelocidad.Text = reader["Velocidad"].ToString();
                txtSuper.Text = reader["H_Super"].ToString();
                txtEscudo.Text = reader["Escudo"].ToString();
            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ninguna Hipercarga");
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
            Hipercarga x = new Hipercarga();
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
