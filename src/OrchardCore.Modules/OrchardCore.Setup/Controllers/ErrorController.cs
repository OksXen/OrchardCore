using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Setup.ViewModels;

namespace OrchardCore.Setup.Controllers
{
    public class ErrorController: Controller
    {

        public ErrorController()
        {

        }

        public ActionResult Index()
        {
            var errorViewModel = new ErrorViewModel() { ErrorMessage = "Test Error message" };

            return View(errorViewModel);
        }
    }
}
