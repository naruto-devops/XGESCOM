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
    public class ContactController : ControllerBase
    {
        IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }
        [HttpGet("Get")]
        public List<Contact> GetAll()
        {
            return _ContactService.GetAll();

        }
        [HttpGet("Find/{id}")]
        public Contact GetById(int id)
        {
            return _ContactService.GetById(id);

        }
        [HttpPost("Create")]
        public Contact Post([FromBody]Contact Contact)
        {
            if (ModelState.IsValid)
                _ContactService.Add(Contact);
            return Contact;

        }
        [HttpPut("Edit")]
        public Contact Put([FromBody]Contact Contact)
        {


            if (ModelState.IsValid)
                _ContactService.Update(Contact);
            return Contact;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
           
              return  _ContactService.Delete(id);
           
          

        }
    }
}