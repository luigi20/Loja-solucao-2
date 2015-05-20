using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.Controllers
{
    public class DepartamentosController : Controller
    {
        //
        // GET: /Departamentos/
        private Loja.Models.Departamento da;
        
        public ActionResult Index()
        {
            return View();
        }

    }
}
