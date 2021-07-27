using Microsoft.EntityFrameworkCore;
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

            // _unitOfWork.SaveChanges();
            // Khong can saveChange o day, vi API ho tro FilterAction, chan cuoi Request, neu OK, no thuc hien SaveChange , roi Commit.

     */

    public class MyRepository<T>: IRepository<T> where T : class, IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;
        private DbSet<T> table = null;

        public MyRepository()
        {
            
        }
        public MyRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            table = _unitOfWork.Set<T>();
        }

        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Update(T obj)
        {
            table.Update(obj);
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            return table.Where(spec.SpecExpression);
        }

        public T FindById(Guid id)
        {
            return table.Find(id);
        }

        public T FindOne(ISpecification<T> spec)
        {
            return table.Where(spec.SpecExpression).FirstOrDefault();
        }

        public void Remove(T entity)
        {
            table.Remove(entity);
        }
    }
}
