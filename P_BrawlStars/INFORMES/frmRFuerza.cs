using Microsoft.Reporting.WinForms;
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

namespace P_BrawlStars.INFORMES
{
    public partial class frmRFuerza : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmRFuerza()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmRFuerza_Load(object sender, EventArgs e)
        {
            cargarcb();
            //this.rvFuerza.RefreshReport();
        }
        void cargarcb()
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
        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vFuerza";
                chTodo.Checked = false;
            }
            else
            {
                consulta = $"select * from vFuerza where idSalud = {cbSalud.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvFuerza.LocalReport.DataSources.Clear();
            this.rvFuerza.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rFuerza.rdlc";
            ReportDataSource r = new ReportDataSource("dsRFuerza", dt);
            this.rvFuerza.LocalReport.DataSources.Add(r);
            this.rvFuerza.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
