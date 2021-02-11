using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;



namespace Services.Implementations
{
    public class ParametresServices : IParametresService
    {
        IParametresRepository _ParametresRepository;


        public ParametresServices(IParametresRepository parametres)
        {
            _ParametresRepository = parametres;
        }


        public Parametres GetAll()
        {
            try
            {
                return _ParametresRepository.GetAll();

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
                _ParametresRepository.Update(parametres);
                return parametres;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool GetIncrementClient()
        {
            try
            {
                return _ParametresRepository.GetIncrClient();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string GetNumeroClient()
        {
            try
            {
                return _ParametresRepository.GetNumClient();
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
                return _ParametresRepository.GetClientGeneral();
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
                numcli.IncrementCode();
                _ParametresRepository.UpdateNUMCLI(numcli);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


    }
}
