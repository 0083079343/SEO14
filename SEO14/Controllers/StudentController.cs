using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using SEO14.Models;
using SEO14.Models.ViewModels;


namespace SEO14.Controllers
{
    public class StudentController : Controller
    {
        DbStudentContext db = new DbStudentContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }


        public ActionResult List()
        {
            var list1 = db.Students.Select(t => new { t.Name, t.Family, t.PhoneNumber, t.Password }).ToList();

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

            return PartialView(students);
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "PhoneNumber,Password")] LodinViewModel lodinView)
        {
            if (ModelState.IsValid)
            {

                if (db.Students.Any(t => t.PhoneNumber == lodinView.PhoneNumber && t.Password == lodinView.Password))
                {
                    var LoginAdmin = db.Students.First(t => t.PhoneNumber == lodinView.PhoneNumber && t.Password == lodinView.Password);
                    var name = LoginAdmin.Name + " " + LoginAdmin.Family;

                    FormsAuthentication.SetAuthCookie(lodinView.PhoneNumber, false);
                    

                    
                    return RedirectToAction("List");
                }
                else
                {
                    return View(lodinView);
                }
            }

            return View(lodinView);
        }

        public ActionResult WelcomeAdmin()
        {
            var loginId = User.Identity.Name;
            var studentLogin = db.Students.FirstOrDefault(t => t.PhoneNumber == loginId).Id;

            var student = db.Students.Find(studentLogin);

            return PartialView(student);
        }
    }
}