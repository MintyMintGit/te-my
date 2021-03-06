﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
      public int SupplierID { get; set; }
      public int CategoryID { get; set; }
      public string QuantityPerUnit { get; set; }
      public decimal UnitPrice { get; set; }
      public Int16 UnitsInStock { get; set; }
      public Int16 UnitsOnOrder { get; set; }
      public Int16 ReorderLevel { get; set; }
      public Boolean Discontinued { get; set; }

        //public virtual OrderDetails OrderDetails { get; set; }
    }
}
