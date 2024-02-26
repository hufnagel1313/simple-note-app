using Microsoft.EntityFrameworkCore;
using SimpleNotesApp.Application.Repositories;
using SimpleNotesApp.Domain.Entities;
using SimpleNotesApp.Infra.Context;

namespace SimpleNotesApp.Infra.Repositories;
public class NoteRepository : BaseRepository<Note>, INoteRepository
{
    public NoteRepository(DataContext context) : base(context)
    {
    }
    
    public Task<List<Note>> GetByLabel(string label, CancellationToken cancellationToken)
    {
        return Context.Notes.Where(x=>x.Label.Equals(label) && x.DateDeleted == null).ToListAsync(cancellationToken);
    }
}