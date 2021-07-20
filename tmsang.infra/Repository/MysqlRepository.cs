using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tmsang.domain;

namespace tmsang.infra
{
    /*
        1. Download Packages: 
            Microsoft.EntityFrameworkCore (v5.0.0 – the latest stable version)
            Microsoft.EntityFrameworkCore.Tools (v5.0.0 – the latest stable version)
            Pomelo.EntityFrameworkCore.MySql (version 5.0.0-alpha.2)
        2. Can co mot class quan ly Dbset va DbContext
        3. Can dang ky [dbcontext, connection] tren ConfigureServices
        4. Can tao mot class Repository de thao lieu - voi su tham du cua class dbContext


     */

    public class MysqlRepository<T>: IRepository<T> where T : IAggregateRoot
    {
        private MysqlDbContext mysqlDbContext;

        public MysqlRepository(MysqlDbContext mysqlDbContext)
        {
            this.mysqlDbContext = mysqlDbContext;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T FindOne(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
