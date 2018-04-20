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
    [Route("api/CheckOutLedgerControllers")]
    public class CheckOutLedgerController : ApiController
    {
        public IEnumerable<CheckOutLedger> GetAll()
        {
            var db = new DataContext();
            return db.CheckOutLedger.Include(i => i.Name).ToList();
        }
    }
}
