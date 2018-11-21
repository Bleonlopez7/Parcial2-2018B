using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial2
{
    public partial class RegistroNotasForm : Form
    {
        public const string DiArchivoP = @"C:\Users\karen leon\Desktop\programacion\ParcialSegundoCorte\Parcial2\Promedio Estudiantes.txt";
        public BindingSource EnlaceDatos = new BindingSource();
        public Form1 notas = new Form1();
        public RegistroNotasForm()
        {
            InitializeComponent();
            EnlaceDatos.DataSource = Archivo.Recibir();
            this.dataGridView1.DataSource = EnlaceDatos;
        }

        private void btnGuardarNotas_Click(object sender, EventArgs e)
        {
            NoEstudiantes datos = new NoEstudiantes();
            datos.Código = txtCódigo.Text;
            datos.Nombre = txtNombre.Text;
            datos.Parcial1= Convert.ToDouble(txtParcial1.Text);
            datos.Parcial2= Convert.ToDouble(txtParcial2.Text);
            datos.Proyecto = Convert.ToDouble(txtProyecto.Text);
            datos.Talleres = Convert.ToDouble(txtTalleres.Text);
            datos.Participación = Convert.ToDouble(txtParticipación.Text);
            datos.Git = Convert.ToDouble(txtGit.Text);
            datos.Nota = (((datos.Parcial1 * 15) / 100) + ((datos.Parcial2 * 15) / 100)+ ((datos.Proyecto * 35) / 100) + ((datos.Talleres * 20) / 100) + ((datos.Participación * 10) / 100) + ((datos.Git * 5) / 100));

            EnlaceDatos.Add(datos);
            Archivo.GuardarNotas(datos);
            FileInfo ArchivoDeP = new FileInfo(DiArchivoP);
            StreamWriter EscribirP = ArchivoDeP.AppendText();
            EscribirP.WriteLine(datos.Nota.ToString());
            EscribirP.Flush();
            EscribirP.Close();
            double promedio = 0;
            double cont = 0;
            
            System.IO.StreamReader mirar = new StreamReader(DiArchivoP);
            while (!mirar.EndOfStream)
            {
                promedio = promedio + Convert.ToDouble(mirar.ReadLine());
                cont = cont + 1;
            }
            mirar.Close();
            lblPromedio.Text = "El promedio del curso es " +Convert.ToString(promedio / cont);
            txtCódigo.Text = "";
            txtNombre.Text = "";
            txtParcial1.Text = "";
            txtParcial2.Text = "";
            txtProyecto.Text = "";
            txtTalleres.Text = "";
            txtParticipación.Text = "";
            txtGit.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
