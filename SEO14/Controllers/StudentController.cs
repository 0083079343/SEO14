using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SEO14.Models;

namespace SEO14.Controllers
{
    public class StudentController : Controller
    {
        DbStudentContext db=new DbStudentContext(); 
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}