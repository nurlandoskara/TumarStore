using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class ItemTypeRepository : IRepository<ItemType>
    {
        private BaseContext db;
        public ItemTypeRepository(BaseContext context)
        {
            this.db = context;
        }
        public void Create(ItemType item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemType> Find(Func<ItemType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ItemType Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemType> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ItemType item)
        {
            throw new NotImplementedException();
        }
    }
}
