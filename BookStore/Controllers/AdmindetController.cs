using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AdmindetController : ApiController
    {
        private IAdmindetRepository repository;

        public AdmindetController()
        {
            repository = new AdmindetSqlImpl();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = repository.GetAllAdmindet();
            return Ok(data);
        }
    }
}
