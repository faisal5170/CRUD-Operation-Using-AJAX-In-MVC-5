using AjaxCrudOperationUsingMVC5.Models;
using System.Linq;
using System.Web.Mvc;

namespace AjaxCrudOperationUsingMVC5.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController()
        {
            _context = new Context();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(_context.User.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Users user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(int ID)
        {
            return Json(_context.User.FirstOrDefault(x=>x.Id==ID), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Users user)
        {
            var data = _context.User.FirstOrDefault(x => x.Id == user.Id);
            if (data != null) {
                data.Name = user.Name;
                data.State = user.State;
                data.Country = user.Country;
                data.Age = user.Age;
                _context.SaveChanges();
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            var data = _context.User.FirstOrDefault(x => x.Id == ID);
            _context.User.Remove(data);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}