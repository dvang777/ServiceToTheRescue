using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceToTheRescue.Models
{
    public class MasterDBContext : DbContext
    {
        public MasterDBContext(): base("DefaultConnection")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<AttachmentModel> Attachment { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}