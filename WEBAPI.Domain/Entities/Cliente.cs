using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Domain.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual List<Compra> Compras { get; set; }


    }
}
