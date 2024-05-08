using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForm
{
    internal class Ingresante
    {
        private string nombre = "";
        private string genero = "";
        private string direccion = "";
        private int edad = 0;
        private string pais = "";
        private string[] curso;

        public Ingresante(string nombre, string genero, string direccion, int edad, string pais)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Pais = pais;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
