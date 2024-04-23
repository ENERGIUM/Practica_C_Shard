using System.ComponentModel;
namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> biblioteca = new List<Libro>();
            List<Prestamo> prestamos = new List<Prestamo>();
            string lect = "";
            do
            {
                Console.WriteLine("\n#-----------------------------------------------------#");
                Console.WriteLine("#-------------------Biblioteca------------------------#");
                Console.WriteLine("#-----------------------------------------------------#");
                Console.WriteLine("#-(Agregar un nuevo libro) ================= (opcion 1)");
                Console.WriteLine("#-(Buscar un libro por ISBN) =============== (opcion 2)");
                Console.WriteLine("#-(Prestar un libro) ======================= (opcion 3)");
                Console.WriteLine("#-(Devolver un libro) ====================== (opcion 4)");
                Console.WriteLine("#-(Mostrar la lista de libros disponibles) = (opcion 5)");
                Console.WriteLine("#-(Mostrar la lista de libros prestados) === (opcion 6)");
                Console.WriteLine("#-(Salir) ================================== (Escriba: exit)");
                Console.Write("#-(Opcion): ");
                lect = Console.ReadLine();
                bool siConvert = byte.TryParse(lect, out byte numLect);
                numLect = (byte)((siConvert) ? Convert.ToByte(lect, 16) : 0);
                switch (numLect)
                {
                    case 1:
                        Console.Write("\n#-(Ingrese Titulo del Libro): ");
                        string titulo = Console.ReadLine();
                        Console.Write("#-(Ingrese Autor del Libro): ");
                        string autor = Console.ReadLine();
                        Console.Write("#-(Ingrese Isbn del Libro): ");
                        string isbn_s = Console.ReadLine();
                        ulong isbn = Convert.ToUInt64(isbn_s);
                        Console.Write("#-(Ingrese Genero del Libro): ");
                        string gen = Console.ReadLine();
                        Console.Write("#-(Ingrese ejemplares disponibles): ");
                        string num_s = Console.ReadLine();
                        uint num = Convert.ToUInt32(num_s);
                        Libro libro = new Libro(titulo, autor, isbn, gen, num);
                        Biblioteca.agregarLibro(ref libro, ref biblioteca);
                        break;

                    case 2:
                        Console.Write("\n#-(Ingrese ISBN de libro): ");
                        isbn = Convert.ToUInt64(Console.ReadLine());
                        libro = Biblioteca.buscarLibroPorISBN(isbn, biblioteca);
                        Console.WriteLine(libro.ToString());
                        break;

                    case 3:
                        Console.Write("\n#-(Ingrese Nombre del lector que retira el libro): ");
                        string nombre = Console.ReadLine();
                        Console.Write("#-(Ingrese Isbn del Libro): ");
                        isbn_s = Console.ReadLine();
                        isbn = Convert.ToUInt64(isbn_s);
                        Console.Write("\n#-(Ingrese Fecha del prestamo del libro): ");
                        string fecha_prestamo = Console.ReadLine();
                        Console.Write("\n#-(Ingrese Fecha de devolucion): ");
                        string fecha_devolucion = Console.ReadLine();
                        Biblioteca.prestarLibro(fecha_prestamo, fecha_devolucion, isbn, nombre, ref biblioteca, ref prestamos);
                        break;

                    case 4:
                        break;

                    case 5:
                        Biblioteca.listarLibrosDisponibles(biblioteca);
                        break;

                    case 6:
                        Biblioteca.listarLibrosRetirados(biblioteca);
                        break;
                }
            } while (lect != "exit");
        }
    }
}
