using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class Fuerza
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public int idSalud;
        public int idAtaque;
        public int idSuper;

        public Fuerza()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Fuerza (id,Nombre,idSalud,idAtaque,idSuper) Values ({id},'{Nombre}',{idSalud},{idAtaque},{idSuper})";
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
            string consulta = $"update Fuerza set Nombre = '{Nombre}', idSalud = {idSalud}, idAtaque = {idAtaque}, idSuper = {idSuper}, where id = {id}";
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
            string consulta = $"delete from Fuerza where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}

