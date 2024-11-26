using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BrawlStars.Clases
{
    internal class Brawler
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public string Descripcion;
        public int idCalidad;
        public int idTipo;
        public int idMarca;
        public int idRefuerzo1;
        public int idRefuerzo2;
        public int idRefuerzo3;
        public int idRefuerzo4;
        public int idRefuerzo5;
        public int idRefuerzo6;
        public int idRefuerzo7;
        public int idGadget_Uno;
        public int idGadget_Dos;
        public int idPrimer_Estelar;
        public int idSegunda_Estelar;
        public int idHipercarga;
        public int idEstadisticasDelBrawler;

        public Brawler()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Brawler (id,Nombre,Descripcion,idCalidad,idTipo,idMarca,idRefuerzo1,idRefuerzo2,idRefuerzo3,idRefuerzo4,idRefuerzo5,idRefuerzo6,idRefuerzo7,idGadget_Uno,idGadget_Dos,idPrimer_Estelar,idSegunda_Estelar,idHipercarga,idEstadisticasDelBrawler) Values ({id},'{Nombre}',{Descripcion},{idCalidad},{idTipo},{idMarca},{idRefuerzo1},{idRefuerzo2},{idRefuerzo3},{idRefuerzo4},{idRefuerzo5},{idRefuerzo6},{idRefuerzo7},{idGadget_Uno},{idGadget_Dos},{idPrimer_Estelar},{idPrimer_Estelar},{idHipercarga},{idEstadisticasDelBrawler})";
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
            string consulta = $"update Brawler set Nombre = '{Nombre}', Descripcion = '{Descripcion}' idCalidad = {idCalidad}, idTipo = {idTipo}, idMarca = {idMarca}, idRefuerzo1 = '{idRefuerzo1}', idRefuerzo2 = '{idRefuerzo2}, idRefuerzo3 = '{idRefuerzo3}, idRefuerzo4 = '{idRefuerzo4}, idRefuerzo5 = '{idRefuerzo5}, idRefuerzo6 = '{idRefuerzo6}, idRefuerzo7 = '{idRefuerzo7}, idGadget_Uno = '{idGadget_Uno}, idGadget_Dos = '{idGadget_Dos} , idGadget_Dos = '{idGadget_Dos}, idPrimer_Estelar = '{idPrimer_Estelar}, idSegunda_Estelar = '{idPrimer_Estelar}, idHipercarga = {idHipercarga}, idEstadisticasDelBrawler = {idEstadisticasDelBrawler} where id = {id}";
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
            string consulta = $"delete from Brawler where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro";
            return msj;
        }
    }
}
