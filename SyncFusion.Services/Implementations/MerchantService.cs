using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using _1TE_MY.Repository.Interfaces;
using _1TE_MY.Models.Models.DTO;
using AutoMapper;

namespace SyncFusion.Services
{
    public class MerchantService : IMerchantService
    {
        private IMerchantRepository _merchantRepository;
        public MerchantService(IMerchantRepository MerchantRepository)
        {
            _merchantRepository = MerchantRepository;
        }

        public List<Merchant> AddMerchant(MerchantDTO merchant)
        {
            Merchant merchantMerj = Mapper.Map<Merchant>(merchant);
            return _merchantRepository.AddMerchant(merchantMerj);
        }

        public List<Merchant> GetAllMerchants()
        {
            return _merchantRepository.GetAllMerchants();
        }

        public Merchant GetMerchantByCodeID(int CodeID)
        {
            return _merchantRepository.GetMerchantByCodeID(CodeID);
        }

        public int UpdateMerchant(Merchant merchant)
        {
            return _merchantRepository.UpdateMerchant(merchant);
        }
    }
}
