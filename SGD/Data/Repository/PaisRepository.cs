using Microsoft.EntityFrameworkCore;
using SGD.Data.Interfaces;
using SGD.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGD.Data.Repository
{
    public class PaisRepository : Generic<Pais>, IPaisRepository
    {
        private readonly DbContextOptions<AppDbContext> _OptionsBuilder;
        public PaisRepository()
        {
            _OptionsBuilder = new DbContextOptions<AppDbContext>();
        }

        public Task<List<Pais>> ListarTodosAscDescAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
