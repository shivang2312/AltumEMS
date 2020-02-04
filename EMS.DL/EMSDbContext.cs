using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DL
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext(DbContextOptions<EMSDbContext> options): base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
