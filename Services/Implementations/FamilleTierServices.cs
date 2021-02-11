using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public class FamilleTierServices : IFamilleTierService
    {
        IFamilleTierRepository _FamilleTierRepository;

        public FamilleTierServices(IFamilleTierRepository fat)
        {
            _FamilleTierRepository = fat;
        }

      

        public List<FamilleTier> GetAll()
        {
            List<FamilleTier> result = new List<FamilleTier>();
            try
            {
                result = _FamilleTierRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public FamilleTier GetById(int id)
        {
            try
            {
                return _FamilleTierRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public FamilleTier Add(FamilleTier fat)
        {
            try
            {
                _FamilleTierRepository.Add(fat);

                return fat;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public FamilleTier Update(FamilleTier fat)
        {
            try
            {
                _FamilleTierRepository.Update(fat);
                return fat;
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
                return _FamilleTierRepository.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Client CheckFamilleTier_ExistClient(int id)
        {
            try
            {
                return _FamilleTierRepository.GetByClient(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
