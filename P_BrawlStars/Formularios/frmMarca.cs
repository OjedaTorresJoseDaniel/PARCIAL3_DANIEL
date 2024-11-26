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
    public partial class frmMarca : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmMarca()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {
            txtId.Clear();
            txtNumDeMarca.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Marca").ToString();
            txtId.Focus();
            cargarcb();
        }
       void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Copa";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbNumDeCopas.DisplayMember = "Cantidad";
            cbNumDeCopas.ValueMember = "id";
            cbNumDeCopas.DataSource = dt;

        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Marca where id ={id}";
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
        private void frmMarca_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Marca").ToString();
            cargarcb();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Marca x = new Clases.Marca();
            x.id = int.Parse(txtId.Text);
            x.NumeroDeMarca = txtNumDeMarca.Text;
            x.idCopa = int.Parse(cbNumDeCopas.SelectedValue.ToString());
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
            Busquedas.frmBusquedaMarca x = new Busquedas.frmBusquedaMarca();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgMarca.SelectedRows[0].Cells["id"].Value.ToString();
                txtNumDeMarca.Text = x.dgMarca.SelectedRows[0].Cells["NumeroDeMarca"].Value.ToString();
                cbNumDeCopas.SelectedValue = x.dgMarca.SelectedRows[0].Cells["idCopa"].Value;
            }
        }
        void obtener()
        {
            string consulta = $"select * from Marca where id = {txtId.Text}";

            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNumDeMarca.Text = reader["NumeroDeMarca"].ToString();
                txtId.Text = reader["id"].ToString();
                cbNumDeCopas.SelectedValue = int.Parse(reader["idCopa"].ToString());
            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ninguna Marca");
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
            Marca x = new Marca();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
