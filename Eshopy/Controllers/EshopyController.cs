using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshopy.Models;
using System.Diagnostics;

namespace Eshopy.Controllers
{
    public class EshopyController : Controller
    {
        private EshopyContext storeDB = new EshopyContext();

        // GET: \store
        public ActionResult Index()
        {
            List <EshopyTypeModels>EshopyType = storeDB.EshopyTypes.ToList();
            return View(EshopyType);
        }

        public ActionResult Browse(string EshopyType)
        {
            //Debug.WriteLine(type);
            EshopyTypeModels eshopyTypesModel = storeDB.EshopyTypes.Include("EshopyItems").Single(g => g.Name == EshopyType);
            return View(eshopyTypesModel);
        }
        public ActionResult Details(int id = 1)
        {
            EshopyItemModels EshopyItem = storeDB.EshopyItems.Find(id);
            return View(EshopyItem);
        }
    }
}