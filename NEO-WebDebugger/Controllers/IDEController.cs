﻿using Neo.Debugger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neo.WebDebugger.Controllers
{
    public class IDEController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}