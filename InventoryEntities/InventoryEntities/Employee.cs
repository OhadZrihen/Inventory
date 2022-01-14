using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryEntities
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive = true;
        public string? Position { get; set; }
        public int ProductionId { get; }
    }
    public class Manager : Employee
    {
        public string Position = "Manager";
    }
    public class Worker : Employee
    {
        public string Position = "Worker";
    }
}
