using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceToTheRescue.Models
{
    public class Customer 
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}