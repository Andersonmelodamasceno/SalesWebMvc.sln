using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.sln.Models;

namespace SalesWebMvc.sln.Data
{
    public class SalesWebMvcslnContext : DbContext
    {
        public SalesWebMvcslnContext (DbContextOptions<SalesWebMvcslnContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.sln.Models.Department> Department { get; set; }
    }
}
