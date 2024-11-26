using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class Hipercarga
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //CAMPOS
        public int id;
        public string Nombre;
        public string H_Super;
        public string Velocidad;
        public string Escudo;
        public string Daño;

        public Hipercarga()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Hipercarga(id, Nombre, Velocidad, Daño, Escudo, H_Super) Values({id}, '{Nombre}', '{Velocidad}', '{Daño}','{Escudo}','{H_Super}')";
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
            string consulta = $"update Hipercarga set Nombre = '{Nombre}', H_Super = '{H_Super}', Velocidad = '{Velocidad}', Escudo = '{Escudo}', Daño = '{Daño}' where id = {id}";
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
            string consulta = $"delete from Hipercarga where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}

