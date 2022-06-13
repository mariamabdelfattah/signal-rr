
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lap1signalr.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> Options) : base(Options)
        {
        }
        public virtual DbSet<Employee> Employee { get; set; }
    }
}
