using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parcial2
{
    class Archivo : NoEstudiantes
    {
        public const string DiArchivo = @"C:\Users\karen leon\Desktop\programacion\ParcialSegundoCorte\Parcial2\Notas Estudiantes.txt";

        public static bool GuardarNotas(NoEstudiantes estudiantes )
        {
            FileInfo ArchivoDeE = new FileInfo(DiArchivo);
            if (ArchivoDeE.Exists == false)
            {
                FileStream RdN = ArchivoDeE.Create();
                StreamWriter escribir = new StreamWriter(RdN);
                escribir.Write("");
                escribir.Flush();
                escribir.Close();
                RdN.Close();
            }
            StreamWriter Escribir = ArchivoDeE.AppendText();
            Escribir.WriteLine(estudiantes.ToString());
            Escribir.Flush();
            Escribir.Close();
            return true;
        }
        public static List<NoEstudiantes> Recibir()
        {
            List<NoEstudiantes> LosLosEstudiantes = new List<NoEstudiantes>();
            string linea;
            TextWriter RutaA = new StreamWriter(DiArchivo, true);
            RutaA.Close();
            StreamReader leer = new StreamReader(DiArchivo);
            while ((linea = leer.ReadLine()) != null)
            {
                string[] datosE = linea.Split(';');
                NoEstudiantes notas = new NoEstudiantes
                {
                    Código = datosE[0],
                    Nombre = datosE[1],
                    Parcial1 = Convert.ToDouble(datosE[2]),
                    Parcial2 = Convert.ToDouble(datosE[3]),
                    Proyecto = Convert.ToDouble(datosE[4]),
                    Talleres = Convert.ToDouble(datosE[5]),
                    Participación = Convert.ToDouble(datosE[6]),
                    Git = Convert.ToDouble(datosE[7]),
                    Nota= Convert.ToDouble(datosE[8])
                };
                LosLosEstudiantes.Add(notas);
            }
            leer.Close();
            return LosLosEstudiantes;
        }
    }
}
