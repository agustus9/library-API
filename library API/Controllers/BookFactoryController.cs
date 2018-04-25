using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using library_API.Data;
using library_API.Models;

namespace library_API.Controllers
{
    public class BookFactoryController : ApiController
    {
        public IHttpActionResult Post(Book data)
        {
            var dbLibrary = new DataContext();
            dbLibrary.Books.Add(data);
            dbLibrary.SaveChanges();
            return Ok(data);
        }
    }
}