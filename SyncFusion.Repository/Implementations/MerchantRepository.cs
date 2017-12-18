using _1TE_MY.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using _1TE_MY.Models.Models;
using System.Linq;


namespace _1TE_MY.Repository.Implementations
{
    public class MerchantRepository : IMerchantRepository
    {
        private _1TEDBContext _context;
        public MerchantRepository(_1TEDBContext context)
        {
            _context = context;
        }
        public List<Merchant> GetAllMerchants()
        {
            return _context.Merchants.ToList();
        }

        public Merchant GetMerchantByCodeID(int CodeID)
        {
            return _context.Merchants.Where(m => m.MerchantCodeID == CodeID).FirstOrDefault();
        }

        public List<Merchant> AddMerchant(Merchant merchant)
        {
            if (merchant != null)
            {
                _context.Add(merchant);
                _context.SaveChanges();
            }
            return GetAllMerchants();
        }

        public int UpdateMerchant(Merchant merchant)
        {
            if (merchant != null && merchant.MerchantCodeID > 0)
            {
                Merchant oldMerchant = GetMerchantByCodeID(merchant.MerchantCodeID);
                if (oldMerchant != null)
                {
                    oldMerchant.MerchantName = merchant.MerchantName;
                    oldMerchant.RegNo = merchant.RegNo;
                    oldMerchant.GSTNo = merchant.GSTNo;
                    oldMerchant.AgentCode = merchant.AgentCode;
                    oldMerchant.BusinessType = merchant.BusinessType;
                    oldMerchant.AddressID = merchant.AddressID;
                    _context.SaveChanges();
                }
                return merchant.MerchantCodeID;
            }
            return 0;
        }
    }
}
