using System;
using InjecaoDependenciaDotNetCore.Business;
using InjecaoDependenciaDotNetCore.Model;

namespace InjecaoDependenciaDotNetCore
{
    class ConsoleApp
    {
        private readonly IClienteBusiness _clienteBusiness;
                
        public ConsoleApp(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        public void Run()
        {
            var cliente = new Cliente();
            Console.WriteLine("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            
            _clienteBusiness.AdicionarCliente(cliente);            
        }
    }
}