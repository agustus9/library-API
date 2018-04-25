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
    public class GenreController : ApiController
    {
        public IEnumerable<Genre> Get()
        {
            var dbLibraryContext = new DataContext();
            return dbLibraryContext.Genres.ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newGenre = new Genre
            {
                DisplayName = name
            };
            var dbLibraryContext = new DataContext();
            dbLibraryContext.Genres.Add(newGenre);
            dbLibraryContext.SaveChanges();
            return Ok(newGenre);
        }
    }
}