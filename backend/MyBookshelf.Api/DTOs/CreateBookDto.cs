using System.ComponentModel.DataAnnotations;
using MyBookShelf.Api.Models;


namespace MyBookShelf.Api.DTOs;

public class CreateBookDto
{
    [Required(ErrorMessage = "Informe o título")]
    [StringLength(200, MinimumLength = 3)]
    public string Titulo { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Informe o autor")]
    [StringLength(200, MinimumLength = 3)]
    public string Autor { get; set; } = string.Empty;
    
    [Range(1, 9999, ErrorMessage = "Informe um ano entre 1 e 9999")]
    public int AnoPublicacao { get; set; }
    
    [EnumDataType(typeof(StatusLeitura))]
    public StatusLeitura StatusLeitura { get; set; }
        = global::MyBookShelf.Api.Models.StatusLeitura.QueroLer;
    
}