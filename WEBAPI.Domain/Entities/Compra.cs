using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.Domain.Entities
{
    public class Compra
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public DateTime? CriadoEm { get; set; }

        public string Preco { get; set; }
    }
}
