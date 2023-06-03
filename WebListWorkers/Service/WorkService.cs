using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Worker> workers = _context.Workers.ToList();
            return workers;
        }
        public void Create(Worker employee)
        {
            _context.Workers.Add(employee);
            _context.SaveChanges();
        }
        public void Edit(Worker worker)
        {
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
    }
}
