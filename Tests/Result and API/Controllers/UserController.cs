using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Result_and_API.DOMAIN.Entities;
using Result_and_API.DOMAIN.Interfaces.Service;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Net;
using System.Threading.Tasks;
using System;

namespace Result_and_API.Controllers
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
        [ProducesResponseType(typeof(Result<Administrator>), 200)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Result<Administrator>>> GetById(int id)
        {
            try
            {
                var result = await _service.FindUserById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Um erro inesperado ocorreu. Favor contatar o administrador do sistema.");
            }
        }


        [HttpGet("/todos")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = await _service.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Um erro inesperado ocorreu. Favor contatar o administrador do sistema.");
            }
        }
    }
}
