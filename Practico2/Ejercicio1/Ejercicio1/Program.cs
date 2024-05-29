using System.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Data;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Numero: ");
            string data = Console.ReadLine();
            string invNumero = "";
            int digito = 0;
            //Console.ReadKey();
            bool siConvertible = int.TryParse(data, out int numero);
            numero = siConvertible ? Convert.ToInt32(data) : 0;
            if (siConvertible)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    digito = numero % 10;
                    numero = (numero / 10);
                    invNumero = invNumero + Convert.ToString(digito);
                }
                Console.Write("Numero Invertido: ");
                Console.WriteLine(invNumero);
            }
            else Console.WriteLine("Numero no valido");
        }
    }
}
