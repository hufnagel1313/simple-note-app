using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Repositories;

public interface INoteRepository : IBaseRepository<Note>
{ 
    Task<List<Note>> GetByLabel(string label, CancellationToken cancellationToken);
}