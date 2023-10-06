using Notes.Data;
using NUnit.Framework;

namespace NoteTests
{
    public class Tests
    {

        [Test]
        public void TestGetNote()
        {
            NoteService application = new NoteService();

            Note note = new Note()
            {
                Title = "TestTitleGet",
                Text = "TestTextGet",

                Date = DateTime.Now.ToString(),
                Id = Guid.NewGuid()
            };

            application.AddNote(note);

            Note note1 = application.GetNote(note.Id);

            Assert.AreEqual("TestTitleGet", note1.Title);
        }

        [Test]
        public void TestAddNote()
        {
            NoteService application = new NoteService();

            Note note = new Note()
            {
                Title = "TestTitleAdd",
                Text = "TestTextAdd",
                Date = DateTime.Now.ToString(),
                Id = Guid.NewGuid()
            };

            application.AddNote(note);

            Note note1 = application.GetNote(note.Id);

            Assert.AreEqual("TestTitleAdd", note1.Title);
        }

        [Test]
        public void TestUpdateNote()
        {
            NoteService application = new NoteService();

            Note note = new Note()
            {
                Title = "TestTitleUpdate",
                Text = "TestTextUpdate",
                Date = DateTime.Now.ToString(),
                Id = Guid.NewGuid()
            };

            application.AddNote(note);

            Note noteForUpdate = application.GetNote(note.Id);

            string newText = "TestTextUpdateNew";
            string newTitle = "TestTitleUpdateNew";
            noteForUpdate.Text = newText;
            noteForUpdate.Title = newTitle;
            application.UpdateNote(noteForUpdate);

            Note newNote = application.GetNote(note.Id);


            Assert.AreEqual(newText, newNote.Text);
            Assert.AreEqual(newTitle, newNote.Title);
        }

        [Test]
        public void TestGetNotes()
        {
            NoteService application = new NoteService();

            Note note = new Note()
            {
                Title = "TestTitleUpdate",
                Text = "TestTextUpdate",
                Date = DateTime.Now.ToString(),
                Id = Guid.NewGuid()
            };

            application.AddNote(note);

            List<Note>? notes = application.GetNotes();

            Assert.IsNotNull(notes);
            Assert.AreNotEqual(notes.Count, 0);

        }
    }
}