using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Estudiante
    {
        private string nombre;
        private string apellido;
        private byte edad;
        private uint añoIngreso;

        public Estudiante(string nombre, string apellido, byte edad, uint añoIngreso)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.AñoIngreso = añoIngreso;
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        public string Apellido { get => apellido; private set => apellido = value; }
        public byte Edad { get => edad; private set => edad = value; }
        public uint AñoIngreso { get => añoIngreso; private set => añoIngreso = value; }


        public static double calcularPromedioEdad(byte edad1, byte edad2)
        {
            return (edad1+edad2)/2;
        }

        public string toString()
        {
            return "Nombre: "+Nombre+"\nApellido: "+Apellido+"\nEdad: "+Edad+"\nAño de Ingreso: "+AñoIngreso;
        }
    }
}
