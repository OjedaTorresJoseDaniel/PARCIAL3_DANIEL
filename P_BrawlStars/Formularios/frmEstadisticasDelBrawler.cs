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
    public partial class frmEstadisticasDelBrawler : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmEstadisticasDelBrawler()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void limpiar()
        {
            txtId.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "EstadisticasDelBrawler").ToString();
            cargarcbFuerza();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from EstadisticasDelBrawler where id ={id}";
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
        // cargar COMBO BOXS

        void cargarcbFuerza()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Fuerza";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbFuerza.DisplayMember = "Nombre";
            cbFuerza.ValueMember = "id";
            cbFuerza.DataSource = dt;

        }

        private void frmEstadisticasDelBrawler_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "EstadisticasDelBrawler").ToString();
            cargarcbFuerza();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.EstadisticasDelBrawler x = new Clases.EstadisticasDelBrawler();
            x.id = int.Parse(txtId.Text);
            x.idFuerza = int.Parse(cbFuerza.SelectedValue.ToString());
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
            Busquedas.frmBusquedaEstadisticasDelBrawler x = new Busquedas.frmBusquedaEstadisticasDelBrawler();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgEstadisticasDelBrawler.SelectedRows[0].Cells["id"].Value.ToString();
                cbFuerza.SelectedValue = x.dgEstadisticasDelBrawler.SelectedRows[0].Cells["idFuerza"].Value;
            }
        }
        void obtener()
        {
            string consulta = $"select * from EstadisticasDelBrawler where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtId.Text = reader["id"].ToString();
                cbFuerza.SelectedValue = int.Parse(reader["idFuerza"].ToString());

            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ninguna Estadistica Del Brawler");
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
            EstadisticasDelBrawler x = new EstadisticasDelBrawler();
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
    

