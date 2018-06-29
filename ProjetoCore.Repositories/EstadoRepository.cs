using System;
using ProjetoCore.Entities;
using ProjetoCore.Entities.Base;
using ProjetoCore.Repositories.Base;

namespace ProjetoCore.Repositories
{
    public class EstadoRepository : Repository<Estado>
    {
        public EstadoRepository(ProjetoCoreDbContext dbContext)
            : base(dbContext)
        {}
        
    }
}