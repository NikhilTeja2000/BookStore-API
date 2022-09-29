using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BookStore.Models;

namespace BookStore.Controllers
{
    public class UserOrderController : ApiController
    {

        private IUserOrderRepository repository;
        public UserOrderController()
        {
            repository = new UserOrderSqlImpl();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllUserOrder();
            return Ok(data);
        }
    }
}
