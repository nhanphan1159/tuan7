using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tuan7.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=FoodDBContext")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
