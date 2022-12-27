using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Estudiante
    {
        public Persona Lector { get; set; }
        public List<Libro> libros = new List<Libro>();

        public void mostrarLibrosLeidos()
        {
            Console.WriteLine("Los libros leidos de " + Lector.GetNameFull());
            foreach(Libro libro in libros)
            {
                if(libro.WasRead == true)
                {
                    Console.WriteLine("Nombre: " + libro.Nombre + " Autor: " + libro.Autor);
                }
            }
        }

        public int calcularCantPaginaLeida()
        {
            int cantidad = 0;
            foreach (Libro libro in libros)
            {
                if (libro.WasRead == true)
                {
                    cantidad += libro.cantidadPagina;
                }
            }
            return cantidad;
        }
        public int calcularCantLibrosNoLeido()
        {
            int cantidad = 0;
            foreach (Libro libro in libros)
            {
                if(libro.WasRead == false)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public void agregarLibro(Libro libro)
        {
            libros.Add(libro);
        }
        public void quitarLibro(Libro p_libro)
        {
            if (libros.Contains(p_libro))
            {
                libros.Remove(p_libro);
                Console.WriteLine("Libro removido con exito!!!");
            }
            else
            {
                Console.WriteLine("No se encontro el libro en la lista para remover!!!");
            }

        }
    }
}
