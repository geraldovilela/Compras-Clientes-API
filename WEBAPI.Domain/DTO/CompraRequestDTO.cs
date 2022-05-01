using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Domain.DTO
{
    public class CompraRequestDTO
    {
        public string Descricao { get; set; }

        public string Preco { get; set; }

        public Guid ClienteId { get; set; }
    }
}
