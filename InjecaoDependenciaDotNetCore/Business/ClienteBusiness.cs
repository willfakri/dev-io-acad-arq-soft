using System;
using InjecaoDependenciaDotNetCore.Model;
using InjecaoDependenciaDotNetCore.Repository;

namespace InjecaoDependenciaDotNetCore.Business
{
    public class ClienteBusiness : IClienteBusiness
    {        
        private readonly IClienteRepository _clienteRepository;
        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void AdicionarCliente(Cliente cliente)
        {
            Console.WriteLine($"Info: ClienteBusiness.AdionarCliente({cliente.Nome})");            
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}