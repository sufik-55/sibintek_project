using Microsoft.EntityFrameworkCore;
using sibintek_test_task.Models;


namespace sibintek_test_task.Data.DbPostgreSQL
{
    public class AppDBContext : DbContext
    {
        public static string connection = "Host=84.201.152.11;Port=19001;Database=sqlfree-5;Username=netology;Password=NetoSQL2019";

        public static readonly ILoggerFactory loggerFactory = new LoggerFactory();


        public DbSet<SibintekFile> SibintekFile { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder
                .HasDefaultSchema("isufiyanov");
            
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder
        //         .UseLoggerFactory(loggerFactory);
        // }
    }
}