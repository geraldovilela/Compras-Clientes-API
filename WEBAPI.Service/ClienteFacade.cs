using System.Collections.Generic;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Repositories;
using WEBAPI.Service.Interfaces;

namespace WEBAPI.Service
{
    public class ClienteFacade : IClienteFacade
    {
        private IClienteRepository _clienteRepository;
        public ClienteFacade(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> getAllClientes()
        {
            var result = _clienteRepository.GetAllClientes();
            return result;
            
        }
    }
}
