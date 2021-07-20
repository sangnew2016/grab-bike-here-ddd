using System;
using tmsang.domain;

namespace tmsang.infra
{
    public class MemoryUnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            //... do something here to save
            
        }

        public void Dispose()
        {
            // do something here to dispose

        }

        public void Rollback()
        {
            // do something here -> to rollback

        }
    }
}
