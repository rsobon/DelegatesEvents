using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest01.Service;

namespace DelegatesEventsContainerTest01
{
    /*
     * PokemonService can be injected as new instance (TransientLifetime) or as singleton (ContainerController)
     * It will be disposed only after container disposes (when app closes)
     */
    public class Worker : IWorker
    {
        private readonly IPokemonService _pokemonService;

        public Worker(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
            Console.WriteLine("PokemonService Hash:" + _pokemonService.GetHashCode());
        }

        public async Task DoWork()
        {
            var pokemon = await _pokemonService.GetPokemonAsync("https://pokeapi.co/api/v2/pokemon/1/");
            Console.WriteLine(pokemon.Name);
        }
    }
}
