using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class QuintoRefuerzo
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //CAMPOS
        public int id;
        public string Nombre;
        public string Descripcion;

        public QuintoRefuerzo()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Refuerzo5 (id,Nombre,Descripcion) Values ({id},'{Nombre}','{Descripcion}')";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "Proceso Exitoso";
            }
            catch
            {
                msj = "¡¡¡¡¡¡Error!!!!!!";
            }
            return msj;
        }
        public string actualizar()
        {
            string msj = "";
            string consulta = $"update Refuerzo5 set Nombre = '{Nombre}', Descripcion = '{Descripcion}' where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "se ejecuto el metodo";
            return msj;
        }
        public string Eliminar()
        {
            string msj = "";
            string consulta = $"delete from Refuerzo5 where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}
