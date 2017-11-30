using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1TE_MY.Models;
using Microsoft.AspNetCore.Http;
using SyncFusion.Services;
using _1TE_MY.Models.DTO;
using _1TE_MY.Services.Interfaces;
using Newtonsoft.Json;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using System.Collections;
using _1TE_MY.Helper;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace _1TE_MY.Controllers
{
    public class AccountController : Controller
    {
        private IOrderService _orderService;
        private IContactService _contactService;
        private IMasterService _masterService;
        private IRegistrationService _registrationService;
        public AccountController(IOrderService orderService, IContactService contactService, IMasterService masterService
            , IRegistrationService registrationService)
        {
            _orderService = orderService;
            _contactService = contactService;
            _masterService = masterService;
            _registrationService = registrationService;
        }
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Employees model)
        {
            if (ModelState.IsValid)
            {
                //string userSession = Guid.NewGuid().ToString();
                HttpContext.Session.SetInt32("init", 0);
                HttpContext.Session.SetString("SessionId", HttpContext.Session.Id);
                try
                {
                    var empUser = _orderService.CheckLogin(model);

                    if (empUser != null)
                    {
                        HttpContext.Session.SetInt32("UserID", empUser.EmployeeID);
                        HttpContext.Session.SetString("UserName", empUser.Email);
                        return RedirectToAction("Index", "Home");
                    }

                }
                catch
                {
                    throw;
                }
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View();
        }

        public async Task<IActionResult> Registration()
        {
            ViewBag.Country = await _masterService.GetAllCountries();
            ViewBag.CountryCodeDataSource = _contactService.GetCountryList();
            ViewBag.DesignationDataSource =await _masterService.GetMasterDetails(ModuleConstantHelper.DesignationModule);
			ViewBag.OrganisationDataSource = await _masterService.GetMasterDetails(ModuleConstantHelper.OrganisationModule);


			ViewBag.Country_Cascading = await _masterService.GetAllCountries_Cascading();
			ViewBag.State_Cascading = await _masterService.GetAllStatesbyCountry_Cascading(0);
			ViewBag.City_Cascading = await _masterService.GetAllCitiesbyStates_Cascading(0);
			Registeration Registerationmodel = new Registeration();
            List<Registration_Modules> lstModules = new List<Registration_Modules>();


            //ViewBag.DataSource = lstModules;
            ViewBag.DataSource = await _masterService.GetMasterDetails(ModuleConstantHelper.Module);

            Registerationmodel.Registration_Documents = new List<Registration_Documents>();
            Registerationmodel.Registration_Documents.Add(new Registration_Documents() { DocumentType = "FORM 9 – CERTIFICATE OF INCORPORATION", FileName = "FUEL RECORD.PNG", IsMandatory = true, Sno = "1" });
            Registerationmodel.Registration_Documents.Add(new Registration_Documents() { DocumentType = "FORM 13 – CERTIFICATION OF INCORPORATION ON CHANGE OF COMPANY NAME", FileName = "FUEL RECORD.PNG", IsMandatory = false, Sno = "2" });
            Registerationmodel.Registration_Documents.Add(new Registration_Documents() { DocumentType = "FORM 49 – PARTICULARS OF DIRECTORS, MANAGERS AND SECRETARIES", FileName = "FUEL RECORD.PNG", IsMandatory = true, Sno = "3" });
            Registerationmodel.Registration_Documents.Add(new Registration_Documents() { DocumentType = "SURAT PENDAFTARAN GST (GST REGISTRATION LETTER)", FileName = "FUEL RECORD.PNG", IsMandatory = true, Sno = "4" });

            return View(Registerationmodel);
        }

        public IActionResult LogOut(Employees model)
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public IActionResult Register(Employees model)
        {

            HttpContext.Session.Clear();
            return View();
        }


        [HttpPost]
        public IActionResult AddContact(List<Registration_ContactPerson> model)
        {
            model[0].ContactTypeID = 1;
            model[1].ContactTypeID = 2;

            _contactService.AddContact(model);
            return Json(true);
        }

		[HttpPost]
		public IActionResult AddCompany(Registration_CompanyInformation model)
		{
			//model[0].ContactTypeID = 1;
			//model[1].ContactTypeID = 2;

			_registrationService.UpdateCompanyInformation(model);
			return Json(true);
		}
		[HttpPost]
        public IActionResult SaveRegistration(Registration_UserInformation model)
        {

            _registrationService.SaveRegistartion(model);
            return Json(true);
        }
    }

    public class DataResult
    {
        public IEnumerable result { get; set; }
        public int count { get; set; }
    }
}
