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
    public partial class frmBrawler : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmBrawler()
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
            cargarcbCalidad();
            cargarcbTipo();
            cargarcbMarca();
            cargarcbRefuerzo1();
            cargarcbRefuerzo2();
            cargarcbRefuerzo3();
            cargarcbRefuerzo4();
            cargarcbRefuerzo5();
            cargarcbRefuerzo6();
            cargarcbRefuerzo7();
            cargarcbGadget1();
            cargarcbGadget2();
            cargarcbEstelar1();
            cargarcbEstelar2();
            cargarcbHipercarga();
            cargarcbEstadisticasDelBrawler();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Brawler where id ={id}";
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

        void cargarcbCalidad()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Calidad ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCalidad.DisplayMember = "Nombre";
            cbCalidad.ValueMember = "id";
            cbCalidad.DataSource = dt;

        }
        void cargarcbTipo()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Tipo";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbTipo.DisplayMember = "Nombre";
            cbTipo.ValueMember = "id";
            cbTipo.DataSource = dt;

        }
        void cargarcbMarca()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Marca ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbMarca.ValueMember = "id";
            cbMarca.DataSource = dt;

        }
        void cargarcbRefuerzo1()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo1 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo1.DisplayMember = "Nombre";
            cbRefuerzo1.ValueMember = "id";
            cbRefuerzo1.DataSource = dt;

        }
        void cargarcbRefuerzo2()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo2 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo2.DisplayMember = "Nombre";
            cbRefuerzo2.ValueMember = "id";
            cbRefuerzo2.DataSource = dt;

        }
        void cargarcbRefuerzo3()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo3 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo3.DisplayMember = "Nombre";
            cbRefuerzo3.ValueMember = "id";
            cbRefuerzo3.DataSource = dt;

        }
        void cargarcbRefuerzo4()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo4 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo4.DisplayMember = "Nombre";
            cbRefuerzo4.ValueMember = "id";
            cbRefuerzo4.DataSource = dt;

        }
        void cargarcbRefuerzo5()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo5 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo5.DisplayMember = "Nombre";
            cbRefuerzo5.ValueMember = "id";
            cbRefuerzo5.DataSource = dt;

        }
        void cargarcbRefuerzo6()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo6 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo6.DisplayMember = "Nombre";
            cbRefuerzo6.ValueMember = "id";
            cbRefuerzo6.DataSource = dt;

        }
        void cargarcbRefuerzo7()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Refuerzo7 ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbRefuerzo7.DisplayMember = "Nombre";
            cbRefuerzo7.ValueMember = "id";
            cbRefuerzo7.DataSource = dt;

        }
        void cargarcbGadget1()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Primer_Gadget ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbGadget1.DisplayMember = "Nombre";
            cbGadget1.ValueMember = "id";
            cbGadget1.DataSource = dt;

        }
        void cargarcbGadget2()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Segundo_Gadget ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbGadget2.DisplayMember = "Nombre";
            cbGadget2.ValueMember = "id";
            cbGadget2.DataSource = dt;

        }
        void cargarcbEstelar1()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Primer_Estelar";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbPrimerEstelar.DisplayMember = "Nombre";
            cbPrimerEstelar.ValueMember = "id";
            cbPrimerEstelar.DataSource = dt;

        }
        void cargarcbEstelar2()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Segunda_Estelar ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbSegundaEstelar.DisplayMember = "Nombre";
            cbSegundaEstelar.ValueMember = "id";
            cbSegundaEstelar.DataSource = dt;

        }
        void cargarcbHipercarga()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Hipercarga ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbHipercarga.DisplayMember = "Nombre";
            cbHipercarga.ValueMember = "id";
            cbHipercarga.DataSource = dt;

        }
        void cargarcbEstadisticasDelBrawler()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEstadisticasDelBrawler.ValueMember = "id";
            cbEstadisticasDelBrawler.DataSource = dt;

        }
        private void frmBrawler_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Fuerza").ToString();
            cargarcbCalidad();
            cargarcbTipo();
            cargarcbMarca();
            cargarcbRefuerzo1();
            cargarcbRefuerzo2();
            cargarcbRefuerzo3();
            cargarcbRefuerzo4();
            cargarcbRefuerzo5();
            cargarcbRefuerzo6();
            cargarcbRefuerzo7();
            cargarcbGadget1();
            cargarcbGadget2();
            cargarcbEstelar1();
            cargarcbEstelar2();
            cargarcbHipercarga();
            cargarcbEstadisticasDelBrawler();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Brawler x = new Clases.Brawler();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Descripcion = txtDescripcion.Text;
            x.idCalidad = int.Parse(cbCalidad.SelectedValue.ToString());
            x.idTipo = int.Parse(cbTipo.SelectedValue.ToString());
            x.idMarca = int.Parse(cbMarca.SelectedValue.ToString());
            x.idRefuerzo1 = int.Parse(cbRefuerzo1.SelectedValue.ToString());
            x.idRefuerzo2 = int.Parse(cbRefuerzo2.SelectedValue.ToString());
            x.idRefuerzo3 = int.Parse(cbRefuerzo3.SelectedValue.ToString());
            x.idRefuerzo4 = int.Parse(cbRefuerzo4.SelectedValue.ToString());
            x.idRefuerzo5 = int.Parse(cbRefuerzo5.SelectedValue.ToString());
            x.idRefuerzo6 = int.Parse(cbRefuerzo6.SelectedValue.ToString());
            x.idRefuerzo7 = int.Parse(cbRefuerzo7.SelectedValue.ToString());
            x.idGadget_Uno = int.Parse(cbGadget1.SelectedValue.ToString());
            x.idGadget_Dos = int.Parse(cbGadget2.SelectedValue.ToString());
            x.idPrimer_Estelar = int.Parse(cbPrimerEstelar.SelectedValue.ToString());
            x.idSegunda_Estelar = int.Parse(cbSegundaEstelar.SelectedValue.ToString());
            x.idHipercarga = int.Parse(cbHipercarga.SelectedValue.ToString());
            x.idEstadisticasDelBrawler = int.Parse(cbEstadisticasDelBrawler.SelectedValue.ToString());

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
            Busquedas.frmBusquedaBrawler x = new Busquedas.frmBusquedaBrawler();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgBrawlers.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgBrawlers.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = x.dgBrawlers.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                cbCalidad.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idCalidad"].Value;
                cbTipo.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idTipo"].Value;
                cbMarca.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idMarca"].Value;
                cbRefuerzo1.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo1"].Value;
                cbRefuerzo2.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo2"].Value;
                cbRefuerzo3.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo3"].Value;
                cbRefuerzo4.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo4"].Value;
                cbRefuerzo5.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo5"].Value;
                cbRefuerzo6.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo6"].Value;
                cbRefuerzo7.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo7"].Value;
                cbGadget1.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idGadget_Uno"].Value;
                cbGadget2.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idGadget_Dos"].Value;
                cbPrimerEstelar.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idPrimer_Estelar"].Value;
                cbSegundaEstelar.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idSegunda_Estelar"].Value;
                cbHipercarga.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idHipercarga"].Value;
                cbEstadisticasDelBrawler.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idEstadisticasDelBrawler"].Value;

            }
            
        }
        void obtener()
        {
            string consulta = $"select * from Brawler where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtId.Text = reader["id"].ToString();
                txtNombre.Text = reader["Nombre"].ToString();
                txtDescripcion.Text = reader["Descripcion"].ToString();
                cbCalidad.SelectedValue = int.Parse(reader["idCalidad"].ToString());
                cbTipo.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idTipo"].Value;
                cbMarca.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idMarca"].Value;
                cbRefuerzo1.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo1"].Value;
                cbRefuerzo2.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo2"].Value;
                cbRefuerzo3.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo3"].Value;
                cbRefuerzo4.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo4"].Value;
                cbRefuerzo5.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo5"].Value;
                cbRefuerzo6.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo6"].Value;
                cbRefuerzo7.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idRefuerzo7"].Value;
                cbGadget1.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idGadget_Uno"].Value;
                cbGadget2.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idGadget_Dos"].Value;
                cbPrimerEstelar.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idPrimer_Estelar"].Value;
                cbSegundaEstelar.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idSegunda_Estelar"].Value;
                cbHipercarga.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idHipercarga"].Value;
                cbEstadisticasDelBrawler.SelectedValue = x.dgBrawlers.SelectedRows[0].Cells["idEstadisticasDelBrawler"].Value;
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
    }
}
