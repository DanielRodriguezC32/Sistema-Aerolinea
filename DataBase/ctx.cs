using System.Data.Entity;

public class ctx : DbContext
{
    //public DbSet<Usuario> Usuarios { get; set; }
    //public DbSet<Pago> Pagos { get; set; }

    public ctx() : base("AeropuertoEntitiesRodrigo") // Usa el nombre de la cadena de conexión
    {
    }
}
