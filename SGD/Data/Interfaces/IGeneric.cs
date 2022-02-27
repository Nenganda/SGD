using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGD.Data.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        Task<List<T>> ListarTodosAsync();
        Task<IEnumerable<T>> BuscarTodosAsync();
        Task<T> PesquisarPorIdAsync(int id);
        int Quantidade(Func<T, bool> predicado);
        Task CadastrarAsync(T entity);
        Task AtualizarAsync(T entity);
        Task ExcluirAsync(T entity);
    }
}
