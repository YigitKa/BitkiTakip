using System;
using Bitky_API.DTOs.OrderDTOs;

namespace Bitky_API.Repositories.OrderRepository
{
	public class OrderRepository : IOrderRepository
	{
		public OrderRepository()
		{
		}

        public bool CreateOrder(CreateOrderDTO createOrderDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(DeleteOrderDTO deleteOrderDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultOrderDTO>> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(UpdateOrderDTO updateOrderDTO)
        {
            throw new NotImplementedException();
        }
    }
}

