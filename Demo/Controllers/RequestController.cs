using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Assignment.Controllers
{

    public class RequestController : Controller
    {
        private ApplicationDbContext context;
        public RequestController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(context.Requests.ToList());
        }


        [Authorize(Roles = "Staff")]
        [HttpGet]
        public IActionResult MakeRequest()
        {

            return View();
        }

        [Authorize(Roles = "Staff")]
        [HttpPost]
        public IActionResult MakeRequest(Request request)
        {
            if (ModelState.IsValid)
            {
                request.Status = false;
                context.Add(request);
                context.SaveChanges();

                return RedirectToAction(nameof(MakeRequest));
            }
            return View(request);
        }

        //delete the request
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var request = context.Requests.Find(id);
            context.Requests.Remove(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Approved(int id)
        {
            var request = context.Requests.Find(id);
            request.Status = true;
            context.Requests.Update(request);
            Category category = new Category();
            //category.Id = id;
            category.Name = request.CategoryName;
            context.Category.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //display all requests
        [Authorize(Roles = "Admin")]
        public IActionResult DisplayRequests()
        {
            return View(context.Requests.ToList());
        }
    }
}