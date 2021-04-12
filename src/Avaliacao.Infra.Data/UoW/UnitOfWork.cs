using Avaliacao.Infra.Data.Context;
using Avaliacao.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AvaliacaoContext _context;
        private bool _disposed;
        public UnitOfWork(AvaliacaoContext context)
        {
            _context = context;
        }
        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
