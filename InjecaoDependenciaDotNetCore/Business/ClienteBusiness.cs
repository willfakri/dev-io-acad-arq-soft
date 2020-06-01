using System;
using InjecaoDependenciaDotNetCore.Model;
using InjecaoDependenciaDotNetCore.Repository;

namespace InjecaoDependenciaDotNetCore.Business
{
    public class ClienteBusiness : IClienteBusiness
    {        
        public void AdicionarCliente(Cliente cliente)
        {
            Console.WriteLine($"Info: ClienteBusiness.AdionarCliente({cliente.Nome})");
            var clienteRepository = new ClienteRepository();
            clienteRepository.AdicionarCliente(cliente);
        }
    }
}