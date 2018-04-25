using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using library_API.Models;
using library_API.Data;
using System.Data.Entity;


namespace library_API.Controllers
{
    public class AuthorController : ApiController
    {
        public IEnumerable<Author> Get()
        {
            var dbLibraryContext = new DataContext();
            return dbLibraryContext.Authors.ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newAuthor = new Author
            {
                Name = name
            };
            var dbLibraryContext = new DataContext();
            dbLibraryContext.Authors.Add(newAuthor);
            dbLibraryContext.SaveChanges();
            return Ok(newAuthor);
        }

    }
}