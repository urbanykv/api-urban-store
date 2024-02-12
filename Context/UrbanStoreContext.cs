using api_urban_store.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_urban_store.Context
{
  public class UrbanStoreContext : DbContext
  {
    public UrbanStoreContext(DbContextOptions<UrbanStoreContext> options) : base(options){}

    public DbSet<Produtos> Produtos { get; set; }
  }
}