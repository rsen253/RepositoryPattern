using System;
using System.Web.Mvc;
using Defination;
using Interface;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork(new PlutoContext());
        }

        #region Index

        public ActionResult Index()
        {
            var course = new Course
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ASP",
                Level = 3,
                FullPrice = 200,
                Description = "The bast ASP course on the web"
            };
            unitOfWork.Course.Add(course);
            unitOfWork.Complete();
            var AllCoueses = unitOfWork.Course.GetAll();
            var Courses = unitOfWork.Course.GetTopSellingCourses(5);

            return Content("Done");
        }

        #endregion
    }
}