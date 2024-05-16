using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Employee.Mudels
{
    public class Employee
    {
       
        

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Decimal Salary { get; set; }
        public DateTime HData { get; set; }
        public string? Department { get; set; }
        public bool  IsActive { get; set; }
    }
}
