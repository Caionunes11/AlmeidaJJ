using Almeida.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Almeida.WebApi.Controllers
{

    [ApiController]
    [Route("AlmeidaJJ")]
    [Produces("application/json")]

    public class AlmeidaJJController : ControllerBase
    {
        private readonly IPessoaServices _pessoaServices;

        public AlmeidaJJController(IPessoaServices pessoaServices)
        {
            _pessoaServices = pessoaServices;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetbyAll()
        {
            try
            {

                var teste = _pessoaServices.GetByAll();
                return Ok(teste);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }




    }


}
