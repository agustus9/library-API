using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;
using library_API.Data;
using library_API.Models;
using library_API.ViewModels;

namespace library_API.Controllers
{
    public class SearchBooksController : ApiController
    {
        [HttpGet]
        public IEnumerable<Book> Search([FromUri]SearchParams param)
        {
            using (var dbLibrary = new DataContext())
            {
                var query = dbLibrary.Books.Include(i => i.Author).Include(i => i.Genre);

                if (!String.IsNullOrEmpty(param.Title))
                {
                    query = query.Where(w => w.Title == param.Title);
                }

                if (param.Author != null)
                {
                    query = query.Where(w => w.Author.Name == param.Author);
                }
                if (param.Genre != null)
                {
                    query = query.Where(w => w.Genre.DisplayName == param.Genre);
                }

                return query.ToList();
            }
        }
    }
}
