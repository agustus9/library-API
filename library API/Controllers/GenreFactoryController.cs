using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using library_API.Data;
using library_API.Models;

namespace library_API.Controllers
{
    public class GenreFactoryController : ApiController
    {
        public IHttpActionResult Post(Genre data)
        {
            var dbLibraryContext = new DataContext();
            dbLibraryContext.Genres.Add(data);
            dbLibraryContext.SaveChanges();
            return Ok(data);
        }
    }
}
    
