namespace GreetingAppRepositoryLayer.Context
{
    using GreetingAppCommonLayer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This clas contains the code for User data base context.
    /// </summary>
    public class UserDatabaseContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDatabaseContext"/> class.
        /// </summary>
        /// <param name="options">The UserDatabaseContext</param>
        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets and sets the Employee
        /// </summary>
        public DbSet<GreetingModel> Employee { get; set; }
    }
}
