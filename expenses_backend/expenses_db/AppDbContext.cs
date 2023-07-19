using Microsoft.EntityFrameworkCore;

namespace expenses_db;

public class AppDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=localhost,1433;Database=ExpensesDB;User Id=sa;Password=Arsenal1996;TrustServerCertificate=true;");
    }
}