using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApi8.Data;
using WebApi8.Models;

namespace WebApi8.Services.Autor;

public class AutorService : IAutorInterface
{
    //Acesso ao contexto a partir de _context
    private readonly AppDbContext _context;
    public AutorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
    {
        ResponseModel<AutorModel> resposta = new ResponseModel<AutorModel>(); //Variável de resposta
        try
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.Id == idAutor); //Verifica se o id é igual ao recebido no parâmetro
            
            if (autor is null)
            {
                resposta.Mensagem = "Nenhum registro localizado!";
                return resposta;
            }

            resposta.Dados = autor;
            resposta.Mensagem = "Autor localizado!";

            return resposta;
        } 
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
    {
        ResponseModel<AutorModel> resposta = new ResponseModel<AutorModel>(); //Variável de resposta
        try
        {
            var livro = await _context.Livros
                .Include(a => a.Autor)
                .FirstOrDefaultAsync(livroBanco => livroBanco.Id == idLivro); //Entra no banco de dados e na tabela de Livros busca o autor vinculado ao id do livro

            if (livro is null)
            {
                resposta.Mensagem = "Nenhum autor localizado!";
                return resposta;
            }

            resposta.Dados = livro.Autor;
            resposta.Mensagem = "Autor localizado!";
            return resposta;
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
    {
        ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>(); //Variável de resposta
        try
        {
            var autores = await _context.Autores.ToListAsync(); //Entra no banco com _context, depois na tabela de autores e transforma em lista 
            
            resposta.Dados = autores;
            resposta.Mensagem = "Todos os autores foram coletados!";

            return resposta;
        }
        catch (Exception ex) 
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }
}
