using DevOpsCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DevOpsCalc.Controllers
{
    public class OperatorsController: Controller
    {
        //    
        // GET: /Home/    
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(OperatorsModel model, string command)
        {
            if (command == "add")
            {
                model.Answer = model.FirstNum + model.SecondNum;
            }
            if (command == "subtract")
            {
                model.Answer = model.FirstNum - model.SecondNum;
            }
            return View(model);
        }
    }
}