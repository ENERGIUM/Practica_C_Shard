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
        private uint ejemplares;
        private uint ejemplaresDisponibles;
        private uint ejemplaresRetirados;

        public Libro(string tit, string aut, ulong isbn, string gen, uint num)
        {
            Titulo = tit;
            Autor = aut;
            Isbn = isbn;
            Genero = gen;
            Ejemplares = num;
            EjemplaresDisponibles = num;
        }

        public string Titulo { get => titulo; private set => titulo = value; }
        public string Autor { get => autor; private set => autor = value; }
        public ulong Isbn { get => isbn; private set => isbn = value; }
        public string Genero { get => genero; private set => genero = value; }
        public uint Ejemplares { get => ejemplares; private set => ejemplares = value; }
        public uint EjemplaresDisponibles { get => ejemplaresDisponibles; set => ejemplaresDisponibles = value; }
        public uint EjemplaresRetirados { get => ejemplaresRetirados; set => ejemplaresRetirados = value; }

        public override string ToString()
        {
            return "\nTitulo: " + titulo + "\nAutor: " + autor + "\nIsbn: " + isbn + "\nGenero: " + genero + "\nEjemplares: " + ejemplares + "\nEjemplaresDisponibles: " + ejemplaresDisponibles;
        }

        public string ToString2()
        {
            return "\nTitulo: " + titulo + "\nAutor: " + autor + "\nIsbn: " + isbn + "\nGenero: " + genero + "\nEjemplaresRetirados: " + ejemplaresRetirados;
        }
    }
}
