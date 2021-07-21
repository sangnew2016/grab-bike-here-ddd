using tmsang.domain;

namespace tmsang.infra.UnitOfWork
{
    public class MysqlUnitOfWork: IUnitOfWork
    {
        private readonly MysqlDbContext _dbContext;

        public MysqlUnitOfWork(MysqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            //... do something here to save
            _dbContext.SaveChanges();
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
