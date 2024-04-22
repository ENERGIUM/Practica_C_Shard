using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private ulong isbn;
        private string genero;
        private uint ejemplaresDisponibles;

        public Libro(string tit, string aut, ulong isbn, string gen, uint num)
        {
            Titulo = tit;
            Autor = aut;
            Isbn = isbn;
            Genero = gen;
            EjemplaresDisponibles = num;
        }

        public string Titulo { get => titulo; private set => titulo = value; }
        public string Autor { get => autor; private set => autor = value; }
        public ulong Isbn { get => isbn; private set => isbn = value; }
        public string Genero { get => genero; private set => genero = value; }
        public uint EjemplaresDisponibles { get => ejemplaresDisponibles;  private set => ejemplaresDisponibles = value; }
    }
}
