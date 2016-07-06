using System.Data.Entity;
using EcommerceFramework.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EcommerceFramework.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RootCategory> RootCategories { get; set; }

        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }
        //  public DbSet<CategoryPaths> CategoryPathses { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
           // Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        public static ApplicationDbContext Create()
        {
            
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasRequired(c => c.RootCategory)
                .WithMany(c => c.Products)
                .WillCascadeOnDelete(false);
            //    modelBuilder.Entity<Category>()
            //        //.HasKey( x => x.CategoryId)
            //        .HasRequired(x=>x.Parent)
            //        .WithMany(x=>x.Children)
            //        .HasForeignKey(x => x.ParentId)
            //        .WillCascadeOnDelete(false);

            //  modelBuilder.Entity<Category>()
            //   .HasOptional(e => e.Children)
            //   .WithMany()
            //   .HasForeignKey(m => m.ChildrenId)
            //   .WillCascadeOnDelete(false);

            //  modelBuilder.Entity<Category>()
            //  .HasMany(e => e.Products).WithRequired(s =>s.RootCategory)
            //.WillCascadeOnDelete(false);

            //  modelBuilder.Entity<Product>()
            //  .HasRequired(e => e.RootCategory)
            //  .WithMany(p => p.Products)
            //  .WillCascadeOnDelete(false); 

            //modelBuilder.Entity<CategoryPaths>()
            //  .HasRequired(c => c.Parent)
            //  .WithOptional()
            //  .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Category>()
            //  .HasOptional(c => c.CategoryPath)
            //  .WithMany()
            //  .WillCascadeOnDelete(false);


            //modelBuilder.Entity<Category>()
            //  .HasRequired(c => c.CategoryPath)
            //  .WithMany()
            //  .WillCascadeOnDelete(false);





            base.OnModelCreating(modelBuilder);
        }
    }
}