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
    public partial class frmRMarca : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmRMarca()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmRMarca_Load(object sender, EventArgs e)
        {
            cargarcb();
            //this.rvMarca.RefreshReport();
            // this.reportViewer2.RefreshReport();
            //this.rvMarca.RefreshReport();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Copa";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCopa.DisplayMember = "Cantidad";
            cbCopa.ValueMember = "id";
            cbCopa.DataSource = dt;

        }
        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vMarca";
                chTodo.Checked = false;
            }
            else
            {
                consulta = $"select * from vMarca where idCopa = {cbCopa.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvMarca.LocalReport.DataSources.Clear();
            this.rvMarca.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rMarca.rdlc";
            ReportDataSource r = new ReportDataSource("dsRMarca", dt);
            this.rvMarca.LocalReport.DataSources.Add(r);
            this.rvMarca.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
