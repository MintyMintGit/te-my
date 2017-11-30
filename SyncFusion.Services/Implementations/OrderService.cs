using AutoMapper;
using _1TE_MY.Models;
using _1TE_MY.Models.DTO;
using _1TE_MY.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFusion.Services
{
    public class OrderService :IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository OrderRepository)
        {
            _orderRepository = OrderRepository;
        }


        public List<Orders> AddOrder(OrderDTO orderDTO)
        {
            var order = Mapper.Map<Orders>(orderDTO);
            var orderDetails = Mapper.Map<OrderDetails>(orderDTO);
            return _orderRepository.AddOrder(order, orderDetails);
        }
        public List<Orders> GetAllOrders(int EmpId)
        {
            return _orderRepository.GetAllOrders(EmpId);
        }
        public OrderDTO GetOrderDto()
        {
            return _orderRepository.GetOrderDto();
        }

        public OrderDTO GetOrderByOrderId(int OrderId)
        {
            return _orderRepository.GetOrderByOrderId(OrderId);
        }

        public int UpdateOrder(OrderDTO OrderDto)
        {
            var order = Mapper.Map<Orders>(OrderDto);
            var orderDetails = Mapper.Map<OrderDetails>(OrderDto);
            return _orderRepository.UpdateOrder(order, orderDetails);
        }
        public int Delete(int OrderId)
        {
            return _orderRepository.Delete(OrderId);
        }

        public Employees CheckLogin(Employees emp)
        {
            return _orderRepository.CheckLogin(emp);
        }
    }
}
