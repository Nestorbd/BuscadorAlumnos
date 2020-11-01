using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador.Vista
{
    public partial class Menu : Form
    {
        public delegate void accionBoton(int valor);
        public event accionBoton clickBoton;
        public Menu()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            clickBoton(0);
        }

        private void verAlumnos_Click(object sender, EventArgs e)
        {
            clickBoton(1);
        }

        private void busEliAlumno_Click(object sender, EventArgs e)
        {
            clickBoton(2);
        }
    }
}
