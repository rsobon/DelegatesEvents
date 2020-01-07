using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest05.Object;

namespace DelegatesEventsContainerTest05.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}