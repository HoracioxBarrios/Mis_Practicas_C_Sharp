
using Biblioteca;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca. Persona persona = new Persona();// ejemplo de uso de namespace (Biblioteca), en caso de tener dos proyectos que tengan una Class Persona cada uno con esto se especifica cual se va a usar.
            
            persona.Caminar();
        }
    }
}