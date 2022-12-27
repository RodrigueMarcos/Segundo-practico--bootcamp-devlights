using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Mascota
    {
        private string _nombre;
        private string _tipo;
        private double _energia;
        private char _tamaño ; //g: grande; p:pequeño

        public Mascota (string p_nombre, string p_tipo, char p_tamaño)
        {
            _nombre = p_nombre;
            _tipo = p_tipo;
            _energia = 20;
            _tamaño = p_tamaño;
        }

        public void alimentar()
        {
            _energia = _energia + (_energia * 0.3);
        }
        public bool correr()
        {
            if (_energia > 20)
            {
                _energia = _energia - (_energia * 0.2);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetInformation()
        {
            return ("Nombre: " + _nombre + " Tipo: " +_tipo+" Energia: " + _energia + "%"+" Tamaño: "+_tamaño);
        }
        public char getTamaño()
        {
            return _tamaño;
        }
    }
}
