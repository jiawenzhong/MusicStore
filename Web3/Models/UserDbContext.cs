using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web3.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<RegisterModel> UserAccounts { get; set; }
    }
}