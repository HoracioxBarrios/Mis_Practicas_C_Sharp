using Biblioteca;

namespace Aplicacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona humano = new Persona("Garen");
            //humano.Apellido = "Noxus";

            //Console.WriteLine(humano.Nombre);
            //Console.WriteLine(humano.Apellido);
            //string mensaje = humano.Saludar("Hola soy un mensj personalizado");

            //Console.WriteLine(mensaje);
            Empleado empleado = new Empleado("Pepe", "Argento");
            
            Console.WriteLine(empleado.Saludar());

            Encargado encargado = new Encargado("Ale", "Bleik", 1015);
            Console.WriteLine(encargado.Saludar());

        }
    }
}