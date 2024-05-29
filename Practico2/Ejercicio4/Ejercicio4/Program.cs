using Microsoft.VisualBasic;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nro1 = 0, Nro2 = 0;
            Console.WriteLine("-CALCULADORA-");
            Console.WriteLine("Por favor, ingrese la operacion a realizar");
            Console.WriteLine("1- Suma \n2- Resta \n3- Multiplicacion \n4- Division \n5- Factorial \n6- Porcentaje \n7- Conversion a binario");
            String opcion = Console.ReadLine();
            bool siConversion = int.TryParse(opcion, out int seleccion);
            if (siConversion)
            {
                seleccion = Convert.ToInt32(opcion);
                if (seleccion != 5 && seleccion != 7)
                {
                    Nro1 = EntradaNum();
                    Nro2 = EntradaNum();
                }
                else Nro1 = EntradaNum();
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("El resultado es: " + (Nro1 + Nro2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es: " + (Nro1 - Nro2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es: " + (Nro1 * Nro2));
                        break;
                    case 4:
                        if (Nro2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");
                        }
                        else
                        {
                            float result = (float)Nro1 / Nro2;
                            Console.WriteLine("El resultado es: " + result);
                        }
                        break;
                    case 5:
                        int contador = 2, resultado = 1;

                        do
                        {
                            resultado *= contador;
                            contador++;

                        } while (contador <= Nro1);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 6:
                        float porcentaje = (float)(Nro1 * Nro2) / 100;
                        Console.WriteLine("El " + Nro1 + "% de " + Nro2 + " es: " + porcentaje);
                        break;
                    case 7:
                        String binario = Convert.ToString(Nro1, 2);
                        Console.WriteLine("El numero en binario es: " + binario);
                        break;
                }
            }
            else Console.WriteLine("Opcion ingresada no valida");
        }

        static int EntradaNum()
        {
            Console.WriteLine("Ingrese el numero a operar");
            String x = Console.ReadLine();
            int num = int.Parse(x);

            return num;
        }
    }
}

