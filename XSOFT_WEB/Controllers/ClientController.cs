using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
   // [EnableCors("AllowOrigin")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientService _clientService;
     
       


        public ClientController(IClientService client)
        {
            _clientService = client;
          
        }
        [HttpGet("Get")]
        public List<Client> GetAll()
        {
         



            return _clientService.GetAll();
        }
        [HttpGet("Find/{id}")]
        public Client GetById(int id)
        {
            return _clientService.GetById(id);

        }
        [HttpPost("Create")]
        public Client Post([FromBody]Client client)
        {
            if (ModelState.IsValid)
                _clientService.Add(client);
            return client;
           

        }
        [HttpPut("Edit")]
        public Client Put( [FromBody]Client client)
        {


            if (ModelState.IsValid)
                _clientService.Update(client);
            return client;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res = false;

            if (_clientService.CheckClient_ExistDocLig(id) == false)
            {
                _clientService.Delete(id);
                res = true;

            }

            return res;
            
           

        }

    }
}