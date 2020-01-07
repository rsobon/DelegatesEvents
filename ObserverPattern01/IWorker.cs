using System;
using System.Threading.Tasks;

namespace ObserverPattern01
{
    public interface IWorker
    {
        event EventHandler<PokemonFetchedEventArgs> PokemonFetchedEvent;

        Task DoWork();
    }
}