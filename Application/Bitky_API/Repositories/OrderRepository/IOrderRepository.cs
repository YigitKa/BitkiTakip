using System;
using Bitky_API.DTOs.OrderDTOs;

namespace Bitky_API.Repositories.OrderRepository
{
	public interface IOrderRepository
	{
		Task<List<ResultOrderDTO>> GetAllOrdersAsync();
        bool DeleteOrder(DeleteOrderDTO deleteOrderDTO);
        bool UpdateOrder(UpdateOrderDTO updateOrderDTO);
        bool CreateOrder(CreateOrderDTO createOrderDTO);
    }
}

