using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokedexPersistance.Entities;

namespace PokedexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Whose this pokemon?");

            pokedexContext context = new pokedexContext();
            
            IEnumerable<Pokemon> pokemons = context.Pokemons
                .AsNoTracking()
                .Include(x => x.PokemonTypes)
                    .ThenInclude(x => x.Type);

            foreach (Pokemon pokemon in pokemons)
            {
                if (pokemon.Id < 3)
                {
                    Console.WriteLine($"{pokemon.Identifier}");
                }
            }


            //IEnumerable<PokedexPersistance.Entities.Type> types = context.Types.AsNoTracking();
            //foreach (PokedexPersistance.Entities.Type type in types)
            //{
            //    Console.WriteLine(type.Identifier);
            //}
        }
    }
}
