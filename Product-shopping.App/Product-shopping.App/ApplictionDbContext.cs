using Product_shopping.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Product_shopping.App
{
    public class ApplictionDbContext : DbContext
         
    {
       public ApplictionDbContext() : base("DbConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

       public DbSet<Order> Orders { get; set; }
    }
}