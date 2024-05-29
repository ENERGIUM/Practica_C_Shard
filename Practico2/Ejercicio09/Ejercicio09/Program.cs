namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de numeros que desea generar");
            String entrada = Console.ReadLine();

            byte cantidadNro = byte.Parse(entrada);

            Random ran = new Random();

            for(int i =0; i < cantidadNro; i++)
            {
                int Nro = ran.Next(100);
                Console.WriteLine("Numero generado: " + Nro + " Codigo ASCII: " + (char)Nro);
            }
        }
    }
}
