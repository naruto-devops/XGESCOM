using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class CategorieTarifServices : ICategorieTarifService
    {

        ICategorieTarifRepository _CategorieTarifRepository;

        public CategorieTarifServices(ICategorieTarifRepository categorie)
        {
            _CategorieTarifRepository = categorie;
        }

        public Client CheckCategorie_ExistClient(int id)
        {
            try
            {
                return _CategorieTarifRepository.GetByClient(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            
            
        }

        public List<CategorieTarif> GetAll()
        {
            List<CategorieTarif> result = new List<CategorieTarif>();

            try
            {
                result = _CategorieTarifRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CategorieTarif GetById(int id)
        {
            try
            {
                return _CategorieTarifRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CategorieTarif Add(CategorieTarif categorie)
        {
            try
            {
                var res = _CategorieTarifRepository.Add(categorie);
                return categorie;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public CategorieTarif Update(CategorieTarif categorie)
        {
            try
            {
                _CategorieTarifRepository.Update(categorie);
                return categorie;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return _CategorieTarifRepository.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
