using WebApi8.Dto.Vinculo;
using WebApi8.Models;

namespace WebApi8.Dto.Livro;

public class LivroCriacaoDto
{
    public string Titulo { get; set; }
    public AutorVinculoDto Autor { get; set; } //Um livro tem um autor referênciado
}
