using System;
using System.ComponentModel.DataAnnotations;

namespace _1TE_MY.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is Required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.+-]+\.(?:[a-zA-Z]{2}|COM|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum|edu|academy|biz|college|education|int)$", ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "{0} must be between 6 to 15 characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //public bool RememberMe { get; set; }
        public string FirstName { get; set; }
      public string Title { get; set; }
      public string TitleOfCourtesy { get; set; }
      public DateTime BirthDate { get; set; }
      public DateTime HireDate { get; set; }
      public string Address { get; set; }
      public string City { get; set; }
      public string Region { get; set; }
      public string PostalCode { get; set; }
      public string Country { get; set; }
      public string HomePhone { get; set; }
      public string Extension { get; set; }
      public byte[] Photo { get; set; }
      public string Notes { get; set; }
      public int ReportsTo { get; set; }
      public string PhotoPath { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
