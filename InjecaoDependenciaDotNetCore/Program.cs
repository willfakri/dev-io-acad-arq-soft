using System;
using Microsoft.Extensions.DependencyInjection;
using InjecaoDependenciaDotNetCore.Business;
using InjecaoDependenciaDotNetCore.Repository;

namespace InjecaoDependenciaDotNetCore
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            Console.WriteLine("INICIO!");

            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<ConsoleApp>().Run();
            DisposeServices();
            
            Console.WriteLine("FIM!");
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IClienteBusiness, ClienteBusiness>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddSingleton<ConsoleApp>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

         private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
