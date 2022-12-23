using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Smartphone
    {
        private string _estado;
        private int _volumen;
        private bool _silencio;
        private int _brillo;
        public string Marca { get; }
        public string Modelo { get; }

        public Smartphone(string p_marca, string p_modelo)
        {
            Marca= p_marca;
            Modelo= p_modelo;
            _brillo = 50;
            _silencio = false;
            _volumen= 50;
            _estado= "on";
        }
        public void encerder()
        {
            _estado= "on";
        }
        public void apagar()
        {
            _estado = "off";
        }
        public void subirVolumen()
        {
            if(_volumen != 100)
            {
                _volumen += 10 ;
            }
        }
        public void bajarVolumen()
        {
            if (_volumen != 0)
            {
                _volumen -= 10;
            }
        }
        public void silenciar()
        {
            if(_silencio != true)
            {
                _silencio = true;
            }
        }
        public void desenmudecer()
        {
            if (_silencio != false)
            {
                _silencio = false;
            }
        }
        public void levantarBrillo()
        {
            if(_brillo != 100)
            {
                _brillo += 10;
            }
        }
        public void bajarBrillo()
        {
            if (_brillo != 0)
            {
                _brillo -= 10;
            }
        }
        public string GetInformationFull()
        {
            return ("Marca: " + Marca + " Modelo: " + Modelo + " Estado: " + _estado + " Volumen: " + _volumen +" Silencio: "+_silencio+" Brillo: "+_brillo);
        }
    }
}
