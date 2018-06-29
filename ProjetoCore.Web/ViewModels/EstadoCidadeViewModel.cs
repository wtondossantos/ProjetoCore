using System;
using System.Collections.Generic;
using ProjetoCore.Entities;

namespace ProjetoCore.Web.ViewModels
{
    public class EstadoCidadeViewModel
    {
        public Estado Estado{get; set;}
        public List<Cidade> Cidades {get; set;}
    }
}