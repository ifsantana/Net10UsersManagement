using Microsoft.EntityFrameworkCore;
using System;
using UsersManagement.Api.Controllers;
using UsersManagement.Api.Models;

namespace UsersManagement.Api.Repositories
{
    public class PgDataContext : DbContext
    {
        public PgDataContext(DbContextOptions<PgDataContext> options)
            : base(options)
        {
        }

        // Define a DbSet for the Product entity
        public DbSet<User> users { get; set; }
    }
}
