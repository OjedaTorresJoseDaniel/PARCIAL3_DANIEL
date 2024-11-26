using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class SegundaEstelar
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //CAMPOS
        public int id;
        public string Nombre;
        public string Descripcion;

        public SegundaEstelar()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Segunda_Estelar (id,Nombre,Descripcion) Values ({id},'{Nombre}','{Descripcion}')";
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
            string consulta = $"update Segunda_Estelar set Nombre = '{Nombre}', Descripcion = '{Descripcion}' where id = {id}";
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
            string consulta = $"delete from Segunda_Estelar where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}
