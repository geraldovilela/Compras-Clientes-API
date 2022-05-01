using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Infra.Repositories.Interfaces
{
    public interface ICompraRepository
    {
        Compra CreateCompra(Compra Request);
    }
}
