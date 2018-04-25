using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using library_API.Models;
using System.Data.Entity;


namespace library_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}