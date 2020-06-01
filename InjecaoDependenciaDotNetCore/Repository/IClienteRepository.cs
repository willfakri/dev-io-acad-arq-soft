using InjecaoDependenciaDotNetCore.Model;

namespace InjecaoDependenciaDotNetCore.Repository
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
}