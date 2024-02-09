using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        private int _legajo;
        public Empleado(string nombre, string apellido) : base(nombre, apellido)
        {

        }
        public Empleado(string nombre, string apellido, int legajo) : base(nombre, apellido)

        {
            _legajo = legajo;

        }


        //public string Saludar()
        //{

        //    return $"Hola mi nombre es: {Nombre} y soy Enpleado";
        //}
        public virtual string Saludar()
        {
            return base.Saludar(Nombre);
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }

        }


    }


    
}
