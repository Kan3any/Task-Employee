using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Employee.Mudels
{
    internal class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public bool isActiv { get; set; }



    }
}
