﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace library_API.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();

    }
}