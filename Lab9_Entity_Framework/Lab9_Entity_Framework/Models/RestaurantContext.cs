using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Entity_Framework.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modeBuilder)
        {
            modeBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modeBuilder.Entity<Food>()
                .HasRequired(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.FoodCategoryId)
                .WillCascadeOnDelete(true);
        }
    }
}
