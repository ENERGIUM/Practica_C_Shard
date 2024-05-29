namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool siPrimo = false;
            Console.WriteLine("Hola, Ingrese numero");
            Console.Write("->");
            string lineaIngresada = Console.ReadLine();
            bool siConversion = int.TryParse(lineaIngresada, out int numero);
            if (siConversion)
            {
                numero = Convert.ToInt32(lineaIngresada);
                if (numero == 2 || numero == 3)
                {
                    siPrimo = true;
                }
                else
                {
                    for (int i = 2; i < numero - 1; i++)
                    {
                        {
                            if ((numero % i) == 0)
                            {
                                siPrimo = false;
                                break;
                            }
                            else siPrimo = true;
                        }
                    }
                }
                if (siPrimo)
                {
                    Console.WriteLine("El numero ingresado es primo");
                }
                else Console.WriteLine("El numero ingresado no es primo");
            }
            else Console.WriteLine("Numero ingresado no valido");
        }
    }
}
