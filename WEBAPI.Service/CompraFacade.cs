using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.DTO;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Repositories.Interfaces;
using WEBAPI.Service.Interfaces;

namespace WEBAPI.Service
{
    public class CompraFacade : ICompraFacade
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IEmailFacade _emailFacade;
        private readonly IClienteFacade _clienteFacade;
        private readonly IMapper Mapper;

        public CompraFacade(ICompraRepository compraRepository, 
                            IEmailFacade emailFacade, 
                            IClienteFacade clienteFacade, 
                            IMapper mapper)
        {
            _compraRepository = compraRepository;
            _emailFacade = emailFacade;
            _clienteFacade = clienteFacade;
            Mapper = mapper;
        }
        public Compra CreateCompra(CompraRequestDTO request)
        {
            var compra = Mapper.Map<Compra>(request);
            var result = _compraRepository.CreateCompra(compra);
            var cliente = _clienteFacade.GetCliente(request.ClienteId);
            _emailFacade.SendEmail(compra, cliente.Email);
            return result; 
        }
    }
}
