using System;
using InjecaoDependenciaDotNetCore.Business;
using InjecaoDependenciaDotNetCore.Model;

namespace InjecaoDependenciaDotNetCore
{
    class ConsoleApp
    {
        //private readonly ICustomer _customer;
        
        //public ConsoleApp(ICustomer customer)
        public ConsoleApp()
        {
            //_customer = customer;
        }

        public void Run()
        {
            var cliente = new Cliente();
            Console.WriteLine("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            var clienteBusiness = new ClienteBusiness();
            clienteBusiness.AdicionarCliente(cliente);
            //_customer.CreateCustomer(); 
        }
    }
}