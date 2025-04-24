namespace WebApi8.Models;

public class LivroModel
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public AutorModel Autor { get; set; } //Um livro tem um autor referênciado
}
