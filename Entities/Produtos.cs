using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api_urban_store.Entities
{
  public class Produtos
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string _id { get; set; }
    public int id { get; set; }
    public string nome { get; set; }
    public double preco { get; set; }
    public string descricao { get; set; }
    public double rating { get; set; }
    public string imagem { get; set; }
  }
}