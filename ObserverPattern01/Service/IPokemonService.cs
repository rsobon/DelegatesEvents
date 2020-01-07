using System;
using System.Threading.Tasks;
using ObserverPattern01.Object;

namespace ObserverPattern01.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}