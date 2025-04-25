using WebApi8.Dto.Autor;
using WebApi8.Models;

namespace WebApi8.Services.Autor;

public interface IAutorInterface
{
    Task<ResponseModel<List<AutorModel>>> ListarAutores(); //Retorna uma lista com todos os autores
    Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor); //Retorna um autor por seu id
    Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro); //Retorna um autor a partir do id de um livro
    Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto); //Cria um autor
    Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto); //Edita um autor
    Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor); //Exclui um autor a partir de seu id
}
