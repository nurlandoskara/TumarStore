using DataAccess.Entities;
using System;

namespace DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Item> Items { get; }
        IRepository<ItemType> ItemTypes { get; }
        IRepository<Price> Prices { get; }
        void Save();
    }
}
