using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCStorage2.Models;

namespace MVCStorage2.DataAccessLayer {
    public class StorageContext : DbContext {
        public StorageContext() : base("StorageConnection") {
            
        }

        public DbSet<Models.Product> Products { get; set; }
    }
}