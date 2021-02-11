using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class ParametresRepository : IParametresRepository
    {

        XSoftContext _context;
        public ParametresRepository(XSoftContext context)
        {
            _context = context;
        }


        public Parametres GetAll()
        {
            var res = new Parametres();

            try
            {
                res = _context.Parametres.FirstOrDefault();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Parametres Update(Parametres parametres)
        {
            try
            {
                _context.Update(parametres);
                _context.SaveChanges();
                return parametres;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        


        public bool GetIncrClient()
        {
            try
            {
            var    res = _context.Parametres.FirstOrDefault();
                return res.INCCLI;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetNumClient()
        {
            try
            {
                var res = _context.Parametres.FirstOrDefault();
                return res.NUMCLI;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateNUMCLI(string numcli)
        {
            try
            {
               var  res = _context.Parametres.FirstOrDefault();
                res.NUMCLI = numcli;
                _context.Parametres.Update(res);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public string GetClientGeneral()
        {
            try
            {
                var res = _context.Parametres.FirstOrDefault();
                return res.ClientGen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
