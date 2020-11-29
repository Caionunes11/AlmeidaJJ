using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almeida.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
