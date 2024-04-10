namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la base del triangulo");
            String x= Console.ReadLine();
            Console.WriteLine("Ingrese la altura del triangulo");
            String y = Console.ReadLine();

            double Base = double.Parse(x), Altura = double.Parse(y), resultado;

            double hipotenusa = Math.Pow(Altura,2) + Math.Pow(Base,2);
            hipotenusa = Math.Sqrt(hipotenusa);

            double area = (Base * Altura)/2;

            String linea = String.Format("{0:####.00}", hipotenusa);
            Console.WriteLine("Hipotenusa = " + linea);
            linea = String.Format("{0:####.00}", area);
            Console.WriteLine("Area = " + linea);
            

           
        }
    }
}
