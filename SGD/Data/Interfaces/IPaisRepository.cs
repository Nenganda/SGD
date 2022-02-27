using SGD.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGD.Data.Interfaces
{
    public interface IPaisRepository : IGeneric<Pais>
    {
        Task<List<Pais>> ListarTodosAscDescAsync();
    }
}
