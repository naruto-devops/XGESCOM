using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviseController : ControllerBase
    {
        IDeviseService _DeviseService;

        public DeviseController(IDeviseService devise)
        {
            _DeviseService = devise;
        }
        [HttpGet("Get")]
        public List<Devise> GetAll()
        {
           var res= _DeviseService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Find/{id}")]
        public Devise GetById(int id)
        {
            try
            {
                var res = _DeviseService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
            

        }
        [HttpPost("Create")]
        public ActionResult<Devise> Post([FromBody]Devise devise)
        {
           
            var res  =   _DeviseService.Add(devise);
            if (res is null)
                return BadRequest(); 
            else
                return devise;
        }
        [HttpPut("Edit")]
        public ActionResult<Devise> Put([FromBody]Devise devise)
        {
           var res = _DeviseService.Update(devise);

            if (res is null)
                return BadRequest(); 
            else
                return devise;
        }
        [HttpDelete("Delete/{id}")]

        public bool Delete(int id)
        {

            bool res = false;

            if (_DeviseService.CheckDevise_ExistClient(id) == null)
            {
                _DeviseService.Delete(id);
                res = true;
            }

            return res;

        }
    }
}