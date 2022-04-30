using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEBAPI.Domain.DTO;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Repositories;
using WEBAPI.Service.Interfaces;

namespace WEBAPI.Service
{
    public class ClienteFacade : IClienteFacade
    {
        private IClienteRepository _clienteRepository;
        private readonly IMapper Mapper;
        public ClienteFacade(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            Mapper = mapper;
        }

        public ClienteResponseDTO GetCliente(Guid request)
        {
            var result = _clienteRepository.GetCliente(request);
            var response = Mapper.Map<ClienteResponseDTO>(result);
            return response;

        }

        public List<ClienteDTO> GetAllClientes()
        {
            var result = _clienteRepository.GetAllClientes();
            var response = Mapper.Map<List<ClienteDTO>>(result);
            return response;
            
        }

        public ClienteDTO CreateCliente(ClienteRequestDTO request)
        {
            var cliente = Mapper.Map<Cliente>(request);
            var result = _clienteRepository.CreateCliente(cliente);
            var response = Mapper.Map<ClienteDTO>(result);
            return response;
        }

    }
}
