using System;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;
using DelegatesEventsContainerTest05.Service;

namespace DelegatesEventsContainerTest05
{
    /*
     * DelegatesEventsContainerTest04 with autofac
     */
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PokemonService>().As<IPokemonService>();
//            builder.Register<Func<IPokemonService>>(c =>
//            {
//                var componentContext = c.Resolve<IComponentContext>();
//                return () =>
//                {
//                    var instance = componentContext.Resolve<IPokemonService>();
//                    return instance;
//                };
//            });
            builder.RegisterType<Worker>().As<IWorker>();
            builder.Register(c => new HttpClient()).As<HttpClient>();

            var container = builder.Build();

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
