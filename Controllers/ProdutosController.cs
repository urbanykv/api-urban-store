using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_urban_store.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace api_urban_store.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProdutosController : ControllerBase
  {
    private readonly IMongoDatabase _database;

    public ProdutosController(IMongoDatabase database)
    {
      _database = database;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var collection = _database.GetCollection<Produtos>("Produtos");
      var produtos = await collection.Find(new BsonDocument()).ToListAsync();
      
      return Ok(produtos);
    }
  }
}