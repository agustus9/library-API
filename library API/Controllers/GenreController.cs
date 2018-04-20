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
    [Route("api/genres")]
    public class GenreController : ApiController
    {
        public IEnumerable<Genre> GetAll()
        {
            var db = new DataContext();
            return db.Genres.Include(i => i.Name).ToList();
        }
    }
}
