using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Demo.Controllers
{
    public class BookController : Controller
    {

        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //xếp mobile mới được hiển thị ở đầu danh sách (sort id giảm dần)
            var mobiles = context.Book.OrderByDescending(m => m.Id).ToList();
            return View(mobiles);
        }

        [Authorize(Roles = "Customer")]
        //hiển thị giao diện dạng card cho khách hàng order sản phẩm
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }

        //xoá dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var mobile = context.Book.Find(id);
            context.Book.Remove(mobile);
            context.SaveChanges();
            TempData["Message"] = "Delete mobile successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        [Authorize(Roles = "Admin, Customer")]
        public IActionResult Detail(int id)
        {
            var book = context.Book.Include(m => m.Category)  //Book  - Category : 1 - M
                                       .Include(b => b.Author)  //Book - Author : M - 1
                                       .FirstOrDefault(b => b.Id == id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //đẩy danh sách của country sang bảng Add Mobile
            ViewBag.Brands = context.Category.ToList();
            return View();
        }

        //hàm 2: nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Create(Book book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add mobile successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(book);
        }


        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Brands = context.Category.ToList();
            return View(context.Book.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit mobile successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(book);
        }

        public IActionResult PriceAsc()
        {
            var mobiles = context.Book.OrderBy(m => m.Price).ToList();
            return View("Store", mobiles);
        }

        public IActionResult PriceDesc()
        {
            var mobiles = context.Book.OrderByDescending(m => m.Price).ToList();
            return View("Store", mobiles);
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var mobiles = context.Book.Where(m => m.Name.Contains(keyword)).ToList();
            return View("Store", mobiles);
        }

    }
}
