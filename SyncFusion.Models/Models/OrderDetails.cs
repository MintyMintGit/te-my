using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _1TE_MY.Models
{
    public class OrderDetails
    {
        [Key, ForeignKey("Orders")]
    public int OrderID { get; set; }
     public int ProductID { get; set; }
    public decimal? UnitPrice { get; set; }
    public Int16 Quantity { get; set; }
    public Single Discount { get; set; }

    //public virtual Orders Orders { get; set; }

    public virtual Products Products { get; set; }
    }
}
