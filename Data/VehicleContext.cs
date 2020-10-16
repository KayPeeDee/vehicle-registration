using Microsoft.EntityFrameworkCore;
using CrudmvcApp.Models;

namespace CrudmvcApp.Data
{
    public class VehicleContext: DbContext {

        public VehicleContext(DbContextOptions<VehicleContext> options): base(options){}

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
