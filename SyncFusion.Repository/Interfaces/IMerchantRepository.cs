using _1TE_MY.Models.Models;
using _1TE_MY.Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1TE_MY.Repository.Interfaces
{
    public interface IMerchantRepository
    {
        List<Merchant> GetAllMerchants();
        Merchant GetMerchantByCodeID(int CodeID);
        List<Merchant> AddMerchant(Merchant merchant);
        int UpdateMerchant(Merchant merchant);
    }
}
