namespace Notes.Data
{
    public class NoteService
    {
        ApplicationContext db = new ApplicationContext();
        public NoteService() 
        {
                    
        }

        public Note GetNote(Guid id)
        {
            return db.Notes.SingleOrDefault(x => x.Id == id);
        }

        public List<Note>? GetNotes()
        {
            return db.Notes.ToList();
        }

        public void UpdateNote(Note note)
        {
            var oldNote = GetNote(note.Id);
            oldNote.Title = note.Title;
            oldNote.Text = note.Text;
            db.SaveChanges();
        }

        public void AddNote(Note note) 
        { 
            db.Add(note); 
            db.SaveChanges();
        }
    }
}