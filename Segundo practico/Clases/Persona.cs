using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public Smartphone smartphone { get; set; }

        public string GetNameFull()
        {
            return Nombre+ " " + Apellido;
        }
        public int calcular_edad()
        {
            return DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;
        }
    }
}
