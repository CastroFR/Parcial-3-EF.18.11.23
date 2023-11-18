using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    // <ESTUDIANTE> Acá el nombre que se coloca es de la clase mapeada en el codigo
    // (Estudiante) El nombre que le sigue es de nuestra tabla en la base de datos
    public DbSet<NOTAS> Notas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-GGOC9T3P;Database=NotaFinal-Progra; Trusted_Connection = SSPI; MultipleActiveResultSets = true ");
    }

}