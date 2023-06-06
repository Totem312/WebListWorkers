namespace WebListWorkers.Models
{
    public class Worker
    {
        public int ID { get; set; }
        public string? FullName { get; set; }
        public string? DepartmentName { get; set; }
        public string? Phone { get; set; }
        public byte[]? Photo { get; set; }
    }
}
