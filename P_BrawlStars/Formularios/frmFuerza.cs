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
    public partial class frmFuerza : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmFuerza()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Fuerza").ToString();
            txtNombre.Focus();
            cargarcbSalud();
            cargarcbAtaque();
            cargarcbSuper();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Fuerza where id ={id}";
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

        void cargarcbSalud()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Salud";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbSalud.DisplayMember = "Nombre";
            cbSalud.ValueMember = "id";
            cbSalud.DataSource = dt;

        }
        void cargarcbAtaque()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Ataque";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbAtaque.DisplayMember = "Nombre";
            cbAtaque.ValueMember = "id";
            cbAtaque.DataSource = dt;

        }
        void cargarcbSuper()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Super";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbSuper.DisplayMember = "Nombre";
            cbSuper.ValueMember = "id";
            cbSuper.DataSource = dt;
        }

        private void frmFuerza_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Fuerza").ToString();
            cargarcbSalud();
            cargarcbAtaque();
            cargarcbSuper();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Fuerza x = new Clases.Fuerza();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.idSalud = int.Parse(cbSalud.SelectedValue.ToString());
            x.idAtaque = int.Parse(cbAtaque.SelectedValue.ToString());
            x.idSuper = int.Parse(cbSuper.SelectedValue.ToString());
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
            Busquedas.frmBusquedaFuerza x = new Busquedas.frmBusquedaFuerza();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgFuerza.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgFuerza.SelectedRows[0].Cells["Nivel"].Value.ToString();
                cbSalud.SelectedValue = x.dgFuerza.SelectedRows[0].Cells["idSalud"].Value;
                cbAtaque.SelectedValue = x.dgFuerza.SelectedRows[0].Cells["idAtaque"].Value;
                cbSuper.SelectedValue = x.dgFuerza.SelectedRows[0].Cells["idSuper"].Value;
            }
        }
        void obtener()
        {
            string consulta = $"select * from Fuerza where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtId.Text = reader["id"].ToString();
                txtNombre.Text = reader["Nivel"].ToString();
                cbSalud.SelectedValue = int.Parse(reader["idSalud"].ToString());
                cbAtaque.SelectedValue = int.Parse(reader["idAtaque"].ToString());
                cbSuper.SelectedValue = int.Parse(reader["idSuper"].ToString());

            }
            else
            {
                MessageBox.Show("El Id ingresado no le corresponde a ninguna Fuerza");
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
            Fuerza x = new Fuerza();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            INFORMES.frmRFuerza f = new INFORMES.frmRFuerza();
            f.ShowDialog();
        }
    }
}
