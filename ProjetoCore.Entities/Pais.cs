using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCore.Entities
{
    [Table("Paises")]
    public class Pais
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(5)]
        public string Codigo { get; set; }

        public List<Estado> Estado {get; set;}
    }
}
