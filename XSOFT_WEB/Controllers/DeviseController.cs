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

        public DeviseController(IDeviseService dvs)
        {
            _DeviseService = dvs;
        }
        [HttpGet("Get")]
        public List<Devise> GetAll()
        {
            return _DeviseService.GetAll();

        }
        [HttpGet("Find/{id}")]
        public ActionResult<Devise> GetById(int id)
        {
            var res = _DeviseService.GetById(id);
            if (res is null)
                return NotFound();
            else
                return Ok(res);

        }
        [HttpPost("Create")]
        public Devise Post([FromBody]Devise devise)
        {
            Devise res = new Devise();
            if (ModelState.IsValid)
                                 res  =   _DeviseService.Add(devise);
            if (res is null)
                return null;
            else
            return devise;
        }
        [HttpPut("Edit")]
        public Devise Put([FromBody]Devise dvs)
        {


            if (ModelState.IsValid)
                _DeviseService.Update(dvs);
            return dvs;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
           

            //  if (_DeviseService.CheckDev_ExistClient(id)==false)
            //  {
            
                
            
           
                return  _DeviseService.Delete(id);
           



        }
    }
}