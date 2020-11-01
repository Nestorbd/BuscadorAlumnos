using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Buscador.Modelo
{
    public class Conexion
    {
        string cadenaConexion
        {
            get;
            set;
        }

      public  MySqlConnection conexionBD
        {
            get;
            set;
            
        }


        public string InicializarCadena()
        {
            string servidor = "localhost";
            string bd = "libros";
            string usuario = "root";
            string password = "10201020nBD";
            

            cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            return cadenaConexion;
        }

        public MySqlConnection CrearConexion()
        {
           String cadena =  InicializarCadena();

            MySqlConnection conexionBD = new MySqlConnection(cadena);

            try
            {

                 conexionBD.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            
            return conexionBD;
        }

      

        
    }
}
