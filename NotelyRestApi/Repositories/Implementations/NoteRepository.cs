using NotelyRestApi.Database;
using NotelyRestApi.Models;
using System.Collections.Generic;

namespace NotelyRestApi.Repositories.Implementations
{
    public class NoteRepository : INoteRepository
    {
        private NotelyDbContext _context;

        public NoteRepository(NotelyDbContext context)
        {
            _context = context;
        }

        public Note FindNoteById(long id)
        {
            var note = _context.Notes.Find(id);
            return note;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _context.Notes;
            return notes;
        }

        public void SaveNote( Note noteModel)
        {
            _context.Notes.Add(noteModel);
            _context.SaveChanges();
        }

        public void EditNote(Note noteModel)
        {
            _context.Notes.Update(noteModel);
            _context.SaveChanges();
        }

        public void DeleteNote(Note noteModel)
        {
            _context.Notes.Remove(noteModel);
            _context.SaveChanges();
        }


    }
}
