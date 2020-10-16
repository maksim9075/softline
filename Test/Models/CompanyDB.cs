using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class CompanyDB:DbContext
    {
        
        public CompanyDB(DbContextOptions<CompanyDB> options) : base(options)
        {
         
            Database.EnsureCreated();
        }
        public DbSet<InfoPerson> People { get; set; }
    }
}
