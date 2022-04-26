using System;

namespace WEBAPI.Domain.Entities
{
    public class Cliente
    {

        public string Id { get; set; }

        public string Nome { get; set; }

        public string Password { get; set; }

        public DateTime? DataNascimeto { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Email { get; set; }


    }
}
