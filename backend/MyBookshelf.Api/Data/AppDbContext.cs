using Microsoft.EntityFrameworkCore;
using MyBookShelf.Api.Models;

namespace MyBookShelf.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(book => book.Id);

            entity.Property(book => book.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(book => book.Autor)
                .IsRequired()
                .HasMaxLength(150);
        });
    }
}