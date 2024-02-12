using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SEO14.Models;
using SEO14.Models.ViewModels;


namespace SEO14.Controllers
{
    public class StudentController : Controller
    {
        DbStudentContext db=new DbStudentContext();
      
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }


        public ActionResult List()
        {
         var list1= db.Students.Select(t => new {t.Name,t.Family,t.PhoneNumber,t.Password}).ToList();
        
            List<StudentViewModels> students = new List<StudentViewModels>();
            foreach (var item in list1)
            {
                students.Add(new StudentViewModels()
                {
                    Name = item.Name,
                    Family = item.Family,
                    Password = item.Password,         
                    
                    PhoneNumber = item.PhoneNumber
                });
            }

            return View(students);
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "PhoneNumber,Password")]LodinViewModel lodinView)
        {
            if (ModelState.IsValid)
            {
              
                if (db.Students.Any(t=>t.PhoneNumber== lodinView.PhoneNumber && t.Password== lodinView.Password))
                {
                    var LoginAdmin = db.Students.First(t => t.PhoneNumber == lodinView.PhoneNumber && t.Password == lodinView.Password);
                    var name= LoginAdmin.Name + " " + LoginAdmin.Family.ToList();
                
                    return RedirectToAction("List");
                }
                else
                {
                    return View(lodinView);
                }
            }

            return View(lodinView);
        }
    }
}