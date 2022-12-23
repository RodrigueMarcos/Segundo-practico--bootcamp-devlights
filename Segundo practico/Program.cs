using Segundo_practico.Clases;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios_anteriores objeto = new Ejercicios_anteriores();
            //objeto.ejercicio10();

            Console.WriteLine("El area del cuadrado es: " + Cuadrado.calcularAreaDelCuadrado(5, 5));
            Persona persona = new Persona();
            persona.Nombre = "Marcos";
            persona.Apellido = "Rodrigue";
            persona.fechaDeNacimiento = Convert.ToDateTime("1998/01/22");
            Console.WriteLine("La cantidad de años que tiene "+persona.Nombre+" "+ persona.Apellido+" es "+persona.calcular_edad());

            Mascota mascota = new Mascota("Deysi","Perra");
            Console.WriteLine(mascota.GetInformation());
            if (mascota.correr())
            {
                Console.WriteLine("Corrio con exito");
            }
            else
            {
                Console.WriteLine("Energia menor o igual a 20%");
            }
            mascota.alimentar();
            Console.WriteLine(mascota.GetInformation());
            
            Smartphone smartphone= new Smartphone("Samsung","A30");
            Console.WriteLine(smartphone.GetInformationFull());
            smartphone.apagar();
            smartphone.subirVolumen();
            smartphone.bajarBrillo();
            smartphone.silenciar();
            Console.WriteLine(smartphone.GetInformationFull());


        }
    }
}
