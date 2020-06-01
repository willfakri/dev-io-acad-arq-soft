using System;
using InjecaoDependenciaDotNetCore.Model;

namespace InjecaoDependenciaDotNetCore.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            Console.WriteLine($"Info: ClienteRepository.AdicionarCliente({cliente})");
        }
    }
}