using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBookShelf.Api.Data;
using MyBookShelf.Api.DTOs;
using MyBookShelf.Api.Models;

namespace MyBookShelf.Api.Controllers;

    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public  BooksController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Listar()
        {
            var books = await _context.Books
                .AsNoTracking()
                .OrderBy(book => book.Id)
                .ToListAsync<Book>();

            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> BuscarPorId(int id)
        {
            var book = await _context.Books
                .AsNoTracking()
                .FirstOrDefaultAsync(book => book.Id == id);

            if (book is null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Cadastrar(
            [FromBody] CreateBookDto dto)
        {
            var book = new Book()
            {
                Titulo = dto.Titulo.Trim(),
                Autor = dto.Autor.Trim(),
                AnoPublicacao = dto.AnoPublicacao,
                StatusLeitura = dto.StatusLeitura
            };
            
            _context.Books.Add(book);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = book.Id },
                book);
        }
    }