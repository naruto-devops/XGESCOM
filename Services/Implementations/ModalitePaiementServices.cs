using Models;
using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class ModalitePaiementServices : IModalitePaiementService
    {
        IModalitePaiementRepository _ModalitePaiementRepository;

        public ModalitePaiementServices(IModalitePaiementRepository fat)
        {
            _ModalitePaiementRepository = fat;
        }

      
        public List<ModalitePaiement> GetAll()
        {
            List<ModalitePaiement> result = new List<ModalitePaiement>();
            try
            {
                result = _ModalitePaiementRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ModalitePaiement GetById(int id)
        {
            try
            {
                return _ModalitePaiementRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ModalitePaiement Add(ModalitePaiement mod)
        {
            try
            {
                _ModalitePaiementRepository.Add(mod);

                return mod;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ModalitePaiement Update(ModalitePaiement mod)
        {
            try
            {
                _ModalitePaiementRepository.Update(mod);
                return mod;
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
                return _ModalitePaiementRepository.Delete(id);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Client CheckModalite_ExistClient(int id)
        {
            try
            {
                return _ModalitePaiementRepository.GetByClient(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

    }
}
