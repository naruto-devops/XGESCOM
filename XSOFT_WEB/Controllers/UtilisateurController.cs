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
    public class UtilisateurController : ControllerBase
    {
        IUtilisateurService _UtilisateurService;

        public UtilisateurController(IUtilisateurService mdt)
        {
            _UtilisateurService = mdt;
        }
        [HttpGet("Get")]
        public List<Utilisateur> GetAll()
        {
            return _UtilisateurService.GetAll();

        }
        [HttpGet("Find/{id}")]
        public Utilisateur GetById(int id)
        {
            return _UtilisateurService.GetById(id);

        }
        [HttpPost("Create")]
        public Utilisateur Post([FromBody]Utilisateur mdt)
        {
            if (ModelState.IsValid)
                _UtilisateurService.Add(mdt);
            return mdt;

        }
        [HttpPut("Edit")]
        public Utilisateur Put([FromBody]Utilisateur mdt)
        {


            if (ModelState.IsValid)
                _UtilisateurService.Update(mdt);
            return mdt;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;
             var result = _UtilisateurService.Delete(id);

            return  res;

        }
    }
}