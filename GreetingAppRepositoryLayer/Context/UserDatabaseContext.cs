using GreetingAppCommonLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoryLayer.Context
{
    public class UserDatabaseContext : DbContext
    {
        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options) : base(options)
        {
        }
        public DbSet<GreetingModel> Employee { get; set; }
    }
}
