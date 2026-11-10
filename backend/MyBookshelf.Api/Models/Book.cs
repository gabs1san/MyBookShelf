namespace MyBookShelf.Api.Models;

public class Book
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public int AnoPublicacao { get; set; }

    public StatusLeitura StatusLeitura { get; set; }
        = global::MyBookShelf.Api.Models.StatusLeitura.QueroLer;
}