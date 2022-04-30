using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Domain.DTO
{
    public class ClienteResponseDTO
    {
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Email { get; set; }

        public List<Compra> Compras { get; set; }
    }
}
