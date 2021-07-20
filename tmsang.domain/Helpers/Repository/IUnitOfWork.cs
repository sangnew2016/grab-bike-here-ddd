using System;

namespace tmsang.domain
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
        void Rollback();
    }
}
