using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1TE_MY.Services.Interfaces;
using Newtonsoft.Json;
using _1TE_MY.Helper;

namespace _1TE_MY.Controllers
{
    public class CommonController : Controller
    {
        private IMasterService _masterService;
        public IActionResult Index()
        {
            return View();
        }
        public CommonController(IMasterService masterService)
        {

            _masterService = masterService;
        }
        public async Task< IActionResult> GetMasters(Syncfusion.JavaScript.DataManager dataManagerObj, string value)
        {
            dynamic DataSource = new System.Dynamic.ExpandoObject();
            Syncfusion.JavaScript.DataSources.DataOperations operation = new Syncfusion.JavaScript.DataSources.DataOperations();

            switch (value)
            {
                case "Country":
                      DataSource = await  _masterService.GetAllCountries(); 
                     return  Json(operation.Execute(DataSource, dataManagerObj));
                case "Modules":
                      DataSource = await _masterService.GetAllMasterDetailsbyIds(new List<int>() { 12,10 });
                    return  Json(operation.Execute(DataSource, dataManagerObj));
                case "SecurityQuestion":
                    DataSource =await _masterService.GetAllMasterDetailsbyIds(new List<int>() { ModuleConstantHelper.SecurityModule });
                     return  Json(operation.Execute(DataSource, dataManagerObj));
                default:
                    return null;

            }


        }
    }
}