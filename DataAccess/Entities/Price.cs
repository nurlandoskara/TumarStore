using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Price: BaseEntity
    {
        public int Value { get; set; }
        public int ItemId { get; set; }
    }
}
