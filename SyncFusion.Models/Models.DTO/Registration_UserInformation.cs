using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1TE_MY.Models.DTO
{
   public class Registration_UserInformation
    {
		[Required(ErrorMessage ="Email ID is required")]
	
		public string Email { get; set; }
		[Required(ErrorMessage = "Name is required")]
		public string FullName { get; set; }
		[Required(ErrorMessage = "Country Code is required")]
		public int MobileCountryID { get; set; }
		[Required(ErrorMessage = "Mobile Number is required")]
		public string MobileNo { get; set; }
		[Required(ErrorMessage = "Security Question is required")]
		public string SecurityQuestion { get; set; }
		[Required(ErrorMessage = "Answer is required")]
		public string Answer { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Otp is required")]
        public Int32 Otp { get; set; }
    }
}
