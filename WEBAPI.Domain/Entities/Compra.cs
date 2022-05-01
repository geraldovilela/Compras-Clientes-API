using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.Domain.Entities
{
    public class Compra
    {
       
        [Key]
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        [Required]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public string Preco { get; set; }
        
        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }
        

    }
}
