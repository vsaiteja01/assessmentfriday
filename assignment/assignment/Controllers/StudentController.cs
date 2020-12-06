using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assignment.Models;

namespace assignment.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            List<Student> stud = new List<Student>()
            {

                 new Student(){SId=1,SName="rohan",SDOB="31/12/2020",SContact="6090909090"},
                 new Student(){SId=2,SName="mohan",SDOB="31/11/2020",SContact="8190909090"},
                 new Student(){SId=3,SName="rajiv",SDOB="31/10/2020",SContact="7890909090" },
                 new Student(){SId=4,SName="shukla",SDOB="31/02/2020",SContact="8090909090" },
                 new Student(){SId=5,SName="naveen",SDOB="31/03/2020",SContact="7090909090",}
 




            };

            return View(stud);
        }
    }
}
