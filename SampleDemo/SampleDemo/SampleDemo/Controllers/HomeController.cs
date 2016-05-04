using SampleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        static List<tblStudent> _lstEmployee = new List<tblStudent>();
        public ActionResult Index()
        {

            StudentsEntities db = new StudentsEntities();
            return View(db.tblStudents.ToList());
        }

    }
}