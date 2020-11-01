using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Buscador.Modelo
{
    public class Modelo
    {
        MySqlConnection conn;
        Conexion conexion = new Conexion();
        
        public Modelo()
            {
            conn = conexion.CrearConexion();
            
            }
        public MySqlDataAdapter MostrarAlumnos()
        {
            try
            {
                conn.Open();
                String sentencia = "Select * From alumnos";

                MySqlDataAdapter mostrarAlumnos = new MySqlDataAdapter(sentencia, conn);
                conn.Close();
                return mostrarAlumnos;
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
            
        }

        public MySqlDataAdapter BuscadorAlumno(String dni)
        {
            try
            {
                conn.Open();
                String sentencia = "Select * from alumnos where dni= '" + dni + "'";

                MySqlDataAdapter verAlumno = new MySqlDataAdapter(sentencia, conn);
                conn.Close();
                return verAlumno;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        
        }

        public void EliminarAlumno(String dni)
        {
            try
            {
                conn.Open();
                String sentencia = "Delete from alumnos where dni='" + dni + "'";

                MySqlCommand eliminarAlumno = new MySqlCommand(sentencia, conn);

                eliminarAlumno.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
           
           
        }

      
    }


}
