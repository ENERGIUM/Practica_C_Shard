namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> biblioteca = new List<Libro>();

            Console.WriteLine("#-----------------------------------------------------#");
            Console.WriteLine("#-------------------Biblioteca------------------------#");
            Console.WriteLine("#-----------------------------------------------------#");
            Console.WriteLine("#-(Agregar un nuevo libro) ================= (opcion 1)");
            Console.WriteLine("#-(Buscar un libro por ISBN) =============== (opcion 2)");
            Console.WriteLine("#-(Prestar un libro) ======================= (opcion 3)");
            Console.WriteLine("#-(Devolver un libro) ====================== (opcion 4)");
            Console.WriteLine("#-(Mostrar la lista de libros disponibles) = (opcion 5)");
            Console.WriteLine("#-(Mostrar la lista de libros prestados) === (opcion 6)");
            Console.WriteLine("#-(Salir) ================================== (opcion 7)");
            Console.Write("#-(Opcion): ");
            string lect = Console.ReadLine();
            byte numLect = Convert.ToByte(lect, 16);
            switch(numLect)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;
            }
        }
    }
}
