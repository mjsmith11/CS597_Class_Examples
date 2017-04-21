using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week14Friday.Models;

namespace Week14Friday.Controllers
{
    public class SchedulesController : Controller
    {
        private CoursesEntities db = new CoursesEntities();

        public ActionResult DropDownDemo()
        {
            
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Chicago", Value = "0" });
            items.Add(new SelectListItem { Text = "Boston", Value = "1", Selected=true});
            items.Add(new SelectListItem { Text = "Detroit", Value = "2" });
            ViewBag.Location = items;
            return View(db.Schedules.ToList());
        }
        // GET: Schedules
        public ActionResult Index(string sortBy, string searchString, string courseNumber)
        {
            if(Request.Form["courseNumber"] != null)
                Response.Write(Request.Form["courseNumber"].ToString());
            var courseNumberList = new List<string>();
            var number = from s in db.Schedules select s.CourseNumber;
            courseNumberList.AddRange(number.Distinct());
            ViewBag.courseNumber = new SelectList(courseNumberList, 120);//120 is default

            //Response.Write("Hello World"); //this would work

            if (String.IsNullOrEmpty(sortBy))
                sortBy = "";
            var courses = from e in db.Schedules select e;
            if (sortBy.Equals("CourseNumber"))
            {
                //courses = from e in db.Schedules orderby e.CourseNumber select e;
                courses = courses.OrderBy(e => e.CourseNumber);
            }
            else if (sortBy.Equals("SectionNumber"))
            {
                //courses = from e in db.Schedules orderby e.SectionNumber select e;
                courses = courses.OrderBy(e => e.SectionNumber);
            }

            if(!String.IsNullOrEmpty(courseNumber))
            {
                //courses = courses.Where(....)
            }
            if(!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(e => e.CourseNumber.Contains(searchString)); //this condition can be as complex as necessary
            }
            //issue: search undoes sort. sort removes search. Use session or query string to help it

            return View(courses.ToList());
        }

        // GET: Schedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // GET: Schedules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CRN,CourseNumber,SectionNumber,Days,StartTime,EndTime")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Schedules.Add(schedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CRN,CourseNumber,SectionNumber,Days,StartTime,EndTime")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Schedule schedule = db.Schedules.Find(id);
            db.Schedules.Remove(schedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //notice delete view has multiple actions

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Sample()
        {
            return View();
        }
    }
}
