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
        private string libroPrestado;
        private string nombreDeLector;

        public Prestamo(string fechaPrestamo, string fechaDevolucion, string nombreLibro, string nombreLector)
        {
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            LibroPrestado = nombreLibro;
            NombreDeLector = nombreLector;
        }

        public string FechaPrestamo { get => fechaPrestamo; private set => fechaPrestamo = value; }
        public string FechaDevolucion { get => fechaDevolucion;  private set => fechaDevolucion = value; }
        public string LibroPrestado { get => libroPrestado; private set => libroPrestado = value; }
        public string NombreDeLector { get => nombreDeLector; private set => nombreDeLector = value; }
    }
}
