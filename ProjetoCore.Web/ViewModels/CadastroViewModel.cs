using System;
using System.Collections.Generic;
using ProjetoCore.Entities;

namespace ProjetoCore.Web.ViewModels
{
    public class CadastroViewModel
    {
        public List<Pais> Paises { get; set; }
        public List<Estado> Estados{get; set;}
        public List<Cidade> Cidades {get; set;}
        public Endereco Endereco { get; set; }  
    }
}