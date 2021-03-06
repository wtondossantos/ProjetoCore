using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoCore.Entities;
using ProjetoCore.Repositories;
using ProjetoCore.Repositories.Interfaces;
using.ProjetoCore.Web.ViewModels;

namespace ProjetoCore.Web.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            var pais = new List<Pais>{
                new Pais{
                    Id = 1,
                    Nome = "Brasil",
                    Codigo = 55}
            };
            var estado = new List<Estado>{
                new Estado{
                    Id = 1,
                    Nome = "São Paulo",
                    Sigla = "SP",
                    Codigo = 21,
                    Pais = pais}
            };
            var cidade = new List<Cidade>{
                new Cidade{
                    Id = 1,
                    Nome = "São Paulo",
                    Codigo = 20,
                    Estado = estado}
            };
            var endereco = new Endereco{
                Id = 1,
                Rua = "Rua Itararé",
                Cidade = cidade
            };
            
            var viewModel = new CadastroViewModel{
                Endereco = endereco
            };

            return View(endereco);//_endereco.Pesquisar());
        }
    }
}