using Microsoft.EntityFrameworkCore;
using _1TE_MY.Models;
using _1TE_MY.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1TE_MY.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(_1TEDBContext context)
        {
            _context = context;
        }
        private _1TEDBContext _context;


        public List<Orders> AddOrder(Orders order, OrderDetails orderDetails)
        {
            try
            {
                if (order != null && orderDetails != null)
                {                    
                    _context.Add(order);
                    _context.SaveChanges();
                    orderDetails.OrderID = order.OrderID;
                    _context.Add(orderDetails);
                    _context.SaveChanges();
                }
                return GetAllOrders(order.EmployeeID);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Orders> GetAllOrders(int EmpId)
        {
            return _context.Orders.Where(x=>x.EmployeeID==EmpId).Include(p=>p.OrderDetails).ThenInclude(p=>p.Products).OrderByDescending(x=>x.OrderID).ToList();
        }

        public OrderDTO GetOrderByOrderId(int Orderid)
        {
            var order= _context.Orders.Where(x => x.OrderID == Orderid).Include(p => p.OrderDetails).ThenInclude(p => p.Products).OrderByDescending(x => x.OrderDate).FirstOrDefault();
        
            OrderDTO orderDto= new OrderDTO();
            if (order != null)
            {
                orderDto.OrderID = order.OrderID;
                orderDto.CustomerID = order.CustomerID;
                orderDto.EmployeeID = order.EmployeeID;
                orderDto.Freight = order.Freight;
                orderDto.Discount = order.OrderDetails != null ? order.OrderDetails.Discount :0;
                orderDto.OrderDate = order.OrderDate;
                orderDto.ProductID = order.OrderDetails != null ? order.OrderDetails.ProductID : 0;
                orderDto.Quantity = order.OrderDetails != null ? order.OrderDetails.Quantity : 0;
                orderDto.RequiredDate = order.RequiredDate;
                orderDto.ShipAddress = order.ShipAddress;
                orderDto.ShipCity = order.ShipCity;
                orderDto.ShipCountry = order.ShipCountry;
                orderDto.ShipName = order.ShipName;
                orderDto.ShippedDate = order.ShippedDate;
                orderDto.ShipPostalCode = order.ShipPostalCode;
                orderDto.ShipRegion = order.ShipRegion;
                orderDto.ShipVia = order.ShipVia;
                orderDto.UnitPrice = order.OrderDetails != null ? order.OrderDetails.UnitPrice : 0;
                orderDto.CustomersList = _context.Customers.ToList();
                orderDto.ShippersList = _context.Shippers.ToList();
                orderDto.ProductsList = _context.Products.ToList();
            }
            return orderDto;
        }


        public OrderDTO GetOrderDto()
        {
            try
            {
                OrderDTO order = new OrderDTO();
                //order.OrdersList = _context.Orders.Include(p=>p.OrderDetails).ThenInclude(p=>p.Products).OrderByDescending(x=>x.OrderDate).ToList();
                order.CustomersList = _context.Customers.ToList();
                order.ShippersList = _context.Shippers.ToList();
                order.ProductsList = _context.Products.ToList();
                return order;
            }
            catch (Exception ex) { throw ex; }
        }
        public int UpdateOrder(Orders order, OrderDetails orderDetails)
        {
            var exisOrder = _context.Orders.Where(x => x.OrderID == order.OrderID).FirstOrDefault();
            var exisOrderDetail = _context.OrderDetails.Where(x => x.OrderID == order.OrderID).FirstOrDefault();
            if(exisOrderDetail!= null)
            {
                exisOrderDetail.Discount = orderDetails.Discount;
                exisOrderDetail.ProductID = orderDetails.ProductID;
                exisOrderDetail.Quantity = orderDetails.Quantity;
                exisOrderDetail.UnitPrice = orderDetails.UnitPrice;
                //_context.SaveChanges();
            }
            if (exisOrder != null)
            {
                exisOrder.CustomerID = order.CustomerID;
                exisOrder.OrderDate = order.OrderDate;
                exisOrder.RequiredDate = order.RequiredDate;
                exisOrder.ShipAddress = order.ShipAddress;
                exisOrder.ShipCity = order.ShipCity;
                exisOrder.ShipCountry = order.ShipCountry;
                exisOrder.ShipName = order.ShipName;
                exisOrder.ShippedDate = order.ShippedDate;
                exisOrder.ShipPostalCode = order.ShipPostalCode;
                exisOrder.ShipRegion = order.ShipRegion;
                exisOrder.ShipVia = order.ShipVia;
                exisOrder.Freight = order.Freight;
                //_context.SaveChanges();
            }
            _context.SaveChanges();
            return exisOrder.OrderID;
        }
        public int Delete(int OrderId)
        {          
            var OrderDetail = _context.OrderDetails.Where(x => x.OrderID == OrderId).FirstOrDefault();
            if (OrderDetail != null)
            {
                _context.OrderDetails.Remove(OrderDetail);
                _context.SaveChanges();
                var Order = _context.Orders.Where(x => x.OrderID == OrderId).FirstOrDefault();
                if (Order != null)
                {
                    _context.Orders.Remove(Order);
                    _context.SaveChanges();
                }
            }        
            return OrderId;
        }

        public Employees CheckLogin(Employees emp)
        {
            
            try
            {
                var empModel = new Employees();
                if (!string.IsNullOrEmpty(emp.Email) && !string.IsNullOrEmpty(emp.Password))
                {
                    empModel = _context.Employees.Where(x => x.Email == emp.Email && x.Password == emp.Password).FirstOrDefault();
                    
                }
                return empModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
