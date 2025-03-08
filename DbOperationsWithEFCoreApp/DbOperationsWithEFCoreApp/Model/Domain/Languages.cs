﻿namespace DbOperationsWithEFCoreApp.Model.Domain
{
    public class Languages
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }




        public ICollection<Book> Books { get; set; }          //one to many relationship

    }
}
