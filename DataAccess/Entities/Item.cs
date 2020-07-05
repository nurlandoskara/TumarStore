using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Item: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }
        public ICollection<Price> Prices { get; set; }
    }
}
