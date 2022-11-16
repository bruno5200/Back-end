using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Frases
    {
        private CD_Conexion conection = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public void AgregarFrase(CE_Frases f)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AgregarFrase";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idioma_id", f.IdiomaID);
            comando.Parameters.AddWithValue("@frase", f.Frase);
            comando.Parameters.AddWithValue("@fuente", f.Fuente);
            comando.Parameters.AddWithValue("@creado", f.Creado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
        public void EditarFrase(CE_Frases f)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "EditarFrase";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@frase", f.Frase);
            comando.Parameters.AddWithValue("@fuente", f.Fuente);
            comando.Parameters.AddWithValue("@frase_id", f.Idi);
            //comando.Parameters.AddWithValue("@creado",  f.Creado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
        public DataTable ListarFrases()
        {
            DataTable frases = new DataTable();
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarFrases";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            frases.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return frases;
        }
        public DataTable ListarFrasesIdioma(CE_Frases f)
        {
            DataTable frases = new DataTable();
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarFrasesIdioma";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idioma_id", f.IdiomaID);
            leer = comando.ExecuteReader();
            frases.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return frases;
        }

        public DataTable ListarIdiomas()
        {
            DataTable idiomas = new DataTable();
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarIdiomas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            idiomas.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return idiomas;
        }
    }
}
