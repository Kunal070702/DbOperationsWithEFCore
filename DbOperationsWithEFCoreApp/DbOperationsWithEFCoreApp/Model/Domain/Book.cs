namespace DbOperationsWithEFCoreApp.Model.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NoOfPages { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LanguageId { get; set; }       //foreign key

        public Languages Language { get; set; }      //declaring the foreign key of language table

    }
}
