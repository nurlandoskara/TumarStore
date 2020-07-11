using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO
{
    public class OrderDto
    {
        public int ItemId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ClientName { get; set; }
        
    }
}
