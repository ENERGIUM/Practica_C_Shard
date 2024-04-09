namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nro = 0, Nro1 = 0, Nro2 = 0;
            Console.WriteLine("-CALCULADORA-");
            Console.WriteLine("Por favor, ingrese la operacion a realizar");
            Console.WriteLine("1- Suma \n2- Resta \n3- Multiplicacion \n4- Division \n5- Factorial \n6- Porcentaje \n7- Conversion a binario");
            Console.WriteLine("8- Raiz cuadrada\n9- Potencia\n10- Coseno\n11- Seno\n12- Valor absoluto\n13- Redondeo\n14- Nro maximo\n15- Nro minimo");
            String opcion = Console.ReadLine();
            bool siConversion = int.TryParse(opcion, out int seleccion);

            if (siConversion)
            {
                seleccion = Convert.ToInt32(opcion);
                if (seleccion != 5 && seleccion < 7 || seleccion == 9 || seleccion == 14 || seleccion == 15)
                {
                    Nro1 = EntradaNum();
                    Nro2 = EntradaNum();
                }
                else if (seleccion != 13) { Nro = EntradaNum(); }

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

                        } while (contador <= Nro);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 6:
                        float porcentaje = (float)(Nro1 * Nro2) / 100;
                        Console.WriteLine("El " + Nro1 + "% de " + Nro2 + " es: " + porcentaje);
                        break;
                    case 7:
                        String binario = Convert.ToString(Nro, 2);
                        Console.WriteLine("El numero en binario es: " + binario);
                        break;
                    case 8:
                        Console.WriteLine("La raíz del numero " + Nro + " es: " + Math.Sqrt(Nro));
                        break;
                    case 9:
                        double potencia = Math.Pow((double)Nro1,(double)Nro2);
                        Console.WriteLine("El resultado es: " + potencia);
                        break;
                    case 10:
                        Console.WriteLine("Ingrese el angulo en grados °");
                        double anguloEnRadianes = (double)Nro * Math.PI / 180;
                        double coseno = Math.Cos(anguloEnRadianes);
                        Console.WriteLine("El resultado es: " + coseno);
                        break;
                    case 11:
                        anguloEnRadianes = (double)Nro * Math.PI / 180;
                        Console.WriteLine("El resultado es: " + Math.Sin(anguloEnRadianes));
                        break;
                    case 12:
                        int absoluto = Math.Abs(Nro);
                        Console.WriteLine("El resultado es : " + absoluto);
                        break;
                    case 13:
                        Console.WriteLine("Ingrese numero");
                        string data = Console.ReadLine();
                        double Nro3 = Convert.ToDouble(data);
                        double rendondeo = (double)Math.Round(Nro3);
                        Console.WriteLine("El rendondeo da: " + rendondeo);
                        break;
                    case 14:
                        int max = Math.Max(Nro1, Nro2);
                        Console.WriteLine("El numero mayor es: "+ max);
                        break;
                    case 15:
                        int min = Math.Min(Nro1, Nro2);
                        Console.WriteLine("El numero menor es: " + min);
                        break;
                }
            }
            else Console.WriteLine("Opcion ingresada no valida");
        }

        static int EntradaNum()
        {
            Console.WriteLine("Ingrese el numero a operar");
            String x = Console.ReadLine();
            int a = int.Parse(x); 

            return a;
        }
    }
}

