using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCore.Entities;
using ProjetoCore.Entities.Base;
using ProjetoCore.Repositories.Interfaces.Base;

namespace ProjetoCore.Repositories.Base
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly ProjetoCoreDbContext _dbContext;

        public Repository(ProjetoCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<T>> Pesquisar()
        {
            return await _dbContext.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }
        
        public async Task<List<T>> Pesquisar(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>()
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task Adicionar(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task Editar(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Excluir(Func<T, bool> predicate)
        {
            _dbContext.Set<T>()
                .Where(predicate).ToList()
                .ForEach(x => _dbContext.Set<T>().Remove(x));
            await _dbContext.SaveChangesAsync();
        }
    }
}
