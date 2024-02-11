using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_urban_store.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_urban_store.Context
{
  public class EcommerceUrbanStoreContext : DbContext
  {
    public EcommerceUrbanStoreContext(DbContextOptions<EcommerceUrbanStoreContext> options) : base(options)
    {

    }

    public DbSet<Produtos> Produtos { get; set; }
  }
}