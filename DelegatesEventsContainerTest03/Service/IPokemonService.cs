using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest03.Object;

namespace DelegatesEventsContainerTest03.Service
{
    public interface IPokemonService : IDisposable
    {
        Task<Pokemon> GetPokemonAsync(string uri);
    }
}