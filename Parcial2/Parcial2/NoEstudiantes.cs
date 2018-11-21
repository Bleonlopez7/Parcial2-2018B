using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parcial2
{
    class NoEstudiantes : DaEstudiante
    {
        public double Parcial1 { get; set; }
        public double Parcial2 { get; set; }
        public double Proyecto { get; set; }
        public double Talleres { get; set; }
        public double Participación { get; set; }
        public double Git { get; set; }
        public double Nota { get; set; }

        public override string ToString()
        {
            return $"{Código} / {Nombre} / {Parcial1} / {Parcial2} / {Proyecto} / {Talleres} / {Participación} / {Git} / ({Nota})";
        }
    }
}
