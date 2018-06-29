using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCore.Entities
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Logradouro { get; set; }
        [ForeignKey("Cidade")]
        public int CidadeId{get; set;}
        public Cidade Cidade{get; set;}
    }
}