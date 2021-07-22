using Microsoft.EntityFrameworkCore;
using System.Data;
using tmsang.domain;

namespace tmsang.infra
{
    public class MemoryUnitOfWork : IUnitOfWork
    {
        public MemoryUnitOfWork()
        {

        }

        public void CommitTransaction()
        {
            // nothing to do
        }

        public void ForceBeginTransaction()
        {
            // nothing to do
        }

        public void RollbackTransaction()
        {
            // nothing to do
        }

        public int SaveChanges()
        {
            return 0;
        }

        public DbSet<T> Set<T>() where T : class
        {
            return null;
        }

        public void SetIsolationLevel(IsolationLevel isolationLevel)
        {
            // nothing to do
        }
    }
}
