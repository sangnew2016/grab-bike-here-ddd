using System;
using System.Collections.Generic;
using System.Linq;
using tmsang.domain;

namespace tmsang.infra
{
    public class MemoryRepository<T> : IRepository<T> where T : IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;
        protected static List<T> entities = new List<T>();

        public MemoryRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            entities.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            return entities.Where(spec.IsSatisfiedBy);
        }

        public T FindById(Guid id)
        {
            return entities.Where(p => p.Id == id).FirstOrDefault();
        }

        public T FindOne(ISpecification<T> spec)
        {
            return entities.Where(spec.IsSatisfiedBy).FirstOrDefault();
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(T entity)
        {
            // TODO ....
        }
    }
}
