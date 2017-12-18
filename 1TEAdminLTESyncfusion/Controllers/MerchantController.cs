using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using _1TE_MY.Models.Models.DTO;
using SyncFusion.Services;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;

namespace _1TE_MY.Controllers
{
    public class MerchantController : Controller
    {
        private IMerchantService _merchantService;
        private IHostingEnvironment hostingEnv;
        
        public MerchantController(IMerchantService merchantService, IHostingEnvironment env)
        {
            _merchantService = merchantService;
            this.hostingEnv = env;
        }

        // GET: Merchant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrlDataMerchant([FromBody]DataManager dm)
        {
            IEnumerable data = _merchantService.GetAllMerchants();

            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                data = operation.PerformWhereFilter(data, dm.Where, dm.Where[0].Operator);
            }
            int count = data.Cast<Merchant>().Count();
            if (dm.Skip != 0)
            {
                data = operation.PerformSkip(data, dm.Skip);
            }
            if (dm.Take != 0)
            {
                data = operation.PerformTake(data, dm.Take);
            }

            return Json(new { result = data, count = count });
        }

        //Update the data
        public ActionResult CellEditUpdate([FromBody]CRUDModel<Merchant> value)
        {
            var mer = value.Value;
            //if it{address 1 and Business type} will be drop down list; no need to get DTO just simple merchant model
            Merchant merch = _merchantService.GetMerchantByCodeID(mer.MerchantCodeID);
            if (merch != null)
            {
                merch.GSTNo = mer.GSTNo;
                merch.RegNo = mer.RegNo;
                merch.MerchantName = mer.MerchantName;
                merch.AgentCode = mer.AgentCode;
                merch.BusinessType = mer.BusinessType;
                merch.AddressID = mer.AddressID;
                _merchantService.UpdateMerchant(merch);
            }
            return Json(value.Value);
        }
        //insert the record
        public ActionResult CellEditInsert([FromBody]CRUDModel<Merchant> value)
        {
            //listMerchant.Insert(0, value.Value);
            _merchantService.UpdateMerchant(value.Value);
            return Json(value);
        }
        //Delete the record
        public ActionResult CellEditDelete([FromBody]CRUDModel<MerchantDTO> value)
        {
            //listMerchant.Remove(listMerchant.Where(or => or.MerchantID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }
        public ActionResult Add()
        {

            /*this code nned to put to*/
            IEnumerable<BusinessType> businessType = new List<BusinessType>
            {
                new BusinessType { Id = 1, Name = "Apple" },
                new BusinessType { Id = 2, Name = "Samsung" },
                new BusinessType { Id = 3, Name = "Microsoft" }
            };
            //ViewBag.businessType = businessType;
            ViewBag.businessType = new SelectList(businessType, "Id", "Name");

            //need get MerchantDTO;
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateMerchant(MerchantDTO merchant)
        {
            merchant.AddOn = DateTime.Now;
            merchant.CreditorCode = "23";
            merchant.DebtorCode = "23";
            merchant.EDIMappingCode = "23";
            merchant.OwnerCode = "23";
            merchant.PortCode = "23";
            merchant.YardCode = "23";
            merchant.BillingMethod = 10;
            merchant.CreditTerm = 10;
            merchant.CreditLimit = 10;
            merchant.DefaultCurrency = "123";
            merchant.CreditorCode = "123";
            merchant.DebtorCode = "";
            merchant.EDIMappingCode = "";
            merchant.IsLiner = false;
            merchant.IsYard = false;
            merchant.IsCFS = false;
            merchant.IsRailOperator = false;
            merchant.IsTerminal = false;
            merchant.IsVMIVendor = false;
            merchant.IsRailYard = false;
            merchant.IsTaxable = false;
            merchant.IsSelectContainer = false;
            merchant.CurrentBalance = 36.66m;
            merchant.IsActive = true;
            merchant.AddOn = DateTime.Now;
            merchant.ModOn = DateTime.Now;
            merchant.IsVerified = true;
            merchant.CompanyCodeID = 123;
            _merchantService.AddMerchant(merchant);

            return View("Add");
        }
    }
}