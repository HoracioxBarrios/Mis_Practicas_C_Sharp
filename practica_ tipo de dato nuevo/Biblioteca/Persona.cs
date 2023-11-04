using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private Direccion _direccion;
        private string _nombre;

        public Persona(string nombre, Direccion direccion)
        {
            _nombre = nombre;
            _direccion = direccion;
        }

        public Direccion Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        //sobrecarga del metodo de la clase cosmica
        public override string ToString()
        {
            // Define cómo quieres que se vea la representación de la persona como cadena
            return $"Nombre: {_nombre}, Dirección: {_direccion} ";
        }
    }
}
