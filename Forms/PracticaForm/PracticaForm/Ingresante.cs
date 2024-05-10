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
        private string cuit = "";
        private int edad = 0;
        private string pais = "";
        private string[] curso;

        public Ingresante(string nombre, string genero, string direccion, int edad, string pais, string[] curso, string cuit)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Pais = pais;
            this.Curso1 = curso;
            this.Cuit = cuit;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => Curso1; set => Curso1 = value; }
        public string[] Curso1 { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nDireccion: " + direccion +"\nGenero: "+genero+ "\nEdad: "+edad+"\nCuit: "+cuit+"\nPaís: "+pais;
        }

        public string ToStringCursos()
        {
            return "Cursos selecionados: \n" + curso[0] + "\n" + curso[1] + "\n" + curso[2]; 
        }

    }
}
