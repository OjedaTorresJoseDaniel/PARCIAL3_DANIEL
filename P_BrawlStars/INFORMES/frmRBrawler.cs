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
    public partial class frmRBrawler : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmRBrawler()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmRBrawler_Load(object sender, EventArgs e)
        {
            cargarcb();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Calidad";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCalidad.DisplayMember = "Nombre";
            cbCalidad.ValueMember = "id";
            cbCalidad.DataSource = dt;

        }
        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vBrawler";
                chTodo.Checked = false;
            }
            else
            {
                consulta = $"select * from vBrawler where idCalidad = {cbCalidad.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvBrawler.LocalReport.DataSources.Clear();
            this.rvBrawler.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rBrawler.rdlc";
            ReportDataSource r = new ReportDataSource("dsRBrawler", dt);
            this.rvBrawler.LocalReport.DataSources.Add(r);
            this.rvBrawler.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
