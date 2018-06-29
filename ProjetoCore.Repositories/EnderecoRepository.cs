using System;
using ProjetoCore.Entities;
using ProjetoCore.Entities.Base;
using ProjetoCore.Repositories.Base;

namespace ProjetoCore.Repositories
{
    public class EnderecoRepository : Repository<Endereco>
    {
        public EnderecoRepository(ProjetoCoreDbContext dbContext)
            : base(dbContext)
        {}
    }
}