using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceToTheRescue.Models
{
    public class Technician 
    {
        public int ID { get; set; }
        public string TechID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsExperience { get; set; }
        public string ServiceField { get; set; }
        public string Bio { get; set; }
        public string FileName { get; set; }
    }
}