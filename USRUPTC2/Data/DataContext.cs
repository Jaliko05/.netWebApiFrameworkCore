using Microsoft.EntityFrameworkCore;
using USRUPTC1.Models;

namespace USRUPTC2.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Canal> Canals { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Cliente1> Cliente1s { get; set; } 
        public DbSet<CuentaProveedor> CuentaProveedors { get; set; } 
        public DbSet<Cuentum> Cuenta { get; set; } 
        public DbSet<Marca> Marcas { get; set; } 
        public DbSet<Origen> Origens { get; set; } 
        public DbSet<Plan> Plans { get; set; } 
        public DbSet<PlanCanal> PlanCanals { get; set; } 
        public DbSet<Producto> Productos { get; set; } 
        public DbSet<Proveedor> Proveedors { get; set; } 
        public DbSet<Referenciado> Referenciados { get; set; } 
        public DbSet<TipoProducto> TipoProductos { get; set; } 


    }
}
