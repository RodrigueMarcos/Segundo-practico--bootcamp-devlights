using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Auto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        private bool _estadoMotor; //false: apagado, true: encendido
        private double _velocidad;
        public Persona Conductor { get; set; }
        public int Capacidad { get; set; }
        public List<Persona> Pasajeros = new List<Persona>();
        private Mascota _mascota;
        private string _regazo;


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
            if(_estadoMotor != true && Conductor != null && Conductor.calcular_edad() >= 18 )
            {
                _estadoMotor = true;
            }
            else
            {
                Console.WriteLine("No se puede encender el auto porque no hay ninguna persona asignada al veiculo o porque la perosna no es mayor de 17 años");
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
        public void frenarTotal()
        {
            _velocidad= 0;
        }
        public string GetInformation()
        {
            return ("Marca: "+Marca +"Modelo: "+Modelo+" Color: "+ Color+"Estado del motor: " + _estadoMotor+ " Velocidad: "+_velocidad);
        }
        public bool agregarPasajeros(Persona p_persona) {
            if(Capacidad > 0) //y hay lugar
                {
                    Pasajeros.Add(p_persona);
                    return true;
                }
                else
                {
                    return false;
                }   
        }
        public bool agregarMascota(Mascota p_mascota)
        {
             if(Conductor != null)
            {
                if(p_mascota.getTamaño() == 'c')
                {
                    if(Pasajeros.Count > 0)
                    {
                        _mascota = p_mascota;
                        alzarPerro(Pasajeros.FirstOrDefault());//regazo
                        return false;
                    }
                    else
                    {
                        _mascota = p_mascota;
                        return true;
                    }
                    
                }
                else //es grande
                {
                    if(Capacidad > Pasajeros.Count)
                    {
                        Capacidad -= 1;
                        _mascota= p_mascota;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("El perro es grande y no hay mas capacidad!!!");
                        return false;
                    }
                }

            }
            else
            {
                Console.WriteLine("No hay conductor asignado!!!");
                return false;
            }
        }
        private void alzarPerro(Persona p_persona)
        {
            _regazo = p_persona.GetNameFull();
        }
        public string getRegazo()
        {
            return _regazo;
        }
        public void moverMascota(Persona p_persona)
        {
            if(Pasajeros.Contains(p_persona))
            {
                _regazo= p_persona.GetNameFull();
            }
        }
        public void bajarPasajeros()
        {
            if(_velocidad == 0)
            {
                Pasajeros.Clear();
            }
        }

        public void bajarConductor()
        {
            if(_estadoMotor == false)
            {
                Conductor = null;
            }
        }

    }
}
