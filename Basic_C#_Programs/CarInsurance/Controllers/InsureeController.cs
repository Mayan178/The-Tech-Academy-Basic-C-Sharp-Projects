using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

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
                //added here to work out quote based on user data
                //set up a base rate of $50 per month
                decimal quoteEstimate = 50;
                // working out when the user will turn/turned 18, based on date of birth.
                var whenTurn18 = new DateTime(insuree.DateOfBirth.Year+18, insuree.DateOfBirth.Month, insuree.DateOfBirth.Day);
                //find out when they turn 19
                var whenTurn19 = new DateTime(whenTurn18.Year + 1, whenTurn18.Month, whenTurn18.Day);
                //find out when they turn 25
                var whenTurn25 = new DateTime(whenTurn18.Year + 7, whenTurn18.Month, whenTurn18.Day);
                //find out when they turn 26
                var whenTurn26 = new DateTime(whenTurn18.Year + 8, whenTurn18.Month, whenTurn18.Day);
                //setting up variable to check against for the make of the car
                var porscheName = "porsche";
                //setting up variable to check against for the model of the car (if Porsche)
                var porscheModel = "911 carrera";

                //now comparing the date found to current date. 
                //the user has not turned 19 yet, so they are 18 or under
                if (whenTurn19 > DateTime.Today)
                {
                    quoteEstimate = quoteEstimate + 100;
                }
                //the applicant is between 19 and 25 (they have had their 19th birthday and not yet had their 26th birthday)
                else if (whenTurn19 <= DateTime.Today && whenTurn26 > DateTime.Today)
                {
                    quoteEstimate = quoteEstimate + 50;
                }
                //the applicant is 26 or older
                else if (whenTurn26 <= DateTime.Today)
                {
                    quoteEstimate = quoteEstimate + 25;
                }
                ;

                //now look at the year the car was made and if prior to 2000, add to quote
                if (insuree.CarYear < 2000)
                {
                    quoteEstimate = quoteEstimate + 25;
                }
                //if the year the car was made was after 2015 add to quote
                else if (insuree.CarYear > 2015)
                {
                    quoteEstimate = quoteEstimate + 25;
                }
                ;

                //look into the make of the car and if "Porsche" add 25
                if (insuree.CarMake.ToLower() == porscheName.ToLower())
                {
                    quoteEstimate = quoteEstimate + 25;

                    //if the model of car is a 911 Carrera add extra 25
                    if (insuree.CarModel.ToLower() == porscheModel.ToLower())
                    {
                        quoteEstimate = quoteEstimate + 25;
                    };
                };

                //looking at the number of speeding tickets and adding an extra 10 to the quote for every one
                if (insuree.SpeedingTickets > 0)
                {
                    quoteEstimate = quoteEstimate + (insuree.SpeedingTickets*10);
                };

                //if the user has ever had a DUI, add 25% to the quote
                if (insuree.DUI)
                {
                    quoteEstimate = quoteEstimate * 125 / 100;
                };

                //if the user wants full coverage (ticked the box), then add 50% to total
                if (insuree.CoverageType)
                {
                    quoteEstimate = quoteEstimate * 150 / 100;
                };

                //now set the value we will insert into the database for Quote to quoteEstimate value
                insuree.Quote = quoteEstimate;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
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
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
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

        //Admin view
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
