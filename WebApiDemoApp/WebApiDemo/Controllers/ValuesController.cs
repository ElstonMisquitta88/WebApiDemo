using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Script> lst = new List<Script>();
            Script _Val01 = new Script
            {
                Symbol = "JKPaper",
                Qty = 3,
                Rate = 250,
                PurchaseDate = "20220302"
            };
            lst.Add(_Val01);


            Script _Val02 = new Script
            {
                Symbol = "IRCTC",
                Qty = 12,
                Rate = 550,
                PurchaseDate = "20220215"
            };
            lst.Add(_Val02);

            return Ok(lst);
        }
    }
}
