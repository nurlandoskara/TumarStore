using Business.DTO;
using System;

namespace Business
{
    public class ItemDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public int Price { get; set; }
    }
}
