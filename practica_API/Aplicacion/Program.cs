using Biblioteca;
using System;
namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new ApiService();
            var pokemonData = pokemon.GetData<dynamic>("pikachu").Result;

            Console.WriteLine(pokemonData.species.name);
        }
    }
}