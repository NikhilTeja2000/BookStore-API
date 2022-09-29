using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BookStore.Models;
namespace BookStore.Controllers
{
    public class UserCartController : ApiController
    {
        private IUserCartRepository repository;
        public UserCartController()
        {
            repository = new UserCartSqlImpl();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllUserCart();
            return Ok(data);
        }
        public IHttpActionResult Delete(int id)
        {
            var data = repository.DeleteUserCart(id);
            return Ok(data);
        }
    }
}
