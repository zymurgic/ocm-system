﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCM.MVC.Controllers
{
    public class DevelopController : Controller
    {
        //
        // GET: /Develop/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// /Develop/Apps
        /// </summary>
        /// <returns></returns>
        public ActionResult Apps()
        {
            return View();
        }
    }
}
