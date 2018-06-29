using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCore.Entities
{
    [Table("Estados")]
    public class Estado
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(2)]
        public string Sigla { get; set; }
        [MaxLength(5)]
        public string Codigo { get; set; }
        [ForeignKey("Pais")]
        public int PaisId{get; set;}
        public Pais Pais{get; set;}

        public List<Cidade> Cidade {get; set;}
    }
}