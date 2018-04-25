using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_API.Models
{
    public class CheckOutLedger
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Email { get; set; }

        public Book Book { get; set; }
        public int? BookId { get; set; }
    }
}