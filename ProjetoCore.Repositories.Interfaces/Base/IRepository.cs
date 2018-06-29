using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoCore.Repositories.Interfaces.Base
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<List<T>> Pesquisar();
        Task<List<T>> Pesquisar(Expression<Func<T, bool>> predicate);
        Task Adicionar(T entity);
        Task Editar(T entity);
        Task Excluir(Func<T, bool> predicate);
    }
}
