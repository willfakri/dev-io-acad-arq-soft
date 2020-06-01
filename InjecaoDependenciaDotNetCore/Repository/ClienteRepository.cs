using System;
using InjecaoDependenciaDotNetCore.Model;

namespace InjecaoDependenciaDotNetCore.Repository
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            Console.WriteLine($"Info: ClienteRepository.AdicionarCliente({cliente})");
        }
    }
}