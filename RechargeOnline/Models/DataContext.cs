using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RechargeOnline.Models
{
    public class DataContext : DbContext
    {

        public DataContext() : base("RechargeOnline")
        {
        }

        public DbSet<User> Users { get; set; }

    }
}