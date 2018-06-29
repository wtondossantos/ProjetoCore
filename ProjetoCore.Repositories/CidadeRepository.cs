using System;
using ProjetoCore.Entities;
using ProjetoCore.Entities.Base;
using ProjetoCore.Repositories.Base;

namespace ProjetoCore.Repositories
{
    public class CidadeRepository : Repository<Cidade>
    {
        public CidadeRepository(ProjetoCoreDbContext dbContext)
            : base(dbContext)
        {}
    }
}