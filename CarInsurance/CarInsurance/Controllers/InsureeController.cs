using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                // Calculate and set the initial quote
                insuree.Quote = CalculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = insuree.Id });
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate and update the quote
                insuree.Quote = CalculateQuote(insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = insuree.Id });
            }

            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private decimal CalculateQuote(Insuree insuree)  
        {

            // calculates insurees age
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;    // current year - insuree birth year
            if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)    // compares current day of the year to insurees birth date
            {
                age--;  // adjusts age if birthday hasn't occured yet
            }

            decimal baseQuote = 50;    // calculate quote on base

            // age calculation
            if (age <= 18)
            {
                baseQuote += 100;
            }
            else if (age >= 19 && age <= 25)
            {
                baseQuote += 50;
            }
            else
            {
                baseQuote += 25;
            }

            // car year calculation
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                baseQuote += 25;
            }

            // car make calculation
            if (insuree.CarMake == "Porsche")
            {
                baseQuote += 25;
                if (insuree.CarModel == "911 Carrera")
                {
                    baseQuote += 25;
                }
            }

            // speeding ticket calculation
            baseQuote += 10 * insuree.SpeedingTickets;

            // DUI calculation
            if (insuree.DUI)
            {
                baseQuote += baseQuote * 0.25m;
            }

            // coverage calculation
            if (insuree.CoverageType)
            {
                baseQuote += baseQuote * 0.5m;
            }

            return baseQuote;
        }

        // Admin view based on InsureeVm
        public ActionResult Admin()
        {
            var insureeVm = db.Insurees.Select(i => new InsureeVm
            {
                FirstName = i.FirstName,
                LastName = i.LastName,
                EmailAddress = i.EmailAddress,
                Quote = i.Quote
            }).ToList();

            return View(insureeVm);
        }
    }
}
