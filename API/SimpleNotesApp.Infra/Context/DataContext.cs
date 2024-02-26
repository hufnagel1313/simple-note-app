using Microsoft.EntityFrameworkCore;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Infra.Context;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; }
}