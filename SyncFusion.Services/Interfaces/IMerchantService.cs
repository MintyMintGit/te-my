using _1TE_MY.Models.Models;
using _1TE_MY.Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFusion.Services
{
    public interface IMerchantService
    {
        List<Merchant> GetAllMerchants();
        Merchant GetMerchantByCodeID(int CodeID);
        List<Merchant> AddMerchant(MerchantDTO merchant);
        int UpdateMerchant(Merchant merchant);
    }
}
