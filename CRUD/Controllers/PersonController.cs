using CRUD.Data.Entities;
using CRUD.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        // GET: PersonController
        public ActionResult Index()
        {
            var person = this.personRepository.Obtener();
            return View(person);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            var person = this.personRepository.ObtenerPorId(id);
            return View(person);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            this.personRepository.Agregar(person);
            return RedirectToAction(nameof(Index));
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            var person = personRepository.ObtenerPorId(id);
            return View(person);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Person person)
        {
            this.personRepository.Actualizar(person);
            return RedirectToAction(nameof(Index));
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            this.personRepository.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: PersonController/Delete/5
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
