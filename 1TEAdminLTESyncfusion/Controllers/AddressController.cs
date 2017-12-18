using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using _1TE_MY.Models.Models;
using Microsoft.AspNetCore.Hosting;
using _1TE_MY.Services.Interfaces;
using System.Collections;
using _1TE_MY.Models.Models.DTO;

namespace _1TE_MY.Controllers
{
    public class AddressController : Controller
    {
        private IAddressService _addressService;
        private IHostingEnvironment hostingEnv;

        public AddressController(IAddressService addressService, IHostingEnvironment env)
        {
            _addressService = addressService;
            this.hostingEnv = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult UrlDataAddress([FromBody]DataManager dm)
        {
            IEnumerable data = _addressService.GetAllAddress();

            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                data = operation.PerformWhereFilter(data, dm.Where, dm.Where[0].Operator);
            }
            int count = data.Cast<Address>().Count();
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
        public ActionResult CellEditUpdate([FromBody]CRUDModel<Address> value)
        {
            var adr = value.Value;
            //if it{address 1 and Business type} will be drop down list; no need to get DTO just simple merchant model
            Address address = _addressService.GetAddressByCodeID(adr.AddressID);
            if (address != null)
            {
                //merch.GSTNo = mer.GSTNo;
                //merch.RegNo = mer.RegNo;
                //merch.MerchantName = mer.MerchantName;
                //merch.AgentCode = mer.AgentCode;
                //merch.BusinessType = mer.BusinessType;
                //merch.AddressID = mer.AddressID;
                _addressService.UpdateAddress(address);
            }
            return Json(value.Value);
        }
        //insert the record
        public ActionResult CellEditInsert([FromBody]CRUDModel<Address> value)
        {
            //listMerchant.Insert(0, value.Value);
            _addressService.UpdateAddress(value.Value);
            return Json(value);
        }
        //Delete the record
        public ActionResult CellEditDelete([FromBody]CRUDModel<AddressDTO> value)
        {
            //listMerchant.Remove(listMerchant.Where(or => or.MerchantID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }
    }
}