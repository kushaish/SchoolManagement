using System.Web.Mvc;
using BLayer;
using System.Collections.Generic;
using MVCSampleApplication.Models;
namespace MVCSampleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BusinessLayer objLayer = new BusinessLayer();
           // var a=objLayer.GetAllStudent();

            List<StudentModel> list = new List<StudentModel>();
            list.Add(new StudentModel { ID = 1, StudentName = "Ashish", Age = 30, TotalCourseEnrolled = 10 });
            list.Add(new StudentModel { ID = 2, StudentName = "Shantanu", Age = 31, TotalCourseEnrolled = 5 });
            list.Add(new StudentModel { ID = 3, StudentName = "Pankaj", Age = 29, TotalCourseEnrolled = 21 });
            return View(list);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult ViewLyubomir()
        {
            return PartialView("_ModelPopUp");
        }
    }
}