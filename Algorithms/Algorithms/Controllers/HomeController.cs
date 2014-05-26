using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Algorithms.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Palindrome()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Palindrome(AlgorithmsModel am)
        {
            
            if (am.IsPalindrome(am.Text))
                ViewBag.Indicator = "<div class='alert alert-success'>The string <strong>"+am.Text+"</strong> is Palindrome</div>";
            else
                ViewBag.Indicator = "<div class='alert alert-danger'>The string <strong>" + am.Text + "</strong> is not Palindrome</div>";
            return View();
        }

        public ActionResult Fibonacci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fibonacci(AlgorithmsModel am)
        {
            ViewBag.Serie = "<div class='alert alert-success'>" + am.Fibonacci(am.Number) + "</div>";
            return View();
        }
    }
}
