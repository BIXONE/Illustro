namespace Illustro.DBContext;

public class AplicationDBContext : DbContext
{
    public DbSet<Employees> Employees { get; set; }
    public DbSet<ProductionOrderItemStatuses> ProductionOrderItemStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SteelDoor");
    }
}

