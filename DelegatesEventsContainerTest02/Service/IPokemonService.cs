using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest02.Object;

namespace DelegatesEventsContainerTest02.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}