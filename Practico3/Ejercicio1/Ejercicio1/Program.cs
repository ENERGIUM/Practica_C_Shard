using static Ejercicio1.Estudiante;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var est1 = new Estudiante("Martin", "Tabusso", 24, 2024);
            var est2 = new Estudiante("Elis", "Juaco", 21, 2023);
            Console.WriteLine(est1.toString());
            Console.WriteLine("\n");
            Console.WriteLine(est2.toString());
            Console.WriteLine("Promedio de edad de ingresantes: " + calcularPromedioEdad(est1.Edad, est2.Edad));
        }
    }
}
