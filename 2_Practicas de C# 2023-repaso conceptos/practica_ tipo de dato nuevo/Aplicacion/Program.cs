using Biblioteca;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Direccion direccion = new Direccion
            {

                Ciudad = "BsAs",
                Calle = "San Martin",
                Estado = "Calzada",
                CodigoPostal = "1847"

            };


            //Console.WriteLine(direccion.GetType());

            Persona persona = new Persona("Sio", direccion);
            //Console.WriteLine(persona.ToString());
            Console.WriteLine(persona.ToString());

        }
    }
}