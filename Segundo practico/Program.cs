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

            Mascota mascota = new Mascota("Deysi","Perra",'c');
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


            Auto auto = new Auto("Renault", "Sandero", "Azul");
            auto.Conductor = persona;
            auto.Capacidad = 4;
            Console.WriteLine(auto.GetInformation());
            
            Persona persona2 = new Persona();
            persona2.Nombre = "Juan";
            persona2.Apellido = "Perez";
            persona2.fechaDeNacimiento = Convert.ToDateTime("1990/07/13");
            auto.agregarPasajeros(persona2);
            auto.agregarMascota(mascota);
            Console.WriteLine("La mascota va en el regazo de: "+auto.getRegazo());
            auto.acelerar();
            auto.acelerar();
            Console.WriteLine(auto.GetInformation());
            auto.frenarTotal();
            auto.bajarPasajeros();
            Console.WriteLine(auto.GetInformation());
            auto.bajarConductor();
            Console.WriteLine(auto.GetInformation());

            Libro libro = new Libro();
            libro.Nombre = "Mi planta de naranja lima";
            libro.Autor = "José Mauro de Vasconcelos";
            libro.cantidadPagina = 250;
            libro.WasRead = false;

            Libro libro2 = new Libro();
            libro2.Nombre = "Harry Potter";
            libro2.Autor = "J. K. Rowling";
            libro2.cantidadPagina = 300;
            libro2.WasRead = true;

            Estudiante estudiante = new Estudiante();
            estudiante.Lector = persona;
            estudiante.agregarLibro(libro);
            estudiante.agregarLibro(libro2);
            estudiante.mostrarLibrosLeidos();
            Console.WriteLine("La cantidad de paginas leidas es "+estudiante.calcularCantPaginaLeida());
            Console.WriteLine("La cantidad de libros NO leidas es " + estudiante.calcularCantLibrosNoLeido());

            Libro libro3 = new Libro();
            libro3.Nombre = "1984";
            libro3.Autor = "George Orwell.";
            libro3.cantidadPagina = 260;
            libro3.WasRead = true;
            estudiante.agregarLibro(libro3);
            estudiante.quitarLibro(libro);

            Console.WriteLine("La cantidad de paginas leidas es " + estudiante.calcularCantPaginaLeida());
            Console.WriteLine("La cantidad de libros NO leidas es " + estudiante.calcularCantLibrosNoLeido());

        }
    }
}
