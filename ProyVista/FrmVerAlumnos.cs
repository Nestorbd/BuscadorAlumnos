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
    public partial class FrmVerAlumnos : Form
    {
        
        public delegate void accionBoton(int valor);
        public event accionBoton clickBoton;
        public FrmVerAlumnos()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            clickBoton(0);
        }
    }
}
