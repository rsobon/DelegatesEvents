namespace ObserverPattern01
{
    public interface IObserverWorker
    {
        void PokemonFetchedEventHandler(PokemonFetchedEventArgs args);
    }
}