using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JP9QAVP;Database=RentCar;Trusted_Connection=True"); 
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
