﻿using Microsoft.AspNetCore.Mvc;
using WebListWorkers.Interfaces;
using WebListWorkers.Models;

namespace WebListWorkers.Controllers
{
    /// <summary>
    /// Контроллер для справочника работников
    /// </summary>
    public class WorkerController : Controller
    {
        IWorkService _work;
        public WorkerController(IWorkService work)
        {
            _work = work;
        }
        public IActionResult Index()
        {
            List<Worker> workers = _work.GetWorkers();
            return View(workers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Worker employee)
        {
            if (ModelState.IsValid)
            {
                _work.Create(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var worker = _work.FindWorker(id);
            if (worker != null)
            {
                return View(worker);
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult Edit(Worker worker)
        {
            _work.Edit(worker);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            _work.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
