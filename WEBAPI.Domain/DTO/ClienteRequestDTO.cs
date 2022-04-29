using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.Domain.DTO
{
    public class ClienteRequestDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
