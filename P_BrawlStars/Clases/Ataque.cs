using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class Ataque
    {

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //CAMPOS
        public int id;
        public string Nombre;
        public string Descripcion;
        public string Daño;
        public string A_Alcance;
        public string VelocidadDeRecarga;

        public Ataque()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Ataque (id,Nombre,Descripcion,Daño,A_Alcance,VelocidadDeRecarga) Values ({id},'{Nombre}','{Descripcion}','{Daño}','{A_Alcance}','{VelocidadDeRecarga}')";
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
            string consulta = $"update Ataque set Nombre = '{Nombre}',Descripcion = '{Descripcion}',Daño = '{Daño}', A_Alcance = '{A_Alcance}', VelocidadDeRecarga = '{VelocidadDeRecarga}' where id = {id}";
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
            string consulta = $"delete from Ataque where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}

