using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    static class Biblioteca
    {
        public static void agregarLibro(ref Libro libro, ref List<Libro> biblioteca)
        {
            biblioteca.Add(libro);
        }

        public static Libro buscarLibroPorISBN(ulong isbn, List<Libro> biblioteca)
        {
            bool siEncontrado = false;
            Libro libro1 = null;
            foreach (Libro libro in biblioteca)
            {
                if (isbn != libro.Isbn)
                {
                    continue;
                }
                else
                {
                    siEncontrado = true;
                    libro1 = libro;
                    break;
                }
            }
            return (siEncontrado) ? libro1 : null;
        }

        public static void prestarLibro(string fechaPrestamo, string fechaDevolucion, ulong isbn, string nombreDeLector, ref List<Libro>biblioteca, ref List<Prestamo> prestamos)
        {
            bool siEncontrado = false;
            foreach (Libro libro in biblioteca)
            {
                if (isbn != libro.Isbn)
                {
                    continue;
                }
                else
                {
                    siEncontrado = true;
                    if (libro.EjemplaresDisponibles <= 0)
                    {
                        libro.EjemplaresDisponibles = 0;
                        Console.WriteLine("No quedan ejemplares disponibles");
                    }
                    else
                    {
                        libro.EjemplaresDisponibles--;
                        libro.EjemplaresRetirados++;
                        Libro libro1 = libro;
                        var prestamo = new Prestamo(fechaPrestamo, fechaDevolucion, libro1, nombreDeLector);
                        prestamos.Add(prestamo);
                    }
                    break;
                }
            }
            if (!siEncontrado)
            {
                Console.WriteLine("\n#-LIBRO NO ENCONTRADO");
            }
        }

        public static void listarLibrosDisponibles(List<Libro> biblioteca)
        {
            foreach (Libro libro in biblioteca)
            {
                if (libro.EjemplaresDisponibles > 0)
                {
                    Console.WriteLine(libro.ToString());
                }
            }
        }

        public static void listarLibrosRetirados(List<Libro> biblioteca)
        {
            foreach (Libro libro in biblioteca)
            {
                if (libro.EjemplaresRetirados > 0)
                {
                    Console.WriteLine(libro.ToString2());
                }
            }
        }
    }


}
