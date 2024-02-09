using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario : ISaludar
    {
        private string _nombre;
        public Usuario(string nombre) { }

        public void Saludar()
        {
            Console.WriteLine("Hola soy padre"); 
        }
    }
}
