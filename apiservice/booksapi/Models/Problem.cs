namespace booksapi.Models
{

    public class Problem
    {
        public string? name { get; set; }

        public int completed { get; set; }

        public string? completedDate { get; set; }

        public int sectionID { get; set; }
        public int bookID { get; set; }
    }
}