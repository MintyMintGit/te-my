﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Spatial;

namespace _1TE_MY.Models.Models
{
    [Table("Address", Schema = "Root")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public int rcID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string PostCode { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Geography Latitude { get; set; }
        public Geography Longitude { get; set; }
        public Nullable<bool> IsBilling { get; set; }
        public Nullable<bool> IsOperation { get; set; }
        public Nullable<bool> IsPickup { get; set; }
        public Nullable<bool> IsDelivery { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsVoid { get; set; }
        public Nullable<int> Addby { get; set; }
        public Nullable<System.DateTime> AddOn { get; set; }
        public Nullable<int> ModBy { get; set; }
        public Nullable<System.DateTime> ModOn { get; set; }
    }
}
