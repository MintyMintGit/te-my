using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Models.DTO
{
  public  class DropdownDTO
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
        public string CountryDialCode { get { return Text + " (" + Code + ")"; } }
    }
}
