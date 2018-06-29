using System;
using System.Collections.Generic;
using ProjetoCore.Entities;

namespace ProjetoCore.Web.ViewModels
{
    public class PaisEstadoViewModel
    {
        public Pais Pais{get; set;}
        public List<Estado> Estados {get; set;}
    }
}