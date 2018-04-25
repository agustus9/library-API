using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using library_API.Data;
using library_API.Models;

namespace library_API.Controllers
{
    public class AuthorFactoryController : ApiController
    {
        public IHttpActionResult Post(Author data)
        {
            var dbLibraryContext = new DataContext();
            dbLibraryContext.Authors.Add(data);
            dbLibraryContext.SaveChanges();
            return Ok(data);
        }
    }
}
    
