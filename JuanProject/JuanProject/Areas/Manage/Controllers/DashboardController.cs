﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanProject.Areas.Manage.Controllers
{

    public class DashboardController : Controller
    {
        [Manage]
        public IActionResult Index()
        {
            return View();
        }
    }
}
