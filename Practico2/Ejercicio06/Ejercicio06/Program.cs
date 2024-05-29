using System.Diagnostics;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un caracter");
            String entrada = Console.ReadLine();
            Char letra = char.Parse(entrada.ToLower());

            bool flag = int.TryParse(entrada, out int sal1);
           
            if (flag) {
                Console.WriteLine("El caracter es una cifra numerica");
            }else {

                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("El caracter es una vocal");
                        break;
                    default:
                        if ((double)letra > 96 && (double)letra < 123)
                        {
                            Console.WriteLine("El caracter es una consonante");
                        }else{
                            Console.WriteLine("Caracter invalido"); }
                        break;
                    }
                }
        }   
        
    }
}
