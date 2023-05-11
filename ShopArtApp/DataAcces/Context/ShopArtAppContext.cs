using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopArtApp.Models;

namespace ShopArtApp.DataAcces.Context
{
    public class ShopArtAppContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<BillAddress> BillAddresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<CommandDetail> CommandsDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<User> Users { get; set; }
        public ShopArtAppContext(DbContextOptions<ShopArtAppContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CommandDetail>()
                .HasMany(c => c.Products)
                .WithOne(sp => sp.CommandDetail)
                .HasForeignKey(c => c.CommandDetailId);

            modelBuilder.Entity<User>()
                .HasMany(a => a.BillAddresses)
                .WithOne(u => u.User)
                .HasForeignKey(a => a.UserId)
               ;

            modelBuilder.Entity<Command>()
                .HasOne(u => u.User)
                .WithMany(c => c.Commands)
                .HasForeignKey(u => u.UserId)
                ;

            modelBuilder.Entity<Command>()
                .HasOne(c => c.BillAddress)
                .WithMany(b => b.Commands)
                .HasForeignKey(c => c.BillAddressId)
                ;

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryId)
                ;

            modelBuilder.Entity<Product>()
                .HasOne(c => c.ShoppingCart)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.ShoppingCartId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ShoppingCart>()
                .HasOne(u => u.User)
                .WithOne(s => s.ShoppingCart)
                .HasForeignKey<ShoppingCart>(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }




    }


}