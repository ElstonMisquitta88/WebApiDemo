using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockView.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace StockView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object JsonConvert { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Index()
        {
            Script obj = new Script();
            obj.PurchaseDate = "20230202";
            return View(obj);


            //using (HttpClient client = new HttpClient())
            //{
            //    //StringContent content = new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8, "application/json");
            //    string endpoint = "https://localhost:44341/api/Values";
            //    using (var Response = await client.GetAsync(endpoint))
            //    {
            //        if (Response.StatusCode == System.Net.HttpStatusCode.OK)
            //        {
            //            var contents = await Response.Content.ReadAsByteArrayAsync();

            //            //TempData["Profile"] = JsonConvert.SerializeObject(user);
            //            return View();
            //        }
            //        else
            //        {
            //            ModelState.Clear();
            //            ModelState.AddModelError(string.Empty, "Username or Password is Incorrect");
            //            return View();
            //        }
            //    }
            //}
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
