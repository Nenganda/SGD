using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using SGD.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SGD.Data.Repository
{
    public class Generic<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<AppDbContext> _OptionsBuilder;
        public Generic()
        {
            _OptionsBuilder = new DbContextOptions<AppDbContext>();
        }

        public async Task AtualizarAsync(T entity)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                data.Set<T>().Update(entity);
                await data.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<T>> BuscarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CadastrarAsync(T entity)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(entity);
                await data.SaveChangesAsync();
            }
        }

        public Task ExcluirAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> ListarTodosAsync()
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task<T> PesquisarPorIdAsync(int id)
        {
            using (var data = new AppDbContext(_OptionsBuilder))
            {
                return await data.Set<T>().FindAsync(id);
            }
        }

        public int Quantidade(Func<T, bool> predicado)
        {
            throw new NotImplementedException();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        //Flag: Has Dispose already been called?
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        //Public implentation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                //Free  any other managed object here.
            }

            disposed = true;
        }
        #endregion
    }
}

