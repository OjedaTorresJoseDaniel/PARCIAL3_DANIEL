using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class Calidad
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //CAMPOS
        public int id;
        public string Nombre;

        public Calidad()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Calidad (id,Nombre) Values ({id},'{Nombre}')";
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
            string consulta = $"update Calidad set Nombre = '{Nombre}' where id = {id}";
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
            string consulta = $"delete from Calidad where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}
