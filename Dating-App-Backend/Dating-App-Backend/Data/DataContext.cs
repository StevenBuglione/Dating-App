using System;
using Dating_App_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Dating_App_Backend.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Value> Values { get; set; }
        
    }
}
