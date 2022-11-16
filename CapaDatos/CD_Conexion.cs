using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source =DESKTOP-90C7F1O; Initial Catalog =AppMovil;Integrated Security=True");
        //private SqlConnection Conexion = new SqlConnection("Data Source =DESKTOP-I5O06PP; Initial Catalog =AppMovil;Integrated Security=True");
        //Private SqlConnection Conexion = new SqlConnection("Data Source =200.87.92.46:3000; Initial Catalog =AppMovil;Integrated Security=True");
        public SqlConnection AbrirConexion()
        { //metodo para abrir la conexion si esta cerrada
            if (Conexion.State == ConnectionState.Closed)//comprobamos el estado de la conexion
                Conexion.Open();//abrimos la conexion si esta cerrada
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        { //metodo para cerrar la conexion si esta abierta

            if (Conexion.State == ConnectionState.Open)//comprobamos el estado de la conexion
                Conexion.Close();//cerrramos la conexion si esta abierta
            return Conexion;
        }
    }
}
