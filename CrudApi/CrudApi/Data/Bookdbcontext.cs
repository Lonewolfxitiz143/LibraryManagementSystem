using CrudApi.Model_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace CrudApi.Data
{
    public class Bookdbcontext:DbContext
    {
        public Bookdbcontext(DbContextOptions<Bookdbcontext> options):base(options)
        {
            
        }
        public DbSet<Studentsdb>Booktable  { get; set; } 
        public DbSet<Authordb>AuthorTable  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Studentsdb>()
                .Property(c => c.price).HasColumnType("decimal(18,2)");
           

        }


    }
}
