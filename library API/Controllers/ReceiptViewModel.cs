using System;

namespace library_API.Controllers
{
    internal class ReceiptViewModel
    {
        public string Message { get; set; }
        public DateTime DuebackDate { get; internal set; }
    }
}