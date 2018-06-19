using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VueDemo.Models;

namespace VueDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 请求
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]//添加Authorize标签，可以加在方法上，也可以加在类上
        [Route("Home/GET")]
        public JsonResult GET()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var id = claimsIdentity.Claims.FirstOrDefault().Value;
            return Json($"Hello! {HttpContext.User.Identity.Name}, your ID is:{id}");
        }
    }
}
