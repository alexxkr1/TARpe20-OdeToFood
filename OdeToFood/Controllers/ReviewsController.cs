//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using OdeToFood.Models;
//namespace OdeToFood.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: Review
//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.Country
//                select r;
//            return View(model);
//        }

//        // GET: Review/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Review/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Review/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ReviewsController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            return View(review);
//        }

//        // POST: ReviewsController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Edit(int id, IFormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            if (await TryUpdateModelAsync(review))
//            {
//                return RedirectToAction("Index");
//            }
//            return View(review);
//        }

//        // GET: Review/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Review/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        private static List<RestarauntReview> _reviews = new List<RestarauntReview>
//        {
//            new RestarauntReview
//            {
//                Id = 1,
//                Name = "Alex",
//                City = "Tallinn",
//                Country = "Estonia",
//                Rating = 5
//            },
//            new RestarauntReview
//            {
//                Id = 2,
//                Name = "Alext",
//                City = "Taty",
//                Country = "Estonia",
//                Rating = 4
//            },
//            new RestarauntReview
//            {
//                Id = 3,
//                Name = "Alexx",
//                City = "yolo",
//                Country = "Estonia",
//                Rating = 3
//            }
//        };
//    }

//}