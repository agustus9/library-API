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
    [Route("api/books")]
    public class BookController : ApiController
    {
        public IEnumerable<Book> GetAll()
        {
            var db = new DataContext();
            return db.Books.Include(i => i.Title).ToList();
        }
    }
}
