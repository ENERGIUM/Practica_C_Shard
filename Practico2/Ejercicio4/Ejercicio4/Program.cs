namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-CALCULADORA-");
            Console.WriteLine("Por favor, ingrese la operacion a realizar");
            Console.WriteLine("1- Suma \n2- Resta \n3- Multiplicacion \n4- Division \n5- Factorial \n6- Porcentaje \n7- Conversion a binario");
            String opcion = Console.ReadLine();
            bool siConversion = int.TryParse(opcion, out int seleccion);

            if (siConversion)
            {
                seleccion = Convert.ToInt32(opcion);
                switch (seleccion)
                {
                    case 1:
                        int a = EntradaNum(), b = EntradaNum();
                        Console.WriteLine("El resultado es: " + (a + b));
                        break;
                    case 2:
                        int c = EntradaNum(), d = EntradaNum();
                        Console.WriteLine("El resultado es: " + (c - d));
                        break;
                    case 3:
                        int e = EntradaNum(), f = EntradaNum();
                        Console.WriteLine("El resultado es: " + (e * f));
                        break;
                    case 4:
                        int g = EntradaNum(), h = EntradaNum();
                        if (h == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");
                        }
                        else
                        {
                            float result = (float)g / h;
                            Console.WriteLine("El resultado es: " + result);
                        }
                        break;
                    case 5:
                        int x = EntradaNum(), contador = 2, resultado = 1;

                        do
                        {
                            resultado *= contador;
                            contador++;

                        } while (contador <= x);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 6:
                        int j = EntradaNum(), k = EntradaNum();
                        float porcentaje = (float)(j * k) / 100;
                        Console.WriteLine("El " + k + "% de " + j + " es: " + porcentaje);
                        break;
                    case 7:
                        int l = EntradaNum();
                        String binario = Convert.ToString(l, 2);
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

