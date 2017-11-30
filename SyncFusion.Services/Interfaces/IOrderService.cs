using _1TE_MY.Models;
using _1TE_MY.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFusion.Services
{
    public interface IOrderService
    {
        List<Orders> AddOrder(OrderDTO OrderDto);
        List<Orders> GetAllOrders(int EmpId);
        OrderDTO GetOrderByOrderId(int Orderid);
        OrderDTO GetOrderDto();
        int UpdateOrder(OrderDTO Order);
        int Delete(int OrderId);

        Employees CheckLogin(Employees emp);
    }
}
