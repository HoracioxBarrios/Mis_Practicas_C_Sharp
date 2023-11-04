using Biblioteca;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de interfaz Implicita
            Usuario user = new Usuario("Kio");
            user.Saludar();
            Empleado empleado = new Empleado("Ryu");
            empleado.Saludar();

        }
    }
}