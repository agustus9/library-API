using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Condition { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckOut { get; set; }
        public DateTime DueBackDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}