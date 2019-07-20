using Microsoft.EntityFrameworkCore;

public class CustomerDbContext : DbContext
{
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Crib> Cribs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlServer(@"Server=13.250.210.161;Database=MyCustomerDB;User Id=uat;
                    Password=uat@321;");
    }
}