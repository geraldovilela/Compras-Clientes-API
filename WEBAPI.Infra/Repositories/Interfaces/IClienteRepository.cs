using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Infra.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> GetAllClientes();
    }
}
