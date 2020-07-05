using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        private BaseContext db;
        public ItemRepository(BaseContext context)
        {
            this.db = context;
        }
        public void Create(Item item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> Find(Func<Item, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Item Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
