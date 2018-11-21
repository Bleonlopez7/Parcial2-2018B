using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public BindingSource EnlaceDatosL = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroNotasForm mostrar = new RegistroNotasForm();
            NoEstudiantes datos = new NoEstudiantes();

            mostrar.ShowDialog();
        }
    }
}
