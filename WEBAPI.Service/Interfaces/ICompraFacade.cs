using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.DTO;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Service.Interfaces
{
    public interface ICompraFacade
    {
        Compra CreateCompra(CompraRequestDTO request);
    }
}
