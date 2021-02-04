using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametresController : ControllerBase
    {
        IParametresService _ParametresService;

        public ParametresController(IParametresService parametre)
        {
            _ParametresService = parametre;
        }

        [HttpGet("Get")]
        public IActionResult GetAll()
        {
          
            var res=_ParametresService.GetAll();
            if (res != null)
                return Ok(res);
            else
                return NotFound();

        }
        
       
       
        [HttpPut("Edit")]
        public Parametres Put([FromBody]Parametres parametre)
        {


            if (ModelState.IsValid)
                _ParametresService.Update(parametre);
            return parametre;

        }
        
    }
}