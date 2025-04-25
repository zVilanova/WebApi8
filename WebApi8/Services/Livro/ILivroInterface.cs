using WebApi8.Dto.Autor;
using WebApi8.Dto.Livro;
using WebApi8.Models;

namespace WebApi8.Services.Livro;

public interface ILivroInterface
{
    Task<ResponseModel<List<LivroModel>>> ListarLivros(); //Retorna uma lista com todos os livros
    Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro); //Retorna um livro por seu id
    Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor); //Retorna um livro a partir do id de um autor
    Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto); //Cria um autor
    Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto); //Edita um autor
    Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro); //Exclui um livro a partir de seu id
}
