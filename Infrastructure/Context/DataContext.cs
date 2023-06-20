using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookEditor> BookEditors { get; set; }
    public DbSet<Editor> Editors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookAuthor>().HasKey(key => new { key.AuthorId, key.Isbn });
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<BookEditor>().HasKey(key => new { key.EditorId, key.BookIsbn });
        base.OnModelCreating(modelBuilder);
    }
}