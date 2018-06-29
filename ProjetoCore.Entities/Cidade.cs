using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCore.Entities
{
    [Table("Cidades")]
    public class Cidade
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [MaxLength(5)]
        public string Codigo { get; set; }
        [ForeignKey("Estado")]
        public int EstadoId{get; set;}
        public Estado Estado{get; set;}

        public List<Endereco> Endereco {get; set;}
    }
}