using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityPractice.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("EntityPractice") {}

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}