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
        private ICompraRepository _compraRepository;
        private readonly IMapper Mapper;
        public CompraFacade(ICompraRepository compraRepository, IMapper mapper)
        {
            _compraRepository = compraRepository;
            Mapper = mapper;
        }
        public Compra CreateCompra(CompraRequestDTO request)
        {
            var compra = Mapper.Map<Compra>(request);
            var result = _compraRepository.CreateCompra(compra);
            return result; 
        }
    }
}
