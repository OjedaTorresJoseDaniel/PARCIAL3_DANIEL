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
    public partial class frmSuper : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmSuper()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {

            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtAlcanceSuper.Clear();
            txtDañoPorGolpe.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Super").ToString();
            txtId.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Super where id ={id}";
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
        private void frmSuper_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Super").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Super x = new Clases.Super();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Descripcion = txtDescripcion.Text;
            x.DañoPorGolpe = txtDañoPorGolpe.Text;
            x.S_Alcance = txtAlcanceSuper.Text;
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
            Busquedas.frmBusquedaSuper x = new Busquedas.frmBusquedaSuper();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgSuper.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgSuper.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = x.dgSuper.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                txtAlcanceSuper.Text = x.dgSuper.SelectedRows[0].Cells["S_Alcance"].Value.ToString();
                txtDañoPorGolpe.Text = x.dgSuper.SelectedRows[0].Cells["DañoPorGolpe"].Value.ToString();
            }
        }
        void obtener()
        {
            string consulta = $"select * from Super where id = {txtId.Text}";

            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtId.Text = reader["id"].ToString();
                txtDescripcion.Text = reader ["Descripcion"].ToString();
                txtAlcanceSuper.Text = reader["S_Alcance"].ToString();
                txtDañoPorGolpe.Text = reader["DañoPorGolpe"].ToString();
            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ningun Tipo");
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
            Super x = new Super();
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
