using System;
using Biblioteca;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca.Persona persona = new Biblioteca.Persona();

            persona.Caminar();

            Color negro = Color.Negro;
            Console.WriteLine(negro);
        }
    }
}
