using Unity;

namespace DelegatesEventsContainerTest03.Service
{
    public class PokemonServiceFactory : IPokemonServiceFactory
    {
        private readonly IUnityContainer _container;

        public PokemonServiceFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IPokemonService GetPokemonService()
        {
            return _container.Resolve<IPokemonService>();
        }
    }
}
