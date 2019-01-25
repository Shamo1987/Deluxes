using Deluxes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deluxes.Controllers
{
    public class HomeController : Controller
    {
        DeluxesContext _context=new DeluxesContext();
        // GET: Home
        public ActionResult Index()
        {

            var products = _context
                .Products
                .Where(i => i.isApproved == true && i.isHome == true)
                .ToList();

            return View(products);
        }
    
    }
}