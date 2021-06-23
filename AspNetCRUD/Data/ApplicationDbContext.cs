using System;
using AspNetCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }

        public DbSet<Employee> Employees { get; set; }

    }

}
