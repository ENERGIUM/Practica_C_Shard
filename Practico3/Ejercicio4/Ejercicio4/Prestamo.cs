using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Prestamo
    {
        private string fechaPrestamo;
        private string fechaDevolucion;
        private Libro libroPrestado;
        private string nombreDeLector;

        public Prestamo(string fechaPrestamo, string fechaDevolucion, Libro libroPrestado, string nombreLector)
        {
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            LibroPrestado = libroPrestado;
            NombreDeLector = nombreLector;
        }

        public string FechaPrestamo { get => fechaPrestamo; private set => fechaPrestamo = value; }
        public string FechaDevolucion { get => fechaDevolucion;  private set => fechaDevolucion = value; }
        public Libro LibroPrestado { get => libroPrestado; private set => libroPrestado = value; }
        public string NombreDeLector { get => nombreDeLector; private set => nombreDeLector = value; }
    }
}
