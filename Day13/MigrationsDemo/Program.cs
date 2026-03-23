using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;

var context = new CrmDbContext();

var customers = context.Customer.ToList();

foreach (var customer in customers)
{
    Console.WriteLine(
    $"ID: {customer.CustomerId}, Name: {customer.Name}, Age: {customer.Age}"
);

}

class CrmDbContext : DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(
        "Server=localhost\\SQLEXPRESS;Database=MigrationsDemo;Trusted_Connection=True;TrustServerCertificate=True"
    );
}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerType>()
            .HasData(
                new CustomerType { Id = 1, TypeName = "Regular" },
                new CustomerType { Id = 2, TypeName = "Premium" }
            );

        modelBuilder.Entity<Order>()
            .HasKey(o => o.OrderId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany()
            .HasForeignKey(o => o.CustomerId);
    }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class CustomerType
{
    public int Id { get; set; }
    public string TypeName { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}