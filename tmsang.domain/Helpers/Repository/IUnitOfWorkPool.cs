using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace tmsang.domain
{
    public interface IUnitOfWorkPool
    {
        IEnumerable<string> RegisteredUoWKeys { get; }

        IUnitOfWork Get(string key);

        IEnumerable<IUnitOfWork> GetAll();
    }

    public class UnitOfWorkPoolOptions
    {
        public Dictionary<string, Type> RegisteredUoWs { get; set; } = new Dictionary<string, Type>();
    }

    public class UnitOfWorkPoolOptionsBuilder
    {
        public UnitOfWorkPoolOptions Options { get; } = new UnitOfWorkPoolOptions();

        /// <summary>
        /// Registers the name by which a Unit of Work for the given DbContext will be retrievable
        /// </summary>
        /// <typeparam name="T">DbContext for which a Unit of Work will be added</typeparam>
        /// <param name="key">The key by which a Unit of Work for the DbContext will be retrievable in client code</param>
        public void AddUnitOfWork<T>(string key) where T : DbContext
        {
            Options.RegisteredUoWs.Add(key, typeof(IUnitOfWork<T>));
        }
    }

    public class Test : DbContext { }
}
