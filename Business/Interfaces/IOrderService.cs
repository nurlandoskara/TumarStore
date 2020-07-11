using Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDto orderDto);
        ItemDto GetItem(int? id);
        IEnumerable<ItemDto> GetItems();
        void Dispose();
    }
}
