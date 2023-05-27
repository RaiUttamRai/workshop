using Microsoft.EntityFrameworkCore;
public class AppDbContext: DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbContext(IConfiguration configuration)
    {
        _configuration= configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBUilder optionBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        base.OnConfiguring(optionBuilder);
        optionBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();

        public DbSet<Classinfo>Classinfo{get;set;}
    }
}