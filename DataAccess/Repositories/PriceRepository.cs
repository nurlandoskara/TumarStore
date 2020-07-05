using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class PriceRepository : IRepository<Price>
    {
        private BaseContext db;

        public PriceRepository(BaseContext context)
        {
            this.db = context;
        }
        public void Create(Price item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Price> Find(Func<Price, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Price Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Price> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Price item)
        {
            throw new NotImplementedException();
        }
    }
}
