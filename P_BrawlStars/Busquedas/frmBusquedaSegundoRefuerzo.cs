﻿using P_BrawlStars.Clases;
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

namespace P_BrawlStars.Busquedas
{
    public partial class frmBusquedaSegundoRefuerzo : Form
    {
        Clases.ConexionSQL x = new Clases.ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmBusquedaSegundoRefuerzo()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmBusquedaSegundoRefuerzo_Load(object sender, EventArgs e)
        {
            try
            {
                dgSegundoRefuerzo.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select * from Refuerzo2 where Nombre LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgSegundoRefuerzo.DataSource = dt;
            con.Close();
            try
            {
                dgSegundoRefuerzo.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargardg();
        }

        private void dgSegundoRefuerzo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgSegundoRefuerzo.CurrentRow.Index;
            dgSegundoRefuerzo.Rows[i].Selected = true;
        }

        private void dgSegundoRefuerzo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgSegundoRefuerzo.CurrentRow.Index;
            dgSegundoRefuerzo.Rows[i].Selected = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}