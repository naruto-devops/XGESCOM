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
            return _ParametresRepository.GetAll();
        }

        public Parametres Update(Parametres parametres)
        {
            _ParametresRepository.Update(parametres);
            return parametres;
        }

        public int Check_IncrementCodification()
        {
            Parametres resultParametre = new Parametres();
            resultParametre = _ParametresRepository.GetAll();
            return resultParametre.INCCLI;

        }


        public bool UpdateNUMCLI(string numcli)
        {
            try
            {
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
