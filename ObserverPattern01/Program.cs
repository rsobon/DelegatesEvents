using System;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;
using ObserverPattern01.Service;

namespace ObserverPattern01
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PokemonService>().As<IPokemonService>();
            builder.RegisterType<Worker>().As<IWorker>().SingleInstance();
            builder.RegisterType<ObserverWorker>().As<IObserverWorker>();
            builder.Register(c => new HttpClient()).As<HttpClient>();
            var container = builder.Build();

            var worker = container.Resolve<IWorker>();
            var observer = container.Resolve<IObserverWorker>();
            Task.Run(worker.DoWork);

            Console.ReadKey();
        }
    }
}
