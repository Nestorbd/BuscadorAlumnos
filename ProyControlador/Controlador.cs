using System;
using System.Windows.Forms;
using Buscador.Vista;
using Buscador.Modelo;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Buscador.Controlador
{
    public class Controlador
    {
        Vista.Menu menu = null;
        Vista.FrmVerAlumnos vAlumno = null;
        Vista.FrmBusEliAlumno busEliAlumno = null;
        Modelo.Modelo modelo = null;

        public Controlador()
        {

            modelo = new Modelo.Modelo();
            IniciarMenu();
            
        }
        public void IniciarMenu()
        {
            try
            {
                menu = new Vista.Menu();

                menu.clickBoton += MenuClickBoton;

                menu.ShowDialog();
            }
            catch(Exception e) {
                MessageBox.Show("Ha ocurrido un error");
            }
           
            
        }
        private void MenuClickBoton(int valor)
        {

            if (valor == 0) { 
            if (MessageBox.Show("¿Seguro de que quieres salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();   
             }
            
            if (valor == 1)
            {
                menu.Hide();
                VerAlumnos();
            }

            if (valor == 2) { 
                menu.Hide();
                BuscarEliminarAlumno();
            }
        }

        private void VerAlumnos()
        {
            try
            {
                vAlumno = new Vista.FrmVerAlumnos();
                vAlumno.clickBoton += VAlumnoClickBoton;
                MostrarDatos();
                vAlumno.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void VAlumnoClickBoton(int valor)
        {
            if (valor == 0) {
                vAlumno.Hide();
                menu.Show();
            }
                
        }
        private void BuscarEliminarAlumno()
        {
            try {
                busEliAlumno = new Vista.FrmBusEliAlumno();
                busEliAlumno.clickBoton += BusEliAlumnoClickBoton;
                busEliAlumno.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void BusEliAlumnoClickBoton(int valor)
        {
            if (valor == 0)
            {
                
                BuscarAlumno();
            }
             
            if (valor == 1)
            {
                if (MessageBox.Show("¿Seguro de que quieres eliminar este alumno?","Eliminar alumno", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    EliminarAlumno();
                else
                    MessageBox.Show("Alumno no eliminado");

            }

            if (valor == 2)
            {
                busEliAlumno.Hide();
                menu.Show();
            }
        }
        
        public void MostrarDatos()
        {
            try
            {
                DataSet listaAlumnos = new DataSet();
                MySqlDataAdapter adaptador = modelo.MostrarAlumnos();
                adaptador.Fill(listaAlumnos);
                DataGridView tablaAlumnos = vAlumno.GetDataGridAlumnos();

                tablaAlumnos.DataSource = listaAlumnos.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
           
            
        }

        public void BuscarAlumno()
        {
            try
            {
                String dni = busEliAlumno.TxtDniAlumno.Text;

                DataSet alumno = new DataSet();
                MySqlDataAdapter adaptador = modelo.BuscadorAlumno(dni);
                adaptador.Fill(alumno);
                DataGridView tablaAlumno = busEliAlumno.DataGridAlumno;

                tablaAlumno.DataSource = alumno.Tables[0];
                tablaAlumno.Columns[0].Visible = false;

                busEliAlumno.TxtDniAlumno.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
          
        }

        public void EliminarAlumno()
        {
            try
            {
                String dni = busEliAlumno.TxtDniAlumno.Text;
                modelo.EliminarAlumno(dni);
                MessageBox.Show("Eliminado");
                busEliAlumno.TxtDniAlumno.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
    

        }



    }
}
