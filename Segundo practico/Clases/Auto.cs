using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Auto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        private bool _estadoMotor;
        private double _velocidad;

        
        public Auto(string p_marca,string p_modelo,string p_color)
        {
            Marca= p_marca;
            Modelo= p_modelo;
            Color= p_color;
            _estadoMotor = false;
            _velocidad= 0;
        }
        public void encerderMotor()
        {
            if(_estadoMotor != true )
            {
                _estadoMotor = true;
            }
            
        }
        public void apagarMotor()
        {
            if(_estadoMotor != false)
            {
                _estadoMotor = false;
            }
        }
        public bool getEstado()
        {
            return _estadoMotor;
        }
        public void acelerar()
        {
            if (_estadoMotor != true)
            {
                _estadoMotor = true;
                
            }

            if (_velocidad == 0)
            {
                _velocidad= 10;
            }
            else
            {
               _velocidad += (_velocidad * 0.1);
                
            }
           

        }
        public void frenar()
        {
            if(_velocidad != 0)
            {
                _velocidad-= (_velocidad * 0.2);
            }
        }
        public string GetInformation()
        {
            return ("Marca: "+Marca +"Modelo: "+Modelo+" Color: "+ Color+"Estado del motor: " + _estadoMotor+ " Velocidad: "+_velocidad);
        }
    }
}
