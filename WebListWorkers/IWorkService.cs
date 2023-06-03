using WebListWorkers.Models;

namespace WebListWorkers
{
    public interface IWorkService
    {
        void Create(Worker employee);
        void Delete(int? id);
        void Edit(Worker worker);
        List<Worker> GetWorkers();
        Worker FindWorker(int? id);
    }
}