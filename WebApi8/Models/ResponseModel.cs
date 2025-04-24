namespace WebApi8.Models;

public class ResponseModel<T> //Pode receber qualquer tipo de modelo
{
    public T? Dados { get; set; } //Pode ter dados do tipo altor, livro ou nulo (ou outro futuro)
    public string Mensagem { get; set; } = string.Empty;
    public bool Status { get; set; } = true;
}
