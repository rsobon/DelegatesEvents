using System;
using System.Threading.Tasks;
using ObserverPattern01.Service;

namespace ObserverPattern01
{
    public class Worker : IWorker
    {
        public event EventHandler<PokemonFetchedEventArgs> PokemonFetchedEvent;

        private readonly IPokemonService _pokemonService;

        public Worker(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        public async Task DoWork()
        {
            int pokeCount = 5;

            for (int i = 1; i <= pokeCount; i++)
            {
                var pokemon = await _pokemonService.GetPokemonAsync("https://pokeapi.co/api/v2/pokemon/" + i);
                PokemonFetchedEvent?.Invoke(this, new PokemonFetchedEventArgs(pokemon));
            }
        }
    }
}
