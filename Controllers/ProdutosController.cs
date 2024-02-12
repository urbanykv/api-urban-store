using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_urban_store.Context;
using api_urban_store.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api_urban_store.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProdutosController : ControllerBase
  {
    private readonly UrbanStoreContext _contextUrbanStore;

    public ProdutosController( UrbanStoreContext contextUrbanStore)
    {
      _contextUrbanStore = contextUrbanStore;
    }

    [HttpGet("products/{id}")]
    public IActionResult GetProductPerId(int id)
    {
      var produto = _contextUrbanStore.Produtos.Find(id);

      if(produto == null)
      {
        NotFound();
      }

      return Ok(produto);
    }
    
    [HttpGet("products")]
    public IActionResult GetProducts()
    {
      var produtos = _contextUrbanStore.Produtos;
      return Ok(produtos);
    }
  }
}