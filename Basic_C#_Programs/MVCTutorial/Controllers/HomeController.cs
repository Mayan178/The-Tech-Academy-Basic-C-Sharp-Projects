using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //logging in data when page visited
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\LENOVO-THINKPAD-T430\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\text-log.txt", text);
            //

            //printing out random number
            //Random rnd = new Random(10);
            //var num = rnd.Next();
            //ViewBag.RandomNumber = num;
            //displaying a different page (About page) if number above 20000
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //returning the word "hello"
            //return Content("hello");

            //returning a redirect to the Contact page
            //return RedirectToAction("Contact");

            //returning the content of the contact page, but still on the index page
            //return View("Contact");

            //testing data from a list instead of using the Model folder
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            //passing through a number value instead of using the Model folder
            //int number = 5;
            //return View(number);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;

            return View(user);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throwing an error
            //throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact()
        {
          
            return View();
        }

       //passing through parameter
        //public ActionResult Contact(int id = 0)
        //{
        //    ViewBag.Message = id;

        //    return View();
        //}
    }
}