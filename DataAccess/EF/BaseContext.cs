using DataAccess.Entities;
using System.Data.Entity;

namespace DataAccess.EF
{
    public class BaseContext: DbContext
    {
        static BaseContext()
        {

        }
        public BaseContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
