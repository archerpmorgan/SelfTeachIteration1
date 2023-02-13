namespace booksapi.Models
{

    public class Book
    {
        public string? title { get; set; }
        public string? subject { get; set; }
        public string? author { get; set; }
        public string? edition { get; set; }

        //Not in storage
        public List<Section>? sections { get; set; }
    }

} 