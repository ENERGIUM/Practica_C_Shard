using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte CantidadH = 0, CantidadP = 0, CantidadB = 0;
            double precioH = 0, precioP = 0, precioB = 0;
            double Resultado = 0;
            string linea = "";
            bool flag = true;
            Console.WriteLine("#- Total de tiket ingresado");
            do
            {
                Console.WriteLine("\n#.Ingrese cantidad de Hamburguesas o -1 en caso de no haber comprado");
                Console.Write("#.Cantidad-> ");
                linea = Console.ReadLine();
                bool siConvert = byte.TryParse(linea, out byte numero);
                if (siConvert)
                {
                    CantidadH = numero; 
                    do {
                        precioH = precio();
                    }while(precioH == -1);
                    flag = false;
                }
                else 
                {
                    if (linea.CompareTo("-1") == 0)
                    {
                        flag = false;
                    } else { Console.WriteLine("Dato invalido, intente de nuevo"); flag = true; }
                }
            }while (flag);
            do
            {
                Console.WriteLine("\n#.Ingrese cantidad de Papas o -1 en caso de no haber comprado");
                Console.Write("#.Cantidad-> ");
                linea = Console.ReadLine();
                bool siConvert = byte.TryParse(linea, out byte numero);
                if (siConvert)
                {
                    CantidadP = numero;
                    do
                    {
                        precioP = precio();
                    } while (precioP == -1);
                    flag = false;
                }
                else
                {
                    if (linea.CompareTo("-1") == 0)
                    {
                        flag = false;
                    }
                    else { Console.WriteLine("Dato invalido, intente de nuevo"); flag = true; }
                }
            } while (flag);

            do
            {
                Console.WriteLine("\n#.Ingrese cantidad de Bebidas o -1 en caso de no haber comprado");
                Console.Write("#.Cantidad-> ");
                linea = Console.ReadLine();
                bool siConvert = byte.TryParse(linea, out byte numero);
                if (siConvert)
                {
                    CantidadB = numero;
                    do
                    {
                        precioB = precio();
                    } while (precioB == -1);
                    flag = false;
                }
                else
                {
                    if (linea.CompareTo("-1") == 0)
                    {
                        flag = false;
                    }
                    else Console.WriteLine("Dato invalido, intente de nuevo");
                }
            } while (flag);
            Resultado = ((double)CantidadH * precioH) + ((double)CantidadP * precioP) + ((double)CantidadB * precioB);
            Console.WriteLine("\n#.PRECIO FINAL: "+Resultado);
            Console.WriteLine("#.PRECIO FINAL: "+String.Format("{0:####.00}", Resultado));          //formatea el numero de manera que solo presente 2 digitos en la parte decimal y en caso de no tener parte entera imprima un 0
            Console.WriteLine("#.PRECIO FINAL: "+String.Format("{0:c}", Resultado));                //formatea el numero de manera que el primer caracter a representar sea un simbolo de moneda, en caso contrario devuelve un 0
            Console.WriteLine("#.PRECIO FINAL: "+String.Format("{0:g}", Resultado));                //formatea el numero de manera que lo convierta a la notación más compacta de punto fijo o científica ("rendondea"), caso contrario devuelve un 0 
            Console.WriteLine("#.Fecha: "+String.Format("{0:F}", DateTime.Now));                    //formatea la fecha en formato F (dia, mes, año, y hora), en caso de dato invalido muestra un 0
            Console.WriteLine("#.Fecha: "+String.Format(" {0:dddd}{0: dd/MM/yyy}", DateTime.Now));  //formatea la fecha obtenida del sistema en nombre de dia, dia/mes/año, en caso contrario muestra un 0 si no se pudo obtener o es invalida
        }
        static double precio()
        {
            double precio = 0;
            Console.Write("#.Ingrese precio por unidad #-> ");
            string linea = Console.ReadLine();
            bool siConvert = double.TryParse(linea, out double numero2);
            if (siConvert) { precio = numero2; } else { Console.WriteLine("Dato invalido, intente de nuevo"); precio = -1; }
            return precio;
        }
    }
}
