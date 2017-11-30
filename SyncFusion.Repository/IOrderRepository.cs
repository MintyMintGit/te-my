using _1TE_MY.Models;
using _1TE_MY.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Repository
{
    public interface IOrderRepository
    {
        List<Orders> AddOrder(Orders order,OrderDetails orderDetails);
        List<Orders> GetAllOrders(int EmpId);
        OrderDTO GetOrderDto();
        OrderDTO GetOrderByOrderId(int Orderid);
        int UpdateOrder(Orders order, OrderDetails orderDetails);
        int Delete(int OrderId);
        Employees CheckLogin(Employees emp);
    }
}
