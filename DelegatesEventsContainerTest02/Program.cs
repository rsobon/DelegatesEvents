using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest02.Service;
using Unity;

namespace DelegatesEventsContainerTest02
{
    /*
     * Only one instance of Worker which executed DoWork twice. Each time the same PokemonService and HttpClient is re-used.
     * Demonstrates a problem of disposable resource (PokemonService) that is never disposed because it has per-instance lifetime.
     */
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IPokemonService, PokemonService>();
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
