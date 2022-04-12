using COMP2084Winter2022TuesdayCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace COMP2084Winter2022TuesdayCore.Data
{
    public class DataContext : DbContext
    {


        public DbSet<Employee> employees { get; set; }
        public DbSet<Country> countries { get; set; }

        public DbSet<Folder> Folder { get; set; }
        public DbSet<Owner> Owner { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
