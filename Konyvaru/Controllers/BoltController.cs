using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Konyvaru.Models;


namespace Konyvaru.Controllers
{
    public class BoltController : Controller
    {
        readonly ApplicationDbContext _context;
        public BoltController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var knyv = _context.Elofizetesek.ToList();
            return View(knyv);
        }

    }
}