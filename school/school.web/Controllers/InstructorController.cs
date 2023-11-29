using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school.DAL.Interfaces;

namespace school.web.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorDao instructorDao;
        public InstructorController(IInstructorDao instructorDao)
        {
            this.instructorDao = instructorDao;
        }
        // GET: InstructorController
        public ActionResult Index()
        {
            var instructors = this.instructorDao.GetInstructors().Select(ins => new Models.InstructorListModel()
            {
                CreationDate = ins.CreationDate,
                HireDate = ins.HireDate,
                HireDateDisplay = ins.HireDateDisplay,
                Id = ins.Id,
                Name = ins.Name,
            }).ToList();
            return View();
        }

        // GET: InstructorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InstructorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstructorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstructorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstructorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstructorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InstructorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
