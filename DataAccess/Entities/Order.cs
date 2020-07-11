using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Order: BaseEntity
    {
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Sum { get; set; }
        public int ItemId { get; set; }

    }
}
