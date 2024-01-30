using System;
using Bitky_API.DTOs.OrderDTOs;
using Bitky_API.DTOs.OrderDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.OrderRepository
{
	public class OrderRepository : IOrderRepository
    {
        private readonly Context _context;
        public OrderRepository(Context context)
        {
            _context = context;
        }

        public bool CreateOrder(CreateOrderDTO createOrderDTO)
        {
            string query = "INSERT INTO Orders (OrderNameLat, OrderNameTr, OrderNameEn)" +
                " VALUES (@OrderNameLat, @OrderNameTr, @OrderNameEn)";

            var parameters = new DynamicParameters();
            parameters.Add("@OrderNameLat", createOrderDTO.OrderNameLat);
            parameters.Add("@OrderNameTr", createOrderDTO.OrderNameTr);
            parameters.Add("@OrderNameEn", createOrderDTO.OrderNameEn);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public bool DeleteOrder(DeleteOrderDTO deleteOrderDTO)
        {
            string query = "DELETE FROM Orders WHERE OrderID = @OrderID";

            var parameters = new DynamicParameters();
            parameters.Add("@OrderID", deleteOrderDTO.OrderID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }

        public async Task<List<ResultOrderDTO>> GetAllOrdersAsync()
        {
            string query = "SELECT OrderID, OrderNameLat, OrderNameTr, OrderNameEn FROM Orders";

            using (var conn = _context.ConnectSQL())
            {
                var result = await conn.QueryAsync<ResultOrderDTO>(query);
                return result.ToList();
            }
        }

        public bool UpdateOrder(UpdateOrderDTO updateOrderDTO)
        {
            string query = "UPDATE Orderes SET " +
                "OrderNameLat = @OrderNameLat," +
                "OrderNameTr = @OrderNameTr," +
                "OrderNameEn = @OrderNameEn " +
                "WHERE OrderID = @OrderID";

            var parameters = new DynamicParameters();
            parameters.Add("@OrderNameLat", updateOrderDTO.OrderNameLat);
            parameters.Add("@OrderNameTr", updateOrderDTO.OrderNameTr);
            parameters.Add("@OrderNameEn", updateOrderDTO.OrderNameEn);
            parameters.Add("@OrderID", updateOrderDTO.OrderID);

            using (var conn = _context.ConnectSQL())
            {
                int affectedRowCount = Convert.ToInt32(conn.ExecuteScalar(query, parameters));
                return affectedRowCount > 0;
            }
        }
    }
}

