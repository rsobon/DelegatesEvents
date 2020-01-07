using System;
using System.Linq;

namespace ObserverPattern01
{
    public class ObserverWorker : IObserverWorker
    {
        private readonly string _handledType = "grass";

        public ObserverWorker(IWorker worker)
        {
            worker.PokemonFetchedEvent += (sender, args) => PokemonFetchedEventHandler(args);
        }

        public void PokemonFetchedEventHandler(PokemonFetchedEventArgs args)
        {
            var pokemon = args.Pokemon;
            if (pokemon.Types.Any(t => t.Type.Name == _handledType))
            {
                Console.WriteLine("Fetched grass pokemon: "+ args.Pokemon.Name);
            }
        }
    }
}
