using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Data;

namespace WEBAPI.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private AppDBContext _dbCotnext;

        public ClienteRepository(AppDBContext dbContext)
        {
            _dbCotnext = dbContext;
        }
        public List<Cliente> GetAllClientes()
        {
            var result = _dbCotnext.Clientes.ToList();
            return result;
        }

        public Cliente CreateCliente(Cliente request)
        {
            _dbCotnext.Clientes.Add(request);
            _dbCotnext.SaveChanges();
            return request;
        }
    }
}
