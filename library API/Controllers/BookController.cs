using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using library_API.Data;
using library_API.Models;
using System.Data.Entity;


namespace library_API.Controllers
{
    public class BookController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            var dbLibrary = new DataContext();
            var data = dbLibrary.Books.Include(i => i.Author).Include(i => i.Genre);
            return data.ToList();
        }
    }
}


