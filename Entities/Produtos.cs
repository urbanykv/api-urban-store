using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_urban_store.Entities
{
  public class Produtos
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Descricao { get; set; }
    public float Rating { get; set; }
    public string Imagem { get; set; }
  }
}