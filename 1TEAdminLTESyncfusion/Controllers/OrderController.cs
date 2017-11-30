using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SyncFusion.Services;
using _1TE_MY.Models.DTO;
using _1TE_MY.Models;
using Syncfusion.JavaScript.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace _1TE_MY.Controllers
{
    
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IHostingEnvironment hostingEnv;

        public OrderController(IOrderService orderService, IHostingEnvironment env)
        {
            _orderService = orderService;
            this.hostingEnv = env;
        }
         
        public IActionResult Grid()
        {
            int? EmpId =HttpContext.Session.GetInt32("UserID");
            if (EmpId > 0)
            {
                var orders = _orderService.GetAllOrders((int)EmpId);
                return View(orders);
            }
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Index()
        {
            int? EmpId = HttpContext.Session.GetInt32("UserID");
            if (EmpId > 0)
            {
                OrderDTO orderDTO = _orderService.GetOrderDto();
                return View(orderDTO);
            }
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDTO orderDto,IFormCollection collection)
        {
            if (ModelState.IsValid && ModelState.ErrorCount <=3) 
            {
                orderDto.OrderDate = Convert.ToDateTime(collection["OrderDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                orderDto.RequiredDate = Convert.ToDateTime(collection["RequiredDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                orderDto.ShippedDate = Convert.ToDateTime(collection["ShippedDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                orderDto.ProductID = Convert.ToInt32(collection["ProductID"]);
                orderDto.EmployeeID = (int)HttpContext.Session.GetInt32("UserID");
                List<Orders> ListOrders = _orderService.AddOrder(orderDto);                
                return View("Grid", ListOrders);
            }
            else                
            {
                ViewBag.Message = "All fields are required.";
            }
            return View("Index", _orderService.GetOrderDto());
        }

        [HttpGet]        
        public IActionResult EditOrders(int OrderId)
        {
            var order = _orderService.GetOrderByOrderId(OrderId);            
            return View("EditOrders", order);
        }

        [HttpPost]        
        public IActionResult EditOrders(OrderDTO orderDto,IFormCollection collection)
        {
            if (ModelState.IsValid && ModelState.ErrorCount <= 3)
            {
                
                try
                {
                    orderDto.EmployeeID = (int)HttpContext.Session.GetInt32("UserID");
                    orderDto.OrderDate = Convert.ToDateTime(collection["OrderDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                    orderDto.RequiredDate = Convert.ToDateTime(collection["RequiredDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                    orderDto.ShippedDate = Convert.ToDateTime(collection["ShippedDate"], System.Globalization.CultureInfo.GetCultureInfo("en-us").DateTimeFormat);
                    orderDto.ProductID = Convert.ToInt32(collection["ProductID"]);
                    var success = _orderService.UpdateOrder(orderDto);

                    return RedirectToAction("Grid", "order");
                }
                catch {
                    ViewBag.Message = "Some error Occured";
                    return RedirectToAction("EditOrders", new { OrderId = orderDto.OrderID });
                }
            }
            else
            {
                ViewBag.Message = "All fields are required.";
            }
            return RedirectToAction("EditOrders",new { OrderId=orderDto.OrderID });
        }

       
       
        public IActionResult DeleteOrders(int OrderId)
        {            
            int? EmpId = HttpContext.Session.GetInt32("UserID");
            if (EmpId > 0)
            {
                var orders = _orderService.GetAllOrders((int)EmpId);
                try
                {
                    var order = _orderService.Delete(OrderId);
                    ViewBag.Message = "Order Deleted Successfully!";
                   
                    ViewBag.Message = "Order " + OrderId + " deleted Successfully";
                    return View("Grid", orders);
                }
                catch
                {
                    ViewBag.Message = "Some error occured!.";
                    return View("Grid", orders);
                }
            }
            return RedirectToAction("Login", "Account");
        }

                          
        List<MenuJson> menu = new List<MenuJson>();
        public ActionResult Controls()
        {
            menu.Add(new MenuJson { pid = 1, mtext = "Group A", parent = null });
            menu.Add(new MenuJson { pid = 2, mtext = "Group B", parent = null });
            menu.Add(new MenuJson { pid = 3, mtext = "Group C", parent = null });
            menu.Add(new MenuJson { pid = 4, mtext = "Group D", parent = null });
            menu.Add(new MenuJson { pid = 5, mtext = "Group E", parent = null });
            menu.Add(new MenuJson { pid = 11, parent = "1", mtext = "Algeria" });
            menu.Add(new MenuJson { pid = 12, parent = "1", mtext = "Armenia" });
            menu.Add(new MenuJson { pid = 13, parent = "1", mtext = "Bangladesh" });
            menu.Add(new MenuJson { pid = 14, parent = "1", mtext = "Cuba" });
            menu.Add(new MenuJson { pid = 15, parent = "2", mtext = "Denmark" });
            menu.Add(new MenuJson { pid = 16, parent = "2", mtext = "Egypt" });
            menu.Add(new MenuJson { pid = 17, parent = "3", mtext = "Finland" });
            menu.Add(new MenuJson { pid = 18, parent = "3", mtext = "India" });
            menu.Add(new MenuJson { pid = 19, parent = "3", mtext = "Malaysia" });
            menu.Add(new MenuJson { pid = 20, parent = "4", mtext = "New Zealand" });
            menu.Add(new MenuJson { pid = 21, parent = "4", mtext = "Norway" });
            menu.Add(new MenuJson { pid = 22, parent = "4", mtext = "Romania" });
            menu.Add(new MenuJson { pid = 23, parent = "5", mtext = "Singapore" });
            menu.Add(new MenuJson { pid = 24, parent = "5", mtext = "Thailand" });
            menu.Add(new MenuJson { pid = 25, parent = "5", mtext = "Ukraine" });
            menu.Add(new MenuJson { pid = 26, parent = "11", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 27, parent = "12", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 28, parent = "13", mtext = "Third place" });
            menu.Add(new MenuJson { pid = 29, parent = "14", mtext = "Fourth Place" });
            menu.Add(new MenuJson { pid = 30, parent = "15", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 31, parent = "16", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 32, parent = "17", mtext = "Third Place" });
            menu.Add(new MenuJson { pid = 33, parent = "18", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 34, parent = "19", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 36, parent = "21", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 37, parent = "22", mtext = "Third place" });
            menu.Add(new MenuJson { pid = 39, parent = "24", mtext = "First Place" });
            menu.Add(new MenuJson { pid = 40, parent = "25", mtext = "Second Place" });
            ViewBag.datasource = menu;
            return View();
        }


        public IActionResult UploadFiles(IList<IFormFile> UploadDefault)
        {
            long size = 0;
            foreach (var file in UploadDefault)
            {
                var filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                                .FileName
                                .Trim('"');
                filename = hostingEnv.WebRootPath + $@"\{filename}";
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            return Content("");
        }

        public class MenuJson
        {
            public string mtext { get; set; }
            public int pid { get; set; }
            public string parent { get; set; }
        }
    }
}