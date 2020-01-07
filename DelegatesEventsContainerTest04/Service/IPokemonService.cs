using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest04.Object;

namespace DelegatesEventsContainerTest04.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}