using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Data;
using WEBAPI.Infra.Repositories.Interfaces;

namespace WEBAPI.Infra.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private AppDBContext _dbCotnext;
        public CompraRepository(AppDBContext dbContext)
        {
            _dbCotnext = dbContext;
        }

        public Compra CreateCompra(Compra request)
        {
            _dbCotnext.Compras.Add(request);
            _dbCotnext.SaveChanges();

            return request;
        }
    }
}
