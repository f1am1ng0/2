using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        private string _employeeName;
        public string Salary { get; set; } 

        public Employee(string employeeName, string salary)
        {
            _employeeName = employeeName;
            Salary = salary;
        }

        public string DisplayInfo()
        {
            return $"Hi, I'm {_employeeName} and I earn {Salary} per year";
        }
    }
}
