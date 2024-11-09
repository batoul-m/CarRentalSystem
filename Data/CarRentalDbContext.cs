using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Models;

public class CarRentalDbContext : IdentityDbContext<AppUser>
{
    public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options) : base(options) { }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}
