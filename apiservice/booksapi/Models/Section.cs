namespace booksapi.Models
{
    public class Section
    {
        public string? name { get; set; }

        public int haveStudied { get; set; }

        public string? studiedDate { get; set; }

        public string? description { get; set; }

        public int problemCount { get; set; }

        public int bookID { get; set; }


        //Not in storage
        public List<Section>? problems { get; set; }
    }
}
