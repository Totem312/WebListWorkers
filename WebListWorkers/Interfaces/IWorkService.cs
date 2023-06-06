using WebListWorkers.Models;

namespace WebListWorkers.Interfaces
{
    public interface IWorkService
    {
        void Create(Worker employee,IFormFile form);
        void Delete(int? id);
        void Edit(Worker worker,IFormFile photo);
        List<Worker> GetWorkers();
        Worker FindWorker(int? id);
        public List<Worker> GetWorkersMore(int value);
        public List<Worker> FindWorker(string serch);
    }
}