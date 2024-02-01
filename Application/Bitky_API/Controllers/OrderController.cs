using System;
using Bitky_API.DTOs.OrderDTOs;
using Bitky_API.Repositories.OrderRepository;
using Microsoft.AspNetCore.Mvc;

namespace Bitky_API.Controllers
{
	public class OrderController : Controller
	{
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> OrderList()
        {
            var values = await _orderRepository.GetAllOrdersAsync();
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder([FromBody] DeleteOrderDTO deleteOrderDTO)
        {
            bool result = _orderRepository.DeleteOrder(deleteOrderDTO);
            if (!result)
            {
                return Problem("Takım silinirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDTO createOrderDTO)
        {
            bool result = _orderRepository.CreateOrder(createOrderDTO);

            if (!result)
            {
                return Problem("Takım eklenirken hata oluştu.");
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderDTO updateOrderDTO)
        {
            bool result = _orderRepository.UpdateOrder(updateOrderDTO);

            if (!result)
            {
                return Problem("Takım eklenirken güncellenirken oluştu.");
            }
            return Ok();
        }
    }
}

