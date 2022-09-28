using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class UserdetController : ApiController
    {
        private IUserdetRepository repository;
        public UserdetController()
        {
            repository = new UserdetSqlImpl();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllUserdet();
            return Ok(data);
        }
    }
}
