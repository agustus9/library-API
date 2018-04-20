using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_API.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}