﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using library_API.Models;
using library_API.Data;
using System.Data.Entity;
using library_API.ViewModels;

namespace library_API.Controllers
{
    public class CheckOutLedgerController : ApiController
    {
        [HttpPut]
        [Route("api/book/{bookId}/checkout")]
        public CheckoutReceiptViewModel Put([FromUri] int bookId, [FromBody] CheckoutViewModel data)
        {
            var dbLibrary = new DataContext();
            var book = dbLibrary.Books.Single(i => i.ID == bookId);
            if (!book.IsCheckedOut)
            {
                book.IsCheckedOut = true;
                book.DueBackDate = DateTime.Now.AddDays(10);
                dbLibrary.SaveChanges();
                //TODO: add to ledger   

                return new CheckoutReceiptViewModel
                {
                    Message = "Please try again later",
                    DuebackDate = book.DueBackDate
                };
            }
            else
            {
                return new CheckoutReceiptViewModel
                {
                    Message = "Please try again later",
                    DuebackDate = book.DueBackDate
                };
            }
        }
    }
}

