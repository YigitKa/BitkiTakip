using System;
namespace Bitky_WebApp.DTOs.OrderDTOs
{
	public class UpdateOrderDTO
    {
        public int OrderID { get; set; }
        public string OrderNameLat { get; set; }
        public string OrderNameTr { get; set; }
        public string OrderNameEn { get; set; }
    }
}

