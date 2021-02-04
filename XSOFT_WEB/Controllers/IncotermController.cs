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
    public class IncotermController : ControllerBase
    {
        IIncotermService _IncotermService;

        public IncotermController(IIncotermService incoterm)
        {
            _IncotermService = incoterm;
        }
        [HttpGet("Get")]
        public List<Incoterm> GetAll()
        {
            return _IncotermService.GetAll();

        }
        [HttpGet("Find/{id}")]
        public Incoterm GetById(int id)
        {
            return _IncotermService.GetById(id);

        }
        [HttpPost("Create")]
        public Incoterm Post([FromBody]Incoterm incoterm)
        {
            if (ModelState.IsValid)
                _IncotermService.Add(incoterm);
            return incoterm;
        }
        [HttpPut("Edit")]
        public Incoterm Put([FromBody]Incoterm incoterm)
        {


            if (ModelState.IsValid)
                _IncotermService.Update(incoterm);
            return incoterm;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
             bool res = false;

            if (_IncotermService.CheckIncoterm_ExistClient(id) == false)
            {
                _IncotermService.Delete(id);
                res = true;
            }
            return res;
        }
    }
}