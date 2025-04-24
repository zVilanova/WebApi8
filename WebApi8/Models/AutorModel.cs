using System.Text.Json.Serialization;

namespace WebApi8.Models;

public class AutorModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    [JsonIgnore] //Propriedade serve apenas para correlação
    public ICollection<LivroModel> Livros { get; set; } //Um autor pode ter vários livros 
}
