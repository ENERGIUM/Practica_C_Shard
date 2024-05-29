using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string x = Console.ReadLine();
            double num = double.Parse(x);

            if(num == comprobar(x)){
                Console.WriteLine("El numero ingresado es un número de Armstrong");
            }else{
                Console.WriteLine("El numero ingresado no es un número de Armstrong");
            }

        }

        public static double comprobar(String x)
        {
            int[] cifras = new int[x.Length];
            int i = 0;
            foreach(Char cifra in x){ 
                cifras[i]= int.Parse(cifra.ToString());
                i++;
            }

            double contador = 0;
            foreach(int cifra in cifras){
                double j = Math.Pow( cifra, cifras.Length);
                contador += j;
            }

            return contador;
        }
    }
}
