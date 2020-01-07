using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest01.Service;
using Unity;

namespace DelegatesEventsContainerTest01
{
    /*
     * Demonstrates difference between per-instance lifetime and per-container lifetime
     */
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IPokemonService, PokemonService>();
//            container.RegisterType<IPokemonService, PokemonService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IWorker, Worker>();

            var worker = container.Resolve<IWorker>();
            Console.WriteLine("Worker Hash: " + worker.GetHashCode());
            await worker.DoWork();

            var worker2 = container.Resolve<IWorker>();
            Console.WriteLine("Worker Hash: " + worker2.GetHashCode());
            await worker2.DoWork();

            Console.ReadKey();
        }
    }
}
