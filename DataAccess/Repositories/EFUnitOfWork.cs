using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;

namespace DataAccess.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private BaseContext db;
        private ItemRepository itemRepository;
        private PriceRepository priceRepository;
        private ItemTypeRepository itemTypeRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new BaseContext(connectionString);
        }
        public IRepository<Item> Items
        {
            get
            {
                if (itemRepository == null)
                    itemRepository = new ItemRepository(db);
                return itemRepository;
            }
        }

        public IRepository<Price> Prices
        {
            get
            {
                if (priceRepository == null)
                    priceRepository = new PriceRepository(db);
                return priceRepository;
            }
        }

        public IRepository<ItemType> ItemTypes
        {
            get
            {
                if (itemTypeRepository == null)
                    itemTypeRepository = new ItemTypeRepository(db);
                return itemTypeRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
