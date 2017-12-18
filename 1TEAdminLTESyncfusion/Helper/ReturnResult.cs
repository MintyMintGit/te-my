using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1TE_MY.Helpers
{
    public class ReturnResult  
    {
        public Boolean Status { get; set; }
        public String Message { get; set; }
        public Object ReturnData { get; set; }
    }
}