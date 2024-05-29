using System.Xml.Schema;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            String SuNombre = Console.ReadLine();

            byte k = (byte)SuNombre.Length;

            Console.WriteLine("La LONGITUD de su nombre es: " + k);

            if (SuNombre.Contains("le")) {
                Console.WriteLine("La sibala 'le' ESTA DENTRO de su nombre");
            }else {
                Console.WriteLine("La sibala 'le' No ESTA DENTRO de su nombre");}

            Console.WriteLine("REEMPLAZO DE VOCAL A por b: " + SuNombre.ToLower().Replace('a', 'b'));
            Console.WriteLine("MINUSCULAS: " + SuNombre.ToLower());
            Console.WriteLine("MINUSCULAS: " + SuNombre.ToUpper());
            String resultado = SuNombre.Remove(SuNombre.Length-4, 4);
            Console.WriteLine("REMOVEMOS 4 LETRAS: " + resultado);
            Console.WriteLine("EXTRAEMMOS ultimas 4 LETRAS: " + SuNombre.Substring(SuNombre.Length - 4));
            Console.WriteLine("Recorremos los caracteres desde la Izquierda: ");
            recorrerCharIzq(SuNombre);
            Console.WriteLine("Recorremos los caracteres desde la derecha: ");
            recorrerCharDer(SuNombre);
        }


       
        public static void recorrerCharIzq(string param)
        {
            String salida = " ";
            for(int i=0; i<param.Length; i++)
            {
                salida = salida + param.Substring(i, 1);
                Console.WriteLine(salida);

            } 
        }

        public static void recorrerCharDer(string param)
        {
            String salida = " ";
            for (int i = param.Length-1; i >=0; i--)
            {
                salida = param.Substring(i, 1) + salida;
                Console.WriteLine(salida);

            }
        }
    }
}
