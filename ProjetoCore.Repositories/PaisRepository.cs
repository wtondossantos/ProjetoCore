using System;
using ProjetoCore.Entities;
using ProjetoCore.Entities.Base;
using ProjetoCore.Repositories.Base;

namespace ProjetoCore.Repositories
{
    public class PaisRepository : Repository<Pais>
    {
        public PaisRepository(ProjetoCoreDbContext dbContext)
            : base(dbContext)
        {}
    }
}