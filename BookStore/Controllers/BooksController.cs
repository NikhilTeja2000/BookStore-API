using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BookStore.Models;

namespace BookStore.Controllers
{
    public class BooksController : ApiController
    {
        private IBooksRepository repository;

        public BooksController()
        {
            repository = new BooksSqlImpl();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllBooks();
            return Ok(data);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var data = repository.GetAllBooksByBookId(id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(Books books)
        {
            var data = repository.AddBooks(books);
            return Ok(data);
        }
        [HttpPut]
        public IHttpActionResult Put(Books books,int id)
        {
        //   var data = repository.UpdateBooks(books);
        //   return Ok(data);
           repository.UpdateBooks(books,id);
           return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var data = repository.DeleteBooks(id);
            return Ok(data);
        }

    }
}
