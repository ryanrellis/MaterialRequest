using MaterialRequest.Data;
using MaterialRequest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterialRequest.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RequestController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Request> requestList = _db.Requests.Where(c => c.Completed == false).OrderBy(req => req.TimeNeeded);

            return View(requestList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Request request)
        {
            if(ModelState.IsValid)
            {
                if (request.Location == null)
                {
                    request.Location = "N/A";
                }
                request.RequestedAt = DateTime.Now;
                _db.Requests.Add(request);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(request);
            }
            
        }

        public IActionResult Update(int id)
        {
            return View();
        }

        public IActionResult Update(Request request)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        public IActionResult Completed()
        {
            IEnumerable<Request> completedRequests = _db.Requests.Where(req => req.Completed == true).OrderBy(d => d.CompletedAt);
            return View(completedRequests);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MarkComplete(int id)
        {
            Request request = _db.Requests.FirstOrDefault(r => r.Id == id);
            if (request != null)
            {
                request.Completed = true;
                request.CompletedAt = DateTime.Now;
                _db.Requests.Update(request);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(request);
            }
        }


    }
}
