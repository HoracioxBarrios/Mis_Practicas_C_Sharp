using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Encargado: Empleado
    {

        public Encargado(string nombre, string apellido) : base (nombre, apellido) { }
        public Encargado(string nombre, string apellido, int legajo) :base(nombre, apellido, legajo) { }

        public override string Saludar()
        {

            return $"Hola mi nombre es: {Nombre} y soy Encargado";
        }
    }
}
