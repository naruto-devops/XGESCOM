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
        public Devise GetById(int id)
        {
            return _DeviseService.GetById(id);

        }
        [HttpPost("Create")]
        public Devise Post([FromBody]Devise dvs)
        {
            if (ModelState.IsValid)
                _DeviseService.Add(dvs);
            return dvs;
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
            bool res = false;

            if (_DeviseService.CheckDev_ExistClient(id)==false)
            {
                _DeviseService.Delete(id);
                res = true;
            }

            return res;
            

        }
    }
}