using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Tarea
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaDeNacimiendo { get; set; }
        public string Monotributo { get; set; }

        public override string ToString()
        {
            return "Su nombre es " + Nombre + " " + Apellido + " es " + Sexo + " y nacio el " + FechaDeNacimiendo + ". " + Monotributo;
        }

    }
}
