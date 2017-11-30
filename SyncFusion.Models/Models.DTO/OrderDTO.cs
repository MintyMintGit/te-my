using _1TE_MY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }

        [Required(ErrorMessage = "*")]
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }

        //[Required(ErrorMessage = "*")]
        //public string OrderDateString { get; set; }
        public DateTime? OrderDate { get; set; }

        //[Required(ErrorMessage = "*")]
        //public string RequiredDateString { get; set; }
        public DateTime? RequiredDate { get; set; }

        //[Required(ErrorMessage = "*")]
        //public string ShippedDatestring { get; set; }
        public DateTime? ShippedDate { get; set; }

        [Required(ErrorMessage = "*")]
        public int ShipVia { get; set; }
        [Required(ErrorMessage = "*")]
        public decimal Freight { get; set; }
        [Required(ErrorMessage = "*")]
        public string ShipName { get; set; }

        [Required(ErrorMessage = "*")]
        public string ShipAddress { get; set; }

        [Required(ErrorMessage = "*")]
        public string ShipCity { get; set; }

        [Required(ErrorMessage = "*")]
        public string ShipRegion { get; set; }

        [Required(ErrorMessage = "*")]
        public string ShipPostalCode { get; set; }

        [Required(ErrorMessage = "*")]
        public string ShipCountry { get; set; }

        [Required(ErrorMessage = "*")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(1,999999)]
        public decimal? UnitPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(1, 999999)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(0,1)]
        public Single Discount { get; set; }

        public string Message { get; set; }

        public List<int> SelectedCustomerId { get; set; }
        //public virtual OrderDetails OrderDetails { get; set; }

        //public List<Orders> OrdersList { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public List<Customers> CustomersList { get; set; }
        public List<Shippers>ShippersList { get; set; }
        public List<Products> ProductsList { get; set; }
    }
}
