using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebListWorkers.Interfaces;
using WebListWorkers.Models;

namespace WebListWorkers.Service
{
    public class WorkService : IWorkService
    {
        ApplicationContext _context;
     
        public WorkService(ApplicationContext context)
        {
            _context = context;
        }
        public List<Worker> GetWorkers()
        {
            var workers = _context.Workers.Take(30).OrderByDescending(x => x.ID).ToList();
            return workers;
        }
        public void Create(Worker employee, IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    photo.CopyTo(memoryStream);
                    employee.Photo = memoryStream.ToArray();
                }
            }
            _context.Workers.Add(employee);
            _context.SaveChanges();
        }
        public void Edit(Worker worker, IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    photo.CopyTo(memoryStream);
                    worker.Photo = memoryStream.ToArray();
                }
            }
            _context.Entry(worker).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(int? id)
        {
            Worker? worker = _context.Workers.Find(id);
            if (worker != null)
            {
                _context.Workers.Remove(worker);
                _context.SaveChanges();
            }
        }
        public Worker FindWorker(int? id)
        {
            return _context.Workers.Find(id);
        }
        public List<Worker> GetWorkersMore(int count)
        {
            var workers = _context.Workers.Take(count).OrderByDescending(x => x.ID).ToList();
            return workers;
        }
        public List<Worker> FindWorker(string serch)
        {
            var employees = _context.Workers.Where(e => e.FullName.Contains(serch) || e.Phone.Contains(serch)).ToList();
            if (employees.Count == 0)
            {
                return GetWorkers();
            }
            return employees;
        }
        
    }
}
