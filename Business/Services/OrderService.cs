using AutoMapper;
using Business.DTO;
using Business.Infrastructure;
using Business.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeOrder(OrderDto orderDto)
        {
            Item item = Database.Items.Get(orderDto.ItemId);

            // валидация
            if (item == null)
                throw new ValidationException("Товар не найден", "");
            Order order = new Order
            {
                Date = DateTime.Now,
                Address = orderDto.Address,
                ItemId = item.Id,
                Sum = item.Price,
                PhoneNumber = orderDto.PhoneNumber
            };
            Database.Orders.Create(order);
            Database.Save();
        }

        public IEnumerable<ItemDto> GetItems()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Item, ItemDto>()).CreateMapper();
            return mapper.Map<IEnumerable<Item>, List<ItemDto>>(Database.Items.GetAll());
        }

        public ItemDto GetItem(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id товара", "");
            var item = Database.Items.Get(id.Value);
            if (item == null)
                throw new ValidationException("Товар не найден", "");

            return new ItemDto { Id = item.Id, Price = item.Price, Title = item.Title, Description = item.Description };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
