using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest03.Service;
using Unity;

namespace DelegatesEventsContainerTest03
{
    /*
     * Only one instance of Worker which executes DoWork() twice. Each time new PokemonService and HttpClient will be created.
     * Demonstrates how to create new instance of PokemonService in runtime using custom factory.
     */
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IPokemonService, PokemonService>();
//            container.RegisterType<IPokemonService, PokemonService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPokemonServiceFactory, PokemonServiceFactory>();
            container.RegisterType<IWorker, Worker>();

            var worker = container.Resolve<IWorker>();
            Console.WriteLine("First DoWork");
            await worker.DoWork();

            Console.WriteLine("Waiting...");
            await Task.Delay(4000);

            Console.WriteLine("Second DoWork");
            await worker.DoWork();

            Console.ReadKey();
        }
    }
}
