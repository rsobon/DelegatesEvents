using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest01.Object;

namespace DelegatesEventsContainerTest01.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}