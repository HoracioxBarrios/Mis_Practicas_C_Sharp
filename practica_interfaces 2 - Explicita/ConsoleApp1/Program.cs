using Biblioteca;

namespace Aplicacion

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario("Messi");
            Console.WriteLine(user.Nombre);


            //Interface explicita 
            ISaludarUno saludar = user;

            string saludo = saludar.Saludar();

            Console.WriteLine(saludo);



            ISaludarDos saludarDos = user;

            saludarDos.Saludar();

        }
    }
}