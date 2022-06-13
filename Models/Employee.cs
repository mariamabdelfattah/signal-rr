using Microsoft.EntityFrameworkCore;
namespace Lap1signalr.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string name{ get; set; }
        public string Address { get; set; }
        public  int age { get; set; }
    }
}
