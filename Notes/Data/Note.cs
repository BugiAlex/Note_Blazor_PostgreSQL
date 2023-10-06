namespace Notes.Data
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }             
    }
}