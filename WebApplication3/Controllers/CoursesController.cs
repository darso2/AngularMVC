using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View("Index");
        }

        public string getCourseVMs()
        {
            var courses = new[]
            {
                new CourseVM {number = "MATH40002", name = "Level 4 introduction to mathematics", lecturer = "Nigel Ray"},
                new CourseVM {number = "MATH30002", name = "Level 3 introduction to mathematics", lecturer = "Digel Say"},
                new CourseVM {number = "MATH20002", name = "Level 2 introduction to mathematics", lecturer = "Tigel May"},
            };
            
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver()};
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }
    }
    

    public class CourseVM
    {
        public string number { get; set; }
        public string name { get; set; }
        public string lecturer { get; set; }
    }
}