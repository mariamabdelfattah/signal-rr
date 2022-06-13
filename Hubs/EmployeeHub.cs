using Microsoft.AspNetCore.SignalR;
using Lap1signalr.Models;

namespace Lap1signalr.Hubs
{
    public class EmployeeHub:Hub
    {
        EmployeeContext db;
        public EmployeeHub(EmployeeContext db)
        {
            this.db = db;
        }
        public void sendEmployee(Employee emp)
        {
            //Employee emp=new Employee() { name=name ,Address=address,age=age};
            db.Add(emp);
            db.SaveChanges();
            //send data to all online
            Clients.All.SendAsync("newEmployee", emp);  


        }
    }
}
