using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCalendar.Models;

namespace MyCalendar.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View("CalendarContainer");
        }

         [HttpGet]
        public ActionResult Month(string month, string year)
        {
            if(month==null || year == null)
            {
                var currentDay = DateTime.Now;
                month = currentDay.Month.ToString();
                year = currentDay.Year.ToString();
            }
            ViewBag.Month = int.Parse(month);
            ViewBag.Year = int.Parse(year);
            List<Event> events = new List<Event>
            {
                new Event()
                {
                    Name = "First One",
                    Start = DateTime.Parse("10/11/2018 09:00"),
                    End = DateTime.Parse("10/11/2018 10:00"),
                    Class = null,
                    Instructor = null,
                }
            };

            return View(events);
        }

        [HttpGet]
        public ActionResult Week(string week)
        {
            if (string.IsNullOrEmpty(week))
                week = DateTime.Now.ToShortDateString();

            DateTime currentDate = DateTime.Parse(week);
            ViewBag.CurrentDate = currentDate;
            List<Event> events = new List<Event>
            {
                new Event()
                {
                    Name = "First One",
                    Start = DateTime.Parse("10/11/2018 09:00"),
                    End = DateTime.Parse("10/11/2018 10:00"),
                    Class = null,
                    Instructor = null,
                }
            };
            return View(events);
        }

        [HttpGet]
        public ActionResult CalendarContainer(string month, string year)
        {
            if (month == null || year == null)
            {
                var currentDay = DateTime.Now;
                month = currentDay.Month.ToString();
                year = currentDay.Year.ToString();
            }
            ViewBag.Month = int.Parse(month);
            ViewBag.Year = int.Parse(year);

            return View();
        }
    }
}

#region Not needed for now

//// GET: Calendar/Details/5
//public ActionResult Details(int id)
//{
//    return View();
//}

//// GET: Calendar/Create
//public ActionResult Create()
//{
//    return View();
//}

//// POST: Calendar/Create
//[HttpPost]
//public ActionResult Create(FormCollection collection)
//{
//    try
//    {
//        // TODO: Add insert logic here

//        return RedirectToAction("Index");
//    }
//    catch
//    {
//        return View();
//    }
//}

//// GET: Calendar/Edit/5
//public ActionResult Edit(int id)
//{
//    return View();
//}

//// POST: Calendar/Edit/5
//[HttpPost]
//public ActionResult Edit(int id, FormCollection collection)
//{
//    try
//    {
//        // TODO: Add update logic here

//        return RedirectToAction("Index");
//    }
//    catch
//    {
//        return View();
//    }
//}

//// GET: Calendar/Delete/5
//public ActionResult Delete(int id)
//{
//    return View();
//}

//// POST: Calendar/Delete/5
//[HttpPost]
//public ActionResult Delete(int id, FormCollection collection)
//{
//    try
//    {
//        // TODO: Add delete logic here

//        return RedirectToAction("Index");
//    }
//    catch
//    {
//        return View();
//    }
//}

#endregion