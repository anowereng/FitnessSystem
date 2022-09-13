using FitnessSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSystem.Core
{
    public class FitenessContext : DbContext
    {
        public FitenessContext(DbContextOptions<FitenessContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        public virtual DbSet<Category> Categories { get; set; }




    }
}
