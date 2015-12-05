using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Senai.DepModas.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public TYPE Type { get; set; }
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }
    }
}