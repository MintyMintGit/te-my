using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _1TE_MY.Models;
using System.Collections;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;

namespace _1TE_MY.Controllers
{
    public class MerchantController : Controller
    {
        public static List<Merchant> listMerchant = new List<Merchant>();

        // GET: Merchant
        public ActionResult Index()
        {
            Merchant test = new Merchant();
            test.CompanyRegisterationNumber = "123";
            test.GSTRegisterationNumber = "123";
            test.MerchantID = 555;
            test.MerchantName = "Dana";

            listMerchant.Add(test);
            test = new Merchant();
            test.CompanyRegisterationNumber = "456";
            test.GSTRegisterationNumber = "456";
            test.MerchantID = 777;
            test.MerchantName = "Mima";
            listMerchant.Add(test);
            return View();
        }

        public ActionResult UrlDataMerchant([FromBody]DataManager dm)
        {
            IEnumerable data = listMerchant.ToList();
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

            var temp = Json(new { result = data, count = count });
            return temp;
        }

        //Update the data
        public ActionResult CellEditUpdate([FromBody]CRUDModel<Merchant> value)
        {
            var mer = value.Value;
            Merchant merch = listMerchant.Where(or => or.MerchantID == mer.MerchantID).FirstOrDefault();
            merch.MerchantID = mer.MerchantID;
            merch.GSTRegisterationNumber = mer.GSTRegisterationNumber;
            merch.CompanyRegisterationNumber = mer.CompanyRegisterationNumber;
            merch.MerchantName = mer.MerchantName;
            return Json(value.Value);
        }
        //insert the record
        public ActionResult CellEditInsert([FromBody]CRUDModel<Merchant> value)
        {
            listMerchant.Insert(0, value.Value);
            return Json(value);
        }
        //Delete the record
        public ActionResult CellEditDelete([FromBody]CRUDModel<Merchant> value)
        {
            //listMerchant.Remove(listMerchant.Where(or => or.MerchantID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }

    }
}