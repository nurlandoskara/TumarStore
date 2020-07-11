using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class ItemType: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentItemTypeId { get; set; }
        public ItemType ParentItemType { get; set; }
    }
}
