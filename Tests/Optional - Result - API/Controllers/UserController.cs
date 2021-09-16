using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Optional___Result___API.DOMAIN.Entities;
using Optional___Result___API.DOMAIN.Interfaces.Service;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Net;

namespace Optional___Result___API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    
    public class UserController : ControllerBase
    {
        private readonly IService _service;
        public UserController(IService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public OkObjectResult GetById(int id)
        {
            var result = _service.FindUserById(id);
            return Ok(result);
        }

       

        [HttpGet("/todos")]
        public Result<User> GetAll()
        {
            return _service.GetAll();
        }
    }
}
