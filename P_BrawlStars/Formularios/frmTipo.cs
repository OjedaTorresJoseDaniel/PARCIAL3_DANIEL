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

namespace P_BrawlStars.Formularios
{
    public partial class frmTipo : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public frmTipo()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Tipo").ToString();
            txtId.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Tipo where id ={id}";
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
        private void frmTipo_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Tipo").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Tipo x = new Clases.Tipo();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
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
            Busquedas.frmBusquedaTipo x = new Busquedas.frmBusquedaTipo();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgTipo.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgTipo.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
        }
        void obtener()
        {
            string consulta = $"select * from Tipo where id = {txtId.Text}";

            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtId.Text = reader["id"].ToString();
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
            Tipo x = new Tipo();
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